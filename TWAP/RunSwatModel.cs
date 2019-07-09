using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
namespace TWAP
{
    public partial class RunSwatModel : Form
    {
        public RunSwatModel()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 输入文件路径和关键字，判断关键字在文件中的行数
        /// </summary>
        /// <param name="way">文件路径</param>
        /// <param name="char1">关键字</param>
        /// <returns>关键字所在的行数</returns>
        public int findKeyWord(string way, string char1)
        {
            if (way == null)  //file.cio文件不存在时，返回0
            {
                MessageBox.Show("file.cio文件不存在!");
                return 0;
            }
            string[] lines = System.IO.File.ReadAllLines(way);
            string find = char1;
            int lineNumber = 0;
            for (int i = 0; i < lines.Length; i++)
                if (lines[i].Contains(find))
                {
                    lineNumber = i + 1;
                    break;
                }
            return lineNumber;
        }
        /// <summary>
        /// 输入文件路径和行数，输出指定行
        /// </summary>
        /// <param name="line">行号</param>
        /// <param name="way">文件路径</param>
        /// <returns>返回指定行号的字符串</returns>
        public string outputline(int line, string way)
        {
            if (way == null)  //file.cio文件不存在时，返回0
            {
                MessageBox.Show("file.cio文件不存在!");
                return null;
            }
            StreamReader objReader = new StreamReader(way);
            string sLine = "";
            string result = string.Empty;
            int i = 0;
            while ((sLine = objReader.ReadLine()) != null)
            {
                i++;
                if (i == line)
                {
                    result = sLine;
                    break;
                }
            }
            objReader.Close();
            return result;
        }
        /// <summary>
        /// 计算从指定日期到12月31日的天数
        /// </summary>
        /// <param name="yyyy">年</param>
        /// <param name="mm">月</param>
        /// <param name="dd">日</param>
        /// <returns>天数</returns>
        public int calculate(int yyyy, int mm, int dd)
        {
            //校验年月日！


            //平年365天
            int total = 365;
            //闰年366天
            if (yyyy % 4 == 0 && yyyy % 100 != 0 || yyyy % 400 == 0)
            {
                total = 366;
            }
            switch (mm)
            {
                case 1: total -= 31; goto case 2;
                //闰年二月29天
                case 2: if (yyyy % 4 == 0 && yyyy % 100 == 0 || yyyy % 400 == 0)
                        total -= 29;
                    else
                        total -= 28; goto case 3;
                case 3: total -= 31; goto case 4;
                case 4: total -= 30; goto case 5;
                case 5: total -= 31; goto case 6;
                case 6: total -= 30; goto case 7;
                case 7: total -= 31; goto case 8;
                case 8: total -= 31; goto case 9;
                case 9: total -= 30; goto case 10;
                case 10: total -= 31; goto case 11;
                case 11: total -= 30; goto case 12;
                case 12: total -= 31; goto default;
                default: total += dd; break;
            }
            return total;
        }
        /// <summary>
        /// 更新file.cio文件
        /// 此处存在问题：更新气象站的个数！
        /// </summary>
        private void CioSettings()
        {
            try
            {
                string way = Application.StartupPath + "\\TxtInOut\\file.cio";
                int yyyy = Convert.ToInt32(dtStartTime.Value.ToString("yyyy")); //起始年
                int mm = Convert.ToInt32(dtStartTime.Value.ToString("MM"));//起始月
                int dd = Convert.ToInt32(dtStartTime.Value.ToString("dd"));//起始日

                int yyyy2 = Convert.ToInt32(dtEndTime.Value.ToString("yyyy")); //终止年
                int mm2 = Convert.ToInt32(dtEndTime.Value.ToString("MM"));//终止月
                int dd2 = Convert.ToInt32(dtEndTime.Value.ToString("dd"));//终止日

                //修改NBYR，模拟的日历年数
                string NBYR1 = outputline(findKeyWord(way, "| NBYR :"), way);
                string NBYR2 = NBYR1.Replace(NBYR1.Substring(0, 16), (yyyy2 - yyyy + 1).ToString().PadLeft(16, ' '));
                string strFilePathNBYR = string.Format(System.IO.Directory.GetCurrentDirectory().ToString() + "\\TxtInOut\\file.cio");
                if (File.Exists(strFilePathNBYR))
                {
                    string strContent = File.ReadAllText(strFilePathNBYR);
                    strContent = strContent.Replace(NBYR1, NBYR2);
                    File.WriteAllText(strFilePathNBYR, strContent);
                  
                }
                //修改IYR,模拟的开始年份
                string IYR1 = outputline(findKeyWord(way, "| IYR :"), way);
                string IYR2 = IYR1.Replace(IYR1.Substring(0, 16), yyyy.ToString().PadLeft(16, ' '));
                string strFilePathIYR = string.Format(System.IO.Directory.GetCurrentDirectory().ToString() + "\\TxtInOut\\file.cio");
                if (File.Exists(strFilePathIYR))
                {
                    string strContent = File.ReadAllText(strFilePathIYR);
                    strContent = strContent.Replace(IYR1, IYR2);
                    File.WriteAllText(strFilePathIYR, strContent);

                }
                //IDAF，开始计算的日期
                string IDAF1 = outputline(findKeyWord(way, "| IDAF :"), way);
                string IDAF2 = IDAF1.Replace(IDAF1.Substring(0, 16), calculate(yyyy, mm, dd).ToString().PadLeft(16, ' '));
                string strFilePathIDAF = string.Format(System.IO.Directory.GetCurrentDirectory().ToString() + "\\TxtInOut\\file.cio");
                if (File.Exists(strFilePathIDAF))
                {
                    string strContent = File.ReadAllText(strFilePathIDAF);
                    strContent = strContent.Replace(IDAF1, IDAF2);
                    File.WriteAllText(strFilePathIDAF, strContent);

                }
                //IDAL，结束日期
                string IDAL1 = outputline(findKeyWord(way, "| IDAL :"), way);
                string IDAL2 = IDAL1.Replace(IDAL1.Substring(0, 16), calculate(yyyy2, mm2, dd2).ToString().PadLeft(16, ' '));
                string strFilePathIDAL = string.Format(System.IO.Directory.GetCurrentDirectory().ToString() + "\\TxtInOut\\file.cio");
                if (File.Exists(strFilePathIDAL))
                {
                    string strContent = File.ReadAllText(strFilePathIDAL);
                    strContent = strContent.Replace(IDAL1, IDAL2);
                    File.WriteAllText(strFilePathIDAL, strContent);

                }
                //NYSKIP，预热期
                string NYSKIP1 = outputline(findKeyWord(way, "| NYSKIP:"), way);
                string NYSKIP2 = NYSKIP1.Replace(NYSKIP1.Substring(0, 16), txNYSKIP.Text.PadLeft(16, ' '));
                string strFilePathNYSKIP = string.Format(System.IO.Directory.GetCurrentDirectory().ToString() + "\\TxtInOut\\file.cio");
                if (File.Exists(strFilePathNYSKIP))
                {
                    string strContent = File.ReadAllText(strFilePathNYSKIP);
                    strContent = strContent.Replace(NYSKIP1, NYSKIP2);
                    File.WriteAllText(strFilePathNYSKIP, strContent);

                }
               //筛选输出信息
                if (cbILOG.Checked)
                {
                    string tmp1 = outputline(findKeyWord(way, "| ILOG:"), way);
                    string tmp2 = tmp1.Replace(tmp1.Substring(0, 16), "1".PadLeft(16,' '));
                    string strFilePath = string.Format(System.IO.Directory.GetCurrentDirectory().ToString() + "\\TxtInOut\\file.cio");
                    if (File.Exists(strFilePath))
                    {
                        string strContent = File.ReadAllText(strFilePath);
                        strContent = strContent.Replace(tmp1, tmp2);
                        File.WriteAllText(strFilePath, strContent);
                    }    
                }
                if (cbIPRP.Checked)
                {
                    string tmp1 = outputline(findKeyWord(way, "| IPRP:"), way);
                    string tmp2 = tmp1.Replace(tmp1.Substring(0, 16), "1".PadLeft(16, ' '));
                    string strFilePath = string.Format(System.IO.Directory.GetCurrentDirectory().ToString() + "\\TxtInOut\\file.cio");
                    if (File.Exists(strFilePath))
                    {
                        string strContent = File.ReadAllText(strFilePath);
                        strContent = strContent.Replace(tmp1, tmp2);
                        File.WriteAllText(strFilePath, strContent);
                    }    
                }
                if (cbIPHR.Checked)
                {
                    string tmp1 = outputline(findKeyWord(way, "| IPHR:"), way);
                    string tmp2 = tmp1.Replace(tmp1.Substring(0, 16), "1".PadLeft(16, ' '));
                    string strFilePath = string.Format(System.IO.Directory.GetCurrentDirectory().ToString() + "\\TxtInOut\\file.cio");
                    if (File.Exists(strFilePath))
                    {
                        string strContent = File.ReadAllText(strFilePath);
                        strContent = strContent.Replace(tmp1, tmp2);
                        File.WriteAllText(strFilePath, strContent);
                    }    
                }
                if (cbISTO.Checked)
                {
                    string tmp1 = outputline(findKeyWord(way, "| ISTO:"), way);
                    string tmp2 = tmp1.Replace(tmp1.Substring(0, 16), "1".PadLeft(16, ' '));
                    string strFilePath = string.Format(System.IO.Directory.GetCurrentDirectory().ToString() + "\\TxtInOut\\file.cio");
                    if (File.Exists(strFilePath))
                    {
                        string strContent = File.ReadAllText(strFilePath);
                        strContent = strContent.Replace(tmp1, tmp2);
                        File.WriteAllText(strFilePath, strContent);
                    }    
                }
                if (cbISOL.Checked)
                {
                    string tmp1 = outputline(findKeyWord(way, "| ISOL:"), way);
                    string tmp2 = tmp1.Replace(tmp1.Substring(0, 16), "1".PadLeft(16, ' '));
                    string strFilePath = string.Format(System.IO.Directory.GetCurrentDirectory().ToString() + "\\TxtInOut\\file.cio");
                    if (File.Exists(strFilePath))
                    {
                        string strContent = File.ReadAllText(strFilePath);
                        strContent = strContent.Replace(tmp1, tmp2);
                        File.WriteAllText(strFilePath, strContent);
                    }    
                }
                if (cbI_SUBW.Checked)
                {
                    string tmp1 = outputline(findKeyWord(way, "| I_SUBW:"), way);
                    string tmp2 = tmp1.Replace(tmp1.Substring(0, 16), "1".PadLeft(16, ' '));
                    string strFilePath = string.Format(System.IO.Directory.GetCurrentDirectory().ToString() + "\\TxtInOut\\file.cio");
                    if (File.Exists(strFilePath))
                    {
                        string strContent = File.ReadAllText(strFilePath);
                        strContent = strContent.Replace(tmp1, tmp2);
                        File.WriteAllText(strFilePath, strContent);
                    }    
                }
                if (cbIA_B.Checked)
                {
                    string tmp1 = outputline(findKeyWord(way, "| IA_B:"), way);
                    string tmp2 = tmp1.Replace(tmp1.Substring(0, 16), "1".PadLeft(16, ' '));
                    string strFilePath = string.Format(System.IO.Directory.GetCurrentDirectory().ToString() + "\\TxtInOut\\file.cio");
                    if (File.Exists(strFilePath))
                    {
                        string strContent = File.ReadAllText(strFilePath);
                        strContent = strContent.Replace(tmp1, tmp2);
                        File.WriteAllText(strFilePath, strContent);
                    }    
                }
                if (cbIHUMUS.Checked)
                {
                    string tmp1 = outputline(findKeyWord(way, "| IHUMUS:"), way);
                    string tmp2 = tmp1.Replace(tmp1.Substring(0, 16), "1".PadLeft(16, ' '));
                    string strFilePath = string.Format(System.IO.Directory.GetCurrentDirectory().ToString() + "\\TxtInOut\\file.cio");
                    if (File.Exists(strFilePath))
                    {
                        string strContent = File.ReadAllText(strFilePath);
                        strContent = strContent.Replace(tmp1, tmp2);
                        File.WriteAllText(strFilePath, strContent);
                    }    
                }
                if (cbITEMP.Checked)
                {
                    string tmp1 = outputline(findKeyWord(way, "| ITEMP:"), way);
                    string tmp2 = tmp1.Replace(tmp1.Substring(0, 16), "1".PadLeft(16, ' '));
                    string strFilePath = string.Format(System.IO.Directory.GetCurrentDirectory().ToString() + "\\TxtInOut\\file.cio");
                    if (File.Exists(strFilePath))
                    {
                        string strContent = File.ReadAllText(strFilePath);
                        strContent = strContent.Replace(tmp1, tmp2);
                        File.WriteAllText(strFilePath, strContent);
                    }    
                }
                if (cbISNOW.Checked)
                {
                    string tmp1 = outputline(findKeyWord(way, "| ISNOW:"), way);
                    string tmp2 = tmp1.Replace(tmp1.Substring(0, 16), "1".PadLeft(16, ' '));
                    string strFilePath = string.Format(System.IO.Directory.GetCurrentDirectory().ToString() + "\\TxtInOut\\file.cio");
                    if (File.Exists(strFilePath))
                    {
                        string strContent = File.ReadAllText(strFilePath);
                        strContent = strContent.Replace(tmp1, tmp2);
                        File.WriteAllText(strFilePath, strContent);
                    }    
                }
                if (cbIMGT.Checked)
                {
                    string tmp1 = outputline(findKeyWord(way, "| IMGT:"), way);
                    string tmp2 = tmp1.Replace(tmp1.Substring(0, 16), "1".PadLeft(16, ' '));
                    string strFilePath = string.Format(System.IO.Directory.GetCurrentDirectory().ToString() + "\\TxtInOut\\file.cio");
                    if (File.Exists(strFilePath))
                    {
                        string strContent = File.ReadAllText(strFilePath);
                        strContent = strContent.Replace(tmp1, tmp2);
                        File.WriteAllText(strFilePath, strContent);
                    }    
                }
                if (cbIWTR.Checked)
                {
                    string tmp1 = outputline(findKeyWord(way, "| IWTR:"), way);
                    string tmp2 = tmp1.Replace(tmp1.Substring(0, 16), "1".PadLeft(16, ' '));
                    string strFilePath = string.Format(System.IO.Directory.GetCurrentDirectory().ToString() + "\\TxtInOut\\file.cio");
                    if (File.Exists(strFilePath))
                    {
                        string strContent = File.ReadAllText(strFilePath);
                        strContent = strContent.Replace(tmp1, tmp2);
                        File.WriteAllText(strFilePath, strContent);
                    }    
                }
                //ICALEN暂时没有处理

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 设置swat模型参数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSetSWATModel_Click(object sender, EventArgs e)
        {
            if (dtEndTime.Value < dtStartTime.Value)
            {
                MessageBox.Show("模拟时间设置错误，请重新设置！");
            }
            else if (Convert.ToInt32(txNYSKIP.Text) < 0)
            {
                MessageBox.Show("预热期设置错误，请重新设置！");
            }
            else
            {
                DialogResult dr = MessageBox.Show("确认更改？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dr == DialogResult.OK)
                {
                    CioSettings();
                    toolStripStatusLabelRunMessage.Text = "更改成功";
                }
            }
        }

        /// <summary>
        /// 运行swat模型
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRunSWATModel_Click(object sender, EventArgs e)
        {
            try
            {
                String targetDir = string.Format(System.IO.Directory.GetCurrentDirectory().ToString() + "\\TxtInOut");
                Process proc = new Process();
                proc.StartInfo.WorkingDirectory = targetDir;
                proc.StartInfo.FileName = "startswat.bat";
                proc.StartInfo.Arguments = string.Format("10");
                proc.Start();
                proc.WaitForExit();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Occurred :{0},{1}", ex.Message, ex.StackTrace.ToString());
            }
        }
        /// <summary>
        /// 关闭窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 加载窗体时设置初始信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RunSwatModel_Load(object sender, EventArgs e)
        {
            toolStripStatusLabelRunMessage.Text = "";
            cbOutputFileVariables.SelectedIndex = 0;
            InitMin_MaxDate();
        }
        /// <summary>
        /// 初始化时间控件和时间提示
        /// </summary>
        private void InitMin_MaxDate()
        {
            dtStartTime.Value = Convert.ToDateTime(GetMinDate());
            dtStartTime.MinDate = Convert.ToDateTime(GetMinDate());
            dtStartTime.MaxDate = Convert.ToDateTime(GetMaxDate());
            dtEndTime.Value = Convert.ToDateTime(GetMaxDate());
            dtEndTime.MinDate = Convert.ToDateTime(GetMinDate());
            dtEndTime.MaxDate = Convert.ToDateTime(GetMaxDate());
            lbMinDate.Text ="最早开始时间："+ GetMinDate();
            lbMaxDate.Text ="最晚结束时间："+ GetMaxDate();
        }
        /// <summary>
        /// 获取最早开始时间
        /// </summary>
        /// <returns></returns>
        private string GetMinDate()
        {
            /*
             * 从气象文件中读取开始年份和结束年份：
             * 设置开始年份的的1月1日为最小开始时间
             * 设置结束年份的12月31日为最大结束时间
             */
            string filePath = "";
            if (System.IO.File.Exists(Application.StartupPath + @"\WeatherData\date.txt"))
            {
                filePath = Application.StartupPath + @"\WeatherData\date.txt";
            }
            StreamReader sr = new StreamReader(filePath);
            sr.ReadLine();  //读取第一行（描述行）

            string MinDate = sr.ReadLine(); //读取开始日期
            MinDate = MinDate.Substring(0, 4);  //截取年份
            MinDate = MinDate + "-01-01";
            return MinDate;
        }
        /// <summary>
        /// 获取最晚结束时间
        /// </summary>
        /// <returns></returns>
        private string GetMaxDate()
        {
            /*
             * 从气象文件中读取开始年份和结束年份：
             * 设置开始年份的的1月1日为最小开始时间
             * 设置结束年份的12月31日为最大结束时间
             */
            string filePath = "";
            if (System.IO.File.Exists(Application.StartupPath + @"\WeatherData\date.txt"))
            {
                filePath = Application.StartupPath + @"\WeatherData\date.txt";
            }
            StreamReader sr = new StreamReader(filePath);
            string MaxDate = "", tmp = "";
            do
            {
                tmp = sr.ReadLine();
                MaxDate = tmp != null ? tmp : MaxDate; //截取最后一行
            } while (tmp != null);
            MaxDate = MaxDate.Substring(0, 4);
            MaxDate = MaxDate + "-12-31";
            return MaxDate;
        }
        /// <summary>
        /// 设置复选框的选择状态
        /// </summary>
        /// <param name="type"></param>
        private void SwitchPrintOut(string type)
        {
            if (type.Equals("全选"))
            {
                cbILOG.Checked = true;
                cbIPRP.Checked = true;
                cbIPHR.Checked = true;
                cbISTO.Checked = true;
                cbISOL.Checked = true;
                cbI_SUBW.Checked = true;
                cbIA_B.Checked = true;
                cbIHUMUS.Checked = true;
                cbISNOW.Checked = true;
                cbITEMP.Checked = true;
                cbIMGT.Checked = true;
                cbIWTR.Checked = true;
            }
            if (type.Equals("取消全选"))
            {
                cbILOG.Checked = false;
                cbIPRP.Checked = false;
                cbIPHR.Checked = false;
                cbISTO.Checked = false;
                cbISOL.Checked = false;
                cbI_SUBW.Checked = false;
                cbIA_B.Checked = false;
                cbIHUMUS.Checked = false;
                cbISNOW.Checked = false;
                cbITEMP.Checked = false;
                cbIMGT.Checked = false;
                cbIWTR.Checked = false;
            }
        }
        /// <summary>
        /// 全选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            SwitchPrintOut("全选");
        }
        /// <summary>
        /// 取消全选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNotSelectAll_Click(object sender, EventArgs e)
        {
            SwitchPrintOut("取消全选");
        }
        /// <summary>
        /// 恢复默认设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDefaultSettings_Click(object sender, EventArgs e)
        {
            InitMin_MaxDate();
            rbMonth.Checked = true;
            SwitchPrintOut("取消全选");
            txNYSKIP.Text ="0";
        }



    }
}
