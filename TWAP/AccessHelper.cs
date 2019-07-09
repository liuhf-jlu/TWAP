using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace TWAP
{
    /// <summary>
    /// Access数据库操作类
    /// </summary>
    class AccessHelper
    {
        private string conn_str = null;
        private OleDbConnection connection = null;
        private OleDbCommand command = null;
        private OleDbDataReader reader = null;
        private DataTable dt = null;

        /// <summary>
        /// 默认值为连接RegionDb.mdb
        /// </summary>
        public AccessHelper()
        {
            conn_str = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + System.IO.Directory.GetCurrentDirectory().ToString() + "\\RegionDB.mdb";//DeBug目录下的数据库
            InitDB();
        }
        /// <summary>
        /// 连接指定的数据库
        /// </summary>
        /// <param name="db_path"数据库路径></param>
        public AccessHelper(string db_path)
        {
            conn_str = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + "'" + db_path + "'";//用户自定义的数据库
            InitDB();
        }

        /// <summary>
        /// 初始化DB
        /// </summary>
        private void InitDB()
        {
            connection = new OleDbConnection(conn_str);//创建实例
            command = new OleDbCommand();
        }

        /// <summary>
        /// 转换数据格式
        /// </summary>
        /// <param name="reader">数据源</param>
        /// <returns>数据列表</returns>
        private DataTable ConvertOleDbReaderToDataTable(ref OleDbDataReader reader)
        {
            DataTable dt_tmp = null;
            DataRow dr = null;
            int data_column_count = 0;
            int i = 0;

            data_column_count = reader.FieldCount;
            dt_tmp = BuildAndInitDataTable(data_column_count);

            if (dt_tmp == null)
            {
                return null;
            }
            while (reader.Read())
            {
                dr = dt_tmp.NewRow();
                for (i = 0; i < data_column_count; i++)
                {
                    dr[i] = reader[i];
                }
                dt_tmp.Rows.Add(dr);
            }
            return dt_tmp;
        }

        /// <summary>
        /// 创建并初始化数据列表
        /// </summary>
        /// <param name="Field_Count">列的个数</param>
        /// <returns>数据列表</returns>
        private DataTable BuildAndInitDataTable(int Field_Count)
        {
            DataTable dt_tmp = null;
            DataColumn dc = null;
            int i = 0;

            if (Field_Count <= 0)
            {
                return null;
            }
            dt_tmp = new DataTable();
            for (i = 0; i < Field_Count; i++)
            {
                dc = new DataColumn(i.ToString());
                dt_tmp.Columns.Add(dc);
            }
            return dt_tmp;
        }

        /// <summary>
        /// 从数据库里面获取数据
        /// </summary>
        /// <param name="strSql">查询语句</param>
        /// <returns>数据列表</returns>
        public DataTable GetDataTableFromDB(string strSql)
        {
            if (conn_str == null)
            {
                return null;
            }
            try
            {
                connection.Open();//打开连接
                if (connection.State == ConnectionState.Closed)
                {
                    return null;
                }
                command.CommandText = strSql;
                command.Connection = connection;

                reader = command.ExecuteReader(CommandBehavior.Default);

                dt = ConvertOleDbReaderToDataTable(ref reader);

                reader.Close();
                reader.Dispose();

            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
            return dt;
        }

        /// <summary>
        /// 执行sql语句
        /// </summary>
        /// <param name="strsql">sql语句</param>
        /// <returns>返回结果</returns>
        public int ExcuteSql(string strsql)
        {
            int nResult = 0;
            try
            {
                connection.Open();
                if (connection.State == ConnectionState.Closed)
                {
                    return nResult;
                }
                command.Connection = connection;
                command.CommandText = strsql;

                nResult = command.ExecuteNonQuery();
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.ToString());
                return nResult;
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
            return nResult;
        }
    }
}
