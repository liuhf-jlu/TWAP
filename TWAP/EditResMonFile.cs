using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using System.Data.Odbc;

namespace TWAP
{
    /// <summary>
    /// 水库数据文件mon的操作类
    /// </summary>
    class EditResMonFile
    {
        FileStream fs;
        StreamWriter sw;

        /// <summary>
        /// 创建.mon文件，该文件存放水库的流量数据
        /// </summary>
        /// <param name="str_name">水库编号</param>
        /// <param name="str_sql">dbf文件路径</param>
        public void creatMonFile(string ReservoirID, string DBFDir)
        {
            int line=0;   //获取dbf文件有多少行
            //判断水库编号的大小，进行文件名的字符串拼接
            string way = "";
            if (Convert.ToInt32(ReservoirID) < 10)
                way = Application.StartupPath + "\\TxtInOut\\0000" + ReservoirID.ToString() + "0000.mon";
            else if (Convert.ToInt32(ReservoirID) > 9 && Convert.ToInt32(ReservoirID) < 100)
                way = Application.StartupPath + "\\TxtInOut\\000" + ReservoirID.ToString() + "0000.mon";
            else if (Convert.ToInt32(ReservoirID) >= 100 && Convert.ToInt32(ReservoirID) <= 999)
                way = Application.StartupPath + "\\TxtInOut\\00" + ReservoirID.ToString() + "0000.mon";

            fs = new FileStream(way, FileMode.Create);  //创建xxxxxxxxxx.mon文件
            sw = new StreamWriter(fs);
            string frist = "Monthly Reservoir Outflow file:     .mon file Subbasin:14 2019/5/16 0:00:00 ArcSWAT 2012.10_2.19";//写入mon文件的第一行
            sw.Write(frist + "\r\n");

            //创建dgf连接
            DbfHelper helper = new DbfHelper(DBFDir);
            string sql = "SELECT * FROM " + DBFDir;//sql语句查询
            DataTable dt = helper.GetDataTableFromDBF(sql);

            line = dt.Rows.Count;   //获取行数
            for (int count = 1000; count <= 3002; count++)//循环写入mon数据
            {
                int pd = 0;//用来判断数据库内容是否已经写完
                if (count == Convert.ToInt32(dt.Rows[pd][0].ToString()) && pd < line)//判断是否已经达到所在年份
                {
                    for (int row = 0; row < line; row++)
                    {
                        for (int drs = 1; drs <= 11; drs++)//循环写入行的十二个数据
                        {
                            sw.Write(Convert.ToDouble(dt.Rows[row][drs]).ToString("f2").PadLeft(10, ' '));//保留两位小数，从右往左写，每个数据占十个位置
                        }
                        sw.Write(Convert.ToDouble(dt.Rows[row][12]).ToString("f2").PadLeft(10, ' ') + "\r\n");//写完十一个数据后换行
                        count++;
                    }
                    pd++;
                }
                else//不是所在年份写默认值
                {
                    sw.Write("      0.00      0.00      0.00      0.00      0.00      0.00      0.00      0.00      0.00      0.00      0.00      0.00\r\n");
                }
            }
            sw.Flush();
            sw.Close();
            fs.Close();
        }
        

    }
}
