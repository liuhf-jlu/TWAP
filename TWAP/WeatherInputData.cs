using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace TWAP
{
    public partial class WeatherInputData : Form
    {
        FileAttr pcpfork = new FileAttr();
        FileAttr tmpfork = new FileAttr();
        FileAttr hmdfork = new FileAttr();
        FileAttr slrfork = new FileAttr();
        FileAttr wndfork = new FileAttr();
        AccessHelper helper = new AccessHelper();
        DataTable dt;
        FileStream fs;
        StreamWriter sw;
        OpenFileDialog ofd = new OpenFileDialog();
        /*
         * 调用外部DLL
         */
        [DllImport("EditorOfWeatherInput.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int pcp_(ref int length, ref string pcp_ini_path);

        [DllImport("EditorOfWeatherInput.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int tmp_(ref int length, ref string tmp_ini_path);

        [DllImport("EditorOfWeatherInput.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int hmd_(ref int length, ref string hmd_ini_path);
        [DllImport("EditorOfWeatherInput.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int slr_(ref int length, ref string slr_ini_path);
        [DllImport("EditorOfWeatherInput.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int wnd_(ref int length, ref string wnd_ini_path);
        /// <summary>
        /// 构造函数
        /// </summary>
        public WeatherInputData()
        {
            InitializeComponent();
            rtbMessage.Text = "";
        }

        /// <summary>
        /// 添加降雨数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddPcp_Click(object sender, EventArgs e)
        {
            try
            {
                //添加pcpfork文件
                ofd.Filter = "文本文件(*fork.txt)|*fork.txt";
                ofd.Title = "添加降雨量";
                ofd.RestoreDirectory = false;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    this.txShowPcp.Text = ofd.FileName;
                    pcpfork.setFileDir(ofd.FileName);
                }
                //将相关文件复制到Debug/WeatherData目录下
                copyForkAndStationFile(pcpfork.getFileDir());

                //编辑pcp1.pcp的前四行
                string[] stationArr = editExpressionLine("pcp").Split(',');

                //编辑date.txt年份日期文件
                editDate(stationArr[0]);    //因为每一个气象站记录文件的第一行都是开始日期，所以选择第一个气象站，提取其第一行的日期

                //将配置信息导入配置文件ini中
                importToIni(stationArr, "pcp");

                //使用批处理文件，调用Fortran程序处理文件
                //runBatFile("pcp");
                string str = Application.StartupPath + "\\pcpconf.ini";
                int str_length = str.Length;
                pcp_(ref str_length, ref str);

                //更改显示状态
                pcpStatus.Text = "complete!";
                pcpStatus.ForeColor = Color.Green;
                rtbMessage.Text = "加载降雨数据完成";
            }
            catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
            
        }

        /// <summary>
        /// 添加温度数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddTmp_Click(object sender, System.EventArgs e)
        {
            try
            {
                //添加temfork文件
                ofd.Filter = "文本文件(*fork.txt)|*fork.txt";
                ofd.Title = "添加温度";
                ofd.RestoreDirectory = false;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    this.txShowTmp.Text = ofd.FileName;
                    tmpfork.setFileDir(ofd.FileName);
                }
                //将相关文件复制到Debug/WeatherData目录下
                copyForkAndStationFile(tmpfork.getFileDir());

                //编辑tmp1.tmp的前四行
                string[] stationArr = editExpressionLine("tmp").Split(',');

                //编辑date.txt年份日期文件
                editDate(stationArr[0]);    //因为每一个气象站记录文件的第一行都是开始日期，所以选择第一个气象站，提取其第一行的日期

                //将配置信息导入配置文件ini中
                importToIni(stationArr, "tmp");

                //使用批处理文件，调用Fortran程序处理文件
                //runBatFile("tmp");
                string str = Application.StartupPath + "\\tmpconf.ini";
                int str_length = str.Length;
                tmp_(ref str_length, ref str);

                //更改显示状态
                tmpStatus.Text = "complete!";
                tmpStatus.ForeColor = Color.Green;
                rtbMessage.Text = "加载温度数据完成";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 添加相对湿度数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btAddHmd_Click(object sender, System.EventArgs e)
        {
            try
            {
                //添加hmdfork文件
                ofd.Filter = "文本文件(*fork.txt)|*fork.txt";
                ofd.Title = "添加相对湿度";
                ofd.RestoreDirectory = false;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    this.txShowHmd.Text = ofd.FileName;
                    hmdfork.setFileDir(ofd.FileName);
                }
                //将相关的hmdxxxxx文件复制到Debug/WeatherData/hmd目录下
                copyForkAndStationFile(hmdfork.getFileDir());
                Console.WriteLine("加载hmdfork文档完成！");

                //编辑hmd.hmd文件第一行
                string[] stationArr = editExpressionLine("hmd").Split(',');

                //编辑date.txt年份日期文件
                editDate(stationArr[0]);    //因为每一个气象站记录文件的第一行都是开始日期，所以选择第一个气象站，提取其第一行的日期

                //将配置信息导入配置文件ini中
                importToIni(stationArr, "hmd");

                //使用批处理文件，调用Fortran程序处理文件
                //runBatFile("hmd");
                string str = Application.StartupPath + "\\hmdconf.ini";
                int str_length = str.Length;
                hmd_(ref str_length, ref str);

                //更改显示状态
                hmdStatus.Text = "complete!";
                hmdStatus.ForeColor = Color.Green;
                rtbMessage.Text = "加载相对湿度数据完成";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       

        /// <summary>
        /// 添加太阳辐射数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddSlr_Click(object sender, System.EventArgs e)
        {
            try
            {
                //添加wndfork文件
                ofd.Filter = "文本文件(*fork.txt)|*fork.txt";
                ofd.Title = "添加太阳辐射";
                ofd.RestoreDirectory = false;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    this.txShowSlr.Text = ofd.FileName;
                    slrfork.setFileDir(ofd.FileName);
                }
                //将相关的slrxxxxx文件复制到Debug/WeatherData/wnd目录下
                copyForkAndStationFile(slrfork.getFileDir());

                //编辑slr.slr文件第一行
                string[] stationArr = editExpressionLine("slr").Split(',');

                //编辑date.txt年份日期文件
                editDate(stationArr[0]);    //因为每一个气象站记录文件的第一行都是开始日期，所以选择第一个气象站，提取其第一行的日期

                //将配置信息导入配置文件ini中
                importToIni(stationArr, "slr");

                //使用批处理文件，调用Fortran程序处理文件
                //runBatFile("slr");
                string str = Application.StartupPath + "\\slrconf.ini";
                int str_length = str.Length;
                slr_(ref str_length, ref str);

                //更改显示状态
                slrStatus.Text = "complete!";
                slrStatus.ForeColor = Color.Green;
                rtbMessage.Text = "加载太阳辐射数据完成";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 添加风速数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btAddWnd_Click(object sender, System.EventArgs e)
        {
            try
            {
                //添加wndfork文件
                ofd.Filter = "文本文件(*fork.txt)|*fork.txt";
                ofd.Title = "添加风速";
                ofd.RestoreDirectory = false;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    this.txShowWnd.Text = ofd.FileName;
                    wndfork.setFileDir(ofd.FileName);
                }
                //将相关的wndxxxxx文件复制到Debug/WeatherData/wnd目录下
                copyForkAndStationFile(wndfork.getFileDir());

                //编辑wnd文件第一行
                string[] stationArr = editExpressionLine("wnd").Split(','); //将返回的气象站字符串用逗号分隔开，并存放到数组中

                //编辑date.txt年份日期文件
                editDate(stationArr[0]);    //因为每一个气象站记录文件的第一行都是开始日期，所以选择第一个气象站，提取其第一行的日期

                //将配置信息导入配置文件ini中
                importToIni(stationArr, "wnd");

                //使用批处理文件，调用Fortran程序处理文件
                //runBatFile("wnd");
                string str = Application.StartupPath + "\\wndconf.ini";
                int str_length = str.Length;
                wnd_(ref str_length, ref str);

                //更改显示状态
                wndStatus.Text = "complete!";
                wndStatus.ForeColor = Color.Green;
                rtbMessage.Text = "加载风速数据完成";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 调用exe程序
        /// </summary>
        /// <param name="type">类型</param>
        void runExeFile(string type)
        {
            try
            {
                string targetDir = string.Format(System.IO.Directory.GetCurrentDirectory().ToString()) + "\\" + type + "_fortranproject\\CheckMate\\Win32";
                Process proc = new Process();
                proc.StartInfo.WorkingDirectory = targetDir;
                proc.StartInfo.FileName = type + "_Fortran.exe";
                proc.StartInfo.Arguments = string.Format("10");
                proc.StartInfo.CreateNoWindow = true;//启动该进程而不创建包含它的新窗口
                proc.StartInfo.UseShellExecute = false;//直接从可执行文件创建进程,不使用 shell
                proc.Start();
                proc.WaitForExit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 使用bat文件
        /// </summary>
        /// <param name="type">指标类型</param>
        void runBatFile(string type)
        {
            createBatFile(type);
            try
            {
                string targetDir = string.Format(System.IO.Directory.GetCurrentDirectory().ToString());
                Process proc = new Process();
                proc.StartInfo.WorkingDirectory = targetDir;
                proc.StartInfo.FileName = "startconverttx_"+type+".bat";
                //proc.StartInfo.FileName = "startconverttx"+type + "_Fortran.bat";
                proc.StartInfo.Arguments = string.Format("10");
                proc.StartInfo.CreateNoWindow = true;//启动该进程而不创建包含它的新窗口
                proc.StartInfo.UseShellExecute = false;//直接从可执行文件创建进程,不使用 shell
                proc.Start();
                proc.WaitForExit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 创建bat文件
        /// </summary>
        /// <param name="type">指标类型</param>
        private void createBatFile(string type)
        {
            fs = new FileStream(System.IO.Directory.GetCurrentDirectory().ToString() + "\\"+"startconverttx_"+type+".bat", FileMode.Create);
            sw = new StreamWriter(fs);
            sw.Write("@echo off\r\n");
            sw.Write("start "+System.IO.Directory.GetCurrentDirectory().ToString()+"\\"+type+"_fortranproject\\CheckMate\\Win32\\"+type+"_Fortran.exe"); 
            sw.Flush();
            sw.Close();
            fs.Close();
        }

        /// <summary>
        /// 将气象站相关数据导入到配置文件ini中
        /// </summary>
        /// <param name="stationArr">气象站数组，存放着有关的气象站</param>
        /// <param name="type">5种指标类型</param>
        void importToIni(string[] stationArr,string type)
        {

            /*
             * 将所需要的数据信息导入到配置文件xxxInputConf.ini中，配置文件格式如下：
             * 
             *  有效气象站数目n
             *  气象站记录条数
             *  输入文件(pcp1.pcp,Tmp1.Tmp,slr.slr,hmd.hmd,wnd.wnd)
             *  date.txt
             *  气象站1
             *  气象站2
             *  ...
             *  气象站n
             *  
             */
            fs = new FileStream(System.IO.Directory.GetCurrentDirectory().ToString() + "\\"+type+"conf.ini", FileMode.Create);     //将气象站信息写入ini配置文件
            sw = new StreamWriter(fs);
            sw.Write((stationArr.Length - 2) + 1 + "\r\n"); //最后一个为空，所以Length-1，需要把date.txt加入，所以length+1
            sw.Write((GetLine(System.IO.Directory.GetCurrentDirectory() + "\\WeatherData\\date.txt") - 1).ToString() + "\r\n");//获取行数
            if (type.Equals("pcp"))
            {
                sw.Write(System.IO.Directory.GetCurrentDirectory() + "\\TxtInOut\\pcp1.pcp\r\n");
            }
            else if (type.Equals("tmp"))
            {
                sw.Write(System.IO.Directory.GetCurrentDirectory() + "\\TxtInOut\\Tmp1.Tmp\r\n");
            }
            else if (type.Equals("hmd"))
            {
                sw.Write(System.IO.Directory.GetCurrentDirectory() + "\\TxtInOut\\hmd.hmd\r\n");
            }
            else if (type.Equals("slr"))
            {
                sw.Write(System.IO.Directory.GetCurrentDirectory() + "\\TxtInOut\\slr.slr\r\n");
            }
            else if (type.Equals("wnd"))
            {
                sw.Write(System.IO.Directory.GetCurrentDirectory() + "\\TxtInOut\\wnd.wnd\r\n");
            }
            else
            {
                return;
            }
            sw.Write(System.IO.Directory.GetCurrentDirectory() + "\\WeatherData\\date.txt\r\n");
            for (int i = 0; i < stationArr.Length-1;i++)   //最后一个为数据为空占位，不计入
            {
                sw.Write(System.IO.Directory.GetCurrentDirectory() + "\\WeatherData\\" + stationArr[i]+ "\r\n");
            }
            sw.Flush();
            sw.Close();
            fs.Close();
        }

        /// <summary>
        /// 编辑气象输入文件的头部
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        string editExpressionLine(string type)
        {
            string station = "Station  ";
            string station_str = "";//存放所有的气象站txt文件
            string LAT = "Lati   ";
            string LONG = "Long   ";
            string ELEVATION = "Elev   ";
            string sql = "";
            double tmp;
            if (type.Equals("pcp"))
            {
               sql = "SELECT DISTINCT Pcp1.OrderID, Pcp1.NAME, Pcp1.LAT, Pcp1.LONG, Pcp1.ELEVATION, Pcp1.LONG FROM (select SubPcp.OrderID, pcpfork.NAME,pcpfork.LAT,pcpfork.LONG,pcpfork.ELEVATION from SubPcp left join pcpfork on SubPcp.Station=pcpfork.NAME order by SubPcp.OrderID asc)  AS Pcp1;";

            }
            else if(type.Equals("tmp"))
            {
               sql = "SELECT DISTINCT Tmp1.OrderID, Tmp1.NAME, Tmp1.LAT, Tmp1.LONG, Tmp1.ELEVATION, Tmp1.LONG FROM (select SubTmp.OrderID, temfork.NAME,temfork.LAT,temfork.LONG,temfork.ELEVATION from SubTmp left join temfork on SubTmp.Station=temfork.NAME order by SubTmp.OrderID asc)  AS Tmp1;";
            }
            else if(type.Equals("hmd"))
            {
               sql = "SELECT DISTINCT hmd.OrderID, hmd.NAME, hmd.LAT, hmd.LONG, hmd.ELEVATION, hmd.LONG FROM (select SubHmd.OrderID, hmdfork.NAME,hmdfork.LAT,hmdfork.LONG,hmdfork.ELEVATION from SubHmd left join hmdfork on SubHmd.Station=hmdfork.NAME order by SubHmd.OrderID asc)  AS hmd;";

            }
            else if (type.Equals("slr"))
            {
                sql = "SELECT DISTINCT sol.OrderID, sol.NAME, sol.LAT, sol.LONG, sol.ELEVATION, sol.LONG FROM (select SubSlr.OrderID, solfork.NAME,solfork.LAT,solfork.LONG,solfork.ELEVATION from SubSlr left join solfork on SubSlr.Station=solfork.NAME order by SubSlr.OrderID asc)  AS sol;";

            }
            else if (type.Equals("wnd"))
            {
                sql = "SELECT DISTINCT win.OrderID, win.NAME, win.LAT, win.LONG, win.ELEVATION, win.LONG FROM (select SubWnd.OrderID, winfork.NAME,winfork.LAT,winfork.LONG,winfork.ELEVATION from SubWnd left join winfork on SubWnd.Station=winfork.NAME order by SubWnd.OrderID asc)  AS win;";

            }
            else
            {
                return null;
            }
            dt = helper.GetDataTableFromDB(sql);    //连接数据库
            if (!Directory.Exists(System.IO.Directory.GetCurrentDirectory().ToString() + "\\TxtInOut"))  //如果不存在文件夹则创建
            {
                Directory.CreateDirectory(System.IO.Directory.GetCurrentDirectory().ToString() + "\\TxtInOut");
            }
            //根据类型创建文件
            if (type.Equals("pcp"))
            {
                fs = new FileStream(System.IO.Directory.GetCurrentDirectory().ToString() + "\\TxtInOut\\pcp1.pcp", FileMode.Create);
                sw = new StreamWriter(fs);
            }
            else if (type.Equals("tmp"))
            {
                fs = new FileStream(System.IO.Directory.GetCurrentDirectory().ToString() + "\\TxtInOut\\Tmp1.Tmp", FileMode.Create);
                sw = new StreamWriter(fs);
            }
            else if (type.Equals("hmd"))
            {
                fs = new FileStream(System.IO.Directory.GetCurrentDirectory().ToString() + "\\TxtInOut\\hmd.hmd", FileMode.Create);
                sw = new StreamWriter(fs);
            }
            else if (type.Equals("slr"))
            {
                fs = new FileStream(System.IO.Directory.GetCurrentDirectory().ToString() + "\\TxtInOut\\slr.slr", FileMode.Create);
                sw = new StreamWriter(fs);
            }
            else if (type.Equals("wnd"))
            {
                fs = new FileStream(System.IO.Directory.GetCurrentDirectory().ToString() + "\\TxtInOut\\wnd.wnd", FileMode.Create);
                sw = new StreamWriter(fs);
            }
            else
            {
                return null;
            }
            if (type.Equals("pcp"))
            {
                foreach (DataRow dr in dt.Rows)
                {
                    station_str += dr[1].ToString() + ".txt"+",";
                    station += dr[1].ToString() + ",";  //将气象站的名称连接成一个字符串，用','分隔
                    tmp = Math.Round(Convert.ToDouble(dr[2].ToString()), 1, MidpointRounding.AwayFromZero);
                    LAT += string.Format("{0,5}", tmp.ToString("F1"));
                    tmp = Math.Round(Convert.ToDouble(dr[3].ToString()), 1, MidpointRounding.AwayFromZero);
                    LONG += string.Format("{0,5}", tmp.ToString("F1"));
                    tmp = Math.Round(Convert.ToDouble(dr[4].ToString()), MidpointRounding.AwayFromZero);
                    ELEVATION += string.Format("{0,5}", tmp.ToString());
                }
                sw.Write(station + "\n" + LAT + "\n" + LONG + "\n" + ELEVATION + "\n");
            }
            else if (type.Equals("tmp"))
            {
                foreach (DataRow dr in dt.Rows)
                {

                    station_str += dr[1].ToString() + ".txt"+",";
                    station += dr[1].ToString() + ",";
                    tmp = Math.Round(Convert.ToDouble(dr[2].ToString()), 1, MidpointRounding.AwayFromZero);
                    LAT += string.Format("{0,10}", tmp.ToString("F1"));
                    tmp = Math.Round(Convert.ToDouble(dr[3].ToString()), 1, MidpointRounding.AwayFromZero);
                    LONG += string.Format("{0,10}", tmp.ToString("F1"));
                    tmp = Math.Round(Convert.ToDouble(dr[4].ToString()), MidpointRounding.AwayFromZero);
                    ELEVATION += string.Format("{0,10}", tmp.ToString());
                }
                sw.Write(station + "\n" + LAT + "\n" + LONG + "\n" + ELEVATION + "\n");
            }
            else if (type.Equals("hmd"))
            {
                foreach (DataRow dr in dt.Rows)
                {
                    station_str += dr[1].ToString() + ".txt" + ",";
                    station += dr[1].ToString() + ",";
                }
                sw.Write(station + "\n");
            }
            else if (type.Equals("slr"))
            {
                foreach (DataRow dr in dt.Rows)
                {
                    station_str += dr[1].ToString() + ".txt" + ",";
                    station += dr[1].ToString() + ",";
                }
                sw.Write(station + "\n");
            }
            else if (type.Equals("wnd"))
            {
                foreach (DataRow dr in dt.Rows)
                {
                    station_str += dr[1].ToString() + ".txt" + ",";
                    station += dr[1].ToString() + ",";
                }
                sw.Write(station + "\n");
            }
            else
            {
                return null;
            }
            sw.Flush();
            sw.Close();
            fs.Close();
            return station_str;
        }

        /// <summary>
        /// 将选择的fork文件和fork包含的每一个气象站记录拷贝到Debug\WeatherData目录下
        /// </summary>
        /// <param name="forkFileDir">fork文件路径</param>
        void copyForkAndStationFile(string forkFileDir)
        {
            StreamReader sr = new StreamReader(forkFileDir);    //读取fork文件
            sr.ReadLine();  //fork文件第一行是列名，不读取直接跳到下一行
            //拷贝fork文件和fork包含的气象站记录文件
            string stationName = "";    //气象站名称
            string sourceFile = ""; //气象站的初始存放路径
            string destinationFile = "";   //气象站的目的拷贝路径
            bool isrewrite = true;  //指定文件存在时的处理方式，true直接覆盖，false不覆盖直接略过
            string[] tmp;
            if (!Directory.Exists(System.IO.Directory.GetCurrentDirectory().ToString() + "\\WeatherData"))    //判断Debug\WeatherData文件夹是否存在，不存在则创建
            {
                Directory.CreateDirectory(System.IO.Directory.GetCurrentDirectory().ToString() + "\\WeatherData");
            }
            //拷贝fork文件
            sourceFile = forkFileDir;
            destinationFile = System.IO.Directory.GetCurrentDirectory().ToString() + "\\WeatherData\\" + Path.GetFileNameWithoutExtension(forkFileDir) + ".txt";
            System.IO.File.Copy(sourceFile, destinationFile, isrewrite);
            //拷贝hmdfork子文件
            for (int i = 1; i <= GetLine(forkFileDir) - 1; i++)  //获取hmdfork文件的行数，进行循环处理
            {
                tmp = sr.ReadLine().Split(',');
                stationName = tmp[1];
                sourceFile = Path.GetDirectoryName(forkFileDir) + "\\" + stationName + ".txt";
                destinationFile = System.IO.Directory.GetCurrentDirectory().ToString() + "\\WeatherData\\" + stationName + ".txt";
                System.IO.File.Copy(sourceFile, destinationFile, isrewrite);    //以若存在则覆盖的方式拷贝
            }
            sr.Close();
        }

        /// <summary>
        /// 获取行数
        /// </summary>
        /// <returns></returns>
        private int GetLine(string dir)   //获取文本文件共有多少行
        {
            string str;
            StreamReader file = new StreamReader(dir);
            int line = 0;
            while (!file.EndOfStream)
            {
                str = file.ReadLine();
                line++;
            }
            file.Close();   //此处要关闭文件流，不然会出现进程正在被调用的错误！
            return line;
        }

        /// <summary>
        /// 生成date.txt的第一列日期
        /// </summary>
        /// <param name="stationName">气象站记录文件</param>
        private void editDate(string stationName)
        {
            string str_date;
            string stationDir = System.IO.Directory.GetCurrentDirectory().ToString() + "\\WeatherData\\" + stationName;
            if (!Directory.Exists(System.IO.Directory.GetCurrentDirectory().ToString() + "\\WeatherData"))
            {
                Directory.CreateDirectory(System.IO.Directory.GetCurrentDirectory().ToString() + "\\WeatherData");
            }
            fs = new FileStream(System.IO.Directory.GetCurrentDirectory().ToString() + "\\WeatherData\\date.txt", FileMode.Create);  //创建date.txt文件
            sw = new StreamWriter(fs);
            StreamReader file = new StreamReader(stationDir);//打开一个气象站记录文件
            sw.Write("[dateList]"+"\r\n");   //向date.txt文件中写入第一行，与其他的气象站记录文件的第一行对应
            int year_int, month_int, day_int, line_int = 1, daycount = 0;
            string date_str, year_str, month_str, day_str;
            str_date = file.ReadLine();//读取pcpxxxx.txt文件的第一行，获取日期字符串
            year_str = str_date.Substring(0, 4);
            month_str = str_date.Substring(4, 2);
            day_str = str_date.Substring(6, 2);
            day_str = str_date.Substring(6, 2);
            year_int = Convert.ToInt32(year_str);
            month_int = Convert.ToInt32(month_str);
            day_int = Convert.ToInt32(day_str);
            if ((year_int % 4 == 0 && year_int % 100 != 0) || year_int % 400 == 0)
            {
                if (month_int == 1)
                    daycount = day_int;
                else if (month_int == 2)
                    daycount = 31 + day_int;
                else if (month_int == 3)
                    daycount = 60 + day_int;
                else if (month_int == 4)
                    daycount = 91 + day_int;
                else if (month_int == 5)
                    daycount = 121 + day_int;
                else if (month_int == 6)
                    daycount = 152 + day_int;
                else if (month_int == 7)
                    daycount = 182 + day_int;
                else if (month_int == 8)
                    daycount = 213 + day_int;
                else if (month_int == 9)
                    daycount = 244 + day_int;
                else if (month_int == 10)
                    daycount = 274 + day_int;
                else if (month_int == 11)
                    daycount = 305 + day_int;
                else if (month_int == 12)
                    daycount = 336 + day_int;
            }
            else
            {
                if (month_int == 1)
                    daycount = day_int;
                else if (month_int == 2)
                    daycount = 31 + day_int;
                else if (month_int == 3)
                    daycount = 59 + day_int;
                else if (month_int == 4)
                    daycount = 90 + day_int;
                else if (month_int == 5)
                    daycount = 120 + day_int;
                else if (month_int == 6)
                    daycount = 151 + day_int;
                else if (month_int == 7)
                    daycount = 181 + day_int;
                else if (month_int == 8)
                    daycount = 212 + day_int;
                else if (month_int == 9)
                    daycount = 243 + day_int;
                else if (month_int == 10)
                    daycount = 273 + day_int;
                else if (month_int == 11)
                    daycount = 304 + day_int;
                else if (month_int == 12)
                    daycount = 335 + day_int;
            }
            while (line_int <= GetLine(stationDir) - 1)
            {
                date_str = year_int.ToString() + daycount.ToString().PadLeft(3, '0');
                sw.Write(date_str);
                sw.Write("\r\n");   //
                if (daycount == 365 || daycount == 366)//判断日期是否已经是365天或者366天
                {
                    if ((year_int % 4 == 0 && year_int % 100 != 0) || year_int % 400 == 0)
                    {
                        if (daycount == 366)
                        {
                            year_int += 1;
                            daycount = 1;
                        }
                        else
                        {
                            daycount += 1;
                        }

                    }
                    else
                    {
                        if (daycount == 365)
                        {
                            year_int += 1;
                            daycount = 1;
                        }
                    }

                }
                else
                {
                    daycount += 1;
                }

                line_int += 1;
            }
            sw.Flush();
            sw.Close();
            fs.Close();
            file.Close();
        }
        /// <summary>
        /// 校验5个气象输入文件是否完整
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFinish_Click(object sender, System.EventArgs e)
        {

            if (System.IO.File.Exists(System.IO.Directory.GetCurrentDirectory().ToString() + "\\TxtInOut\\pcp1.pcp") && System.IO.File.Exists(System.IO.Directory.GetCurrentDirectory().ToString() + "\\TxtInOut\\hmd.hmd") && System.IO.File.Exists(System.IO.Directory.GetCurrentDirectory().ToString() + "\\TxtInOut\\slr.slr") && System.IO.File.Exists(System.IO.Directory.GetCurrentDirectory().ToString() + "\\TxtInOut\\Tmp1.Tmp") && System.IO.File.Exists(System.IO.Directory.GetCurrentDirectory().ToString() + "\\TxtInOut\\wnd.wnd"))
            {
                MessageBox.Show("添加完成！");
                this.Close();
            }
            else 
            {
                /*
                 * 校验确实哪些气象数据？
                 */
                MessageBox.Show("气象输入数据不完整，请添加缺失数据！");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WeatherInputData_Load(object sender, EventArgs e)
        {

        }

        /*
         * 鼠标移动到文本框上时会显示完整的信息 
         */
        private void txShowPcp_MouseEnter(object sender, EventArgs e)
        {
            this.toolTip1.Show(this.txShowPcp.Text, this.txShowPcp);
        }

        private void txShowTmp_MouseEnter(object sender, EventArgs e)
        {
            this.toolTip1.Show(this.txShowTmp.Text, this.txShowTmp);
        }

        private void txShowHmd_MouseEnter(object sender, EventArgs e)
        {
            this.toolTip1.Show(this.txShowHmd.Text, this.txShowHmd);
        }

        private void txShowSlr_MouseEnter(object sender, EventArgs e)
        {
            this.toolTip1.Show(this.txShowSlr.Text, this.txShowSlr);
        }

        private void txShowWnd_MouseEnter(object sender, EventArgs e)
        {
            this.toolTip1.Show(this.txShowWnd.Text, this.txShowWnd);
        }
    }
}
