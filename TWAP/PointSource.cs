using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TWAP
{
    /// <summary>
    /// 点源操作类
    /// </summary>
    public class PointSource
    {
        /// <summary>
        /// 选择的点源
        /// </summary>
        private string cobPointId;
        /// <summary>
        /// 选择的路径
        /// </summary>
        private string path;
        
        public PointSource(string cobPointId, string path)
        {
            this.cobPointId = cobPointId;
            this.path = path;
        }

        /// <summary>
        /// 处理*.dat点源文件
        /// </summary>
        public void WriteDat()
        {
            try
            {
                //创建文件
                FileStream hr = new FileStream(Application.StartupPath + @"\TxtInOut" + "\\" + cobPointId + "p.dat", FileMode.Create, FileAccess.ReadWrite);
                StreamWriter sh = new StreamWriter(hr);
                //开始向文件写入第一行数据
                sh.WriteLine(DateTime.Now.ToString() + "  .dat file Annual Record Subbasin  8 in ArcSWAT 2012.10_2.19 interface" + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine);
                //写入列名
                sh.WriteLine(" YEAR          FLOCNST          SEDCNST         ORGNCNST         ORGPCNST          NO3CNST          NH3CNST          NO2CNST         MINPCNST         CBODCNST        DISOXCNST         CHLACNST       SOLPSTCNST       SRBPSTCNST        BACTPCNST       BACTLPCNST        CMTL1CNST        CMTL2CNST        CMTL3CNST");
                //读取文件，将每行读取的数据放进数组里
                string[] lists = File.ReadAllLines(path);
                //对数据进行处理，根据逗号分割，且转化为double类型
                for (int i = 1; i < lists.Length; i++)
                {
                    //接收lists数据
                    string line = lists[i];
                    string[] data = line.Split(',');

                    //将数据转换为double类型，存到文件中去
                    sh.WriteLine(" " + data[0] + " " + 
                        string.Format("{0:0.0000000000E+00}", Convert.ToDouble(data[1])) + " " + 
                        string.Format("{0:0.0000000000E+00}", Convert.ToDouble(data[2])) + " " + 
                        string.Format("{0:0.0000000000E+00}", Convert.ToDouble(data[3])) + " " + 
                        string.Format("{0:0.0000000000E+00}", Convert.ToDouble(data[4])) + " " + 
                        string.Format("{0:0.0000000000E+00}", Convert.ToDouble(data[5])) + " " + 
                        string.Format("{0:0.0000000000E+00}", Convert.ToDouble(data[6])) + " " + 
                        string.Format("{0:0.0000000000E+00}", Convert.ToDouble(data[7])) + " " + 
                        string.Format("{0:0.0000000000E+00}", Convert.ToDouble(data[8])) + " " + 
                        string.Format("{0:0.0000000000E+00}", Convert.ToDouble(data[9])) + " " + 
                        string.Format("{0:0.0000000000E+00}", Convert.ToDouble(data[10])) + " " + 
                        string.Format("{0:0.0000000000E+00}", Convert.ToDouble(data[11])) + " " + 
                        string.Format("{0:0.0000000000E+00}", Convert.ToDouble(data[12])) + " " + 
                        string.Format("{0:0.0000000000E+00}", Convert.ToDouble(data[13])) + " " + 
                        string.Format("{0:0.0000000000E+00}", Convert.ToDouble(data[14])) + " " + 
                        string.Format("{0:0.0000000000E+00}", Convert.ToDouble(data[15])) + " " + 
                        string.Format("{0:0.0000000000E+00}", Convert.ToDouble(data[16])) + " " + 
                        string.Format("{0:0.0000000000E+00}", Convert.ToDouble(data[17])) + " " + 
                        string.Format("{0:0.0000000000E+00}", Convert.ToDouble(data[18])));
                }
                //断开连接
                sh.Close();
                hr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 判断选的第几号点源
        /// ！！！此处存在严重问题！！！
        /// </summary>
        public void WriteFig()
        {
            if (cobPointId == "12")
            {
                write("reccnst       11    58     1", "recyear        8    58     1");
            }
            else if (cobPointId == "23")
            {
                write("reccnst       11    72     2", "recyear        8    72     2");
            }
            else if (cobPointId == "25")
            {
                write("reccnst       11   117     8", "recyear        8   117     5");
            }
            else if (cobPointId == "28")
            {
                write("reccnst       11   136     5", "recyear        8   136     6");
            }
            else if (cobPointId == "30")
            {
                write("reccnst       11   141    10", "recyear        8   141     7");
            }
            else if (cobPointId == "34")
            {
                write("reccnst       11    81     1", "recyear        8    81     3");
            }
            else if (cobPointId == "36")
            {
                write("reccnst       11    86     4", "recyear        8    86     4");
            }
            else if (cobPointId == "38")
            {
                write("reccnst       11    90     1", "recyear        8    90     5");
            }
            else if (cobPointId == "40")
            {
                write("reccnst       11    93     5", "recyear        8    93     1");
            }
            else if (cobPointId == "44")
            {
                write("reccnst       11   161     1", "recyear        8   161    12");
            }
            else if (cobPointId == "45")
            {
                write("reccnst       11    97     1", "recyear        8    97     7");
            }
            else if (cobPointId == "46")
            {
                write("reccnst       11   165    12", "recyear        8   165    11");
            }
            else if (cobPointId == "47")
            {
                write("reccnst       11   101     7", "recyear        8   101     7");
            }
            else if (cobPointId == "49")
            {
                write("reccnst       11   172    13", "recyear        8   172    11");
            }
        }

        /// <summary>
        /// 打开fig 文件,修改文件
        /// ！！！此处存在问题！！！
        /// </summary>
        /// <param name="outing"></param>
        /// <param name="uploading"></param>
        private void write(string outing, string uploading)
        {
            try
            {
                if (File.Exists(Application.StartupPath + @"\TxtInOut\fig.fig"))
                {
                    string strContent = File.ReadAllText(Application.StartupPath + @"\TxtInOut\fig.fig");
                    strContent = Regex.Replace(strContent, outing, uploading);
                    File.WriteAllText(Application.StartupPath + @"\TxtInOut\fig.fig", strContent);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
