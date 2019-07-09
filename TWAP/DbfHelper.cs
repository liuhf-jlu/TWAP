using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.IO;
using System.Data.Odbc;
using System.Data;

namespace TWAP
{
    /// <summary>
    /// dbf数据表操作类
    /// </summary>
    class DbfHelper
    {
        private OdbcConnection connection = null;
        private OdbcDataAdapter adapter = null;
        private string DBFDir = null;  //数据表名
        private string conn_str = null;     //dbf连接字符串

        /// <summary>
        /// dbf帮助类的构造函数
        /// </summary>
        /// <param name="TableName_">要连接的dnf文件的名称</param>
        public DbfHelper(string DBFDir_)
        {
            this.DBFDir = DBFDir_;
            conn_str =
                @"Driver={Microsoft dBASE Driver (*.dbf)};SourceType=DBF;" +
                @"Data Source=" + DBFDir + ";Exclusive=No;NULL=NO;" +
                @"Collate=Machine;BACKGROUNDFETCH=NO;DELETE=NO";
        }
        /// <summary>
        /// 初始化DB
        /// </summary>
        private void InitDB()
        {
            connection = new OdbcConnection(conn_str);
        }
        /// <summary>
        /// 执行查询sql语句
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <returns>数据表</returns>
        public DataTable GetDataTableFromDBF(string sql)
        {
            this.InitDB();
            if (sql == null)
            {
                return null;
            }
            connection.Open();//打开连接
            if (connection.State == ConnectionState.Closed)
            {
                return null;
            }
            adapter = new OdbcDataAdapter(sql, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }
}
