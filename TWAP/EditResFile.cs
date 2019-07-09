using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace TWAP
{
    /// <summary>
    /// 编辑res水库文件的操作类
    /// </summary>
    class EditResFile
    {
        /// <summary>
        /// 输入文件路径和字符串，输出字符串所在文件的第几行
        /// </summary>
        /// <param name="way"></param>
        /// <param name="char1"></param>
        /// <returns></returns>
        public int find(string way, string char1)
        {
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
        /// <param name="line"></param>
        /// <param name="way"></param>
        /// <returns></returns>
        public string outputline(int line, string way)
        {
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

        public void EditRes(string str, TextBox txtIYRES, TextBox txtRES_ESA, TextBox txtRES_EVOL, TextBox txtRES_PSA, TextBox txtRES_PVOL, TextBox txtRES_VOL, TextBox txtRES_SED, TextBox txtRES_NSED, TextBox txtRES_D50, TextBox txtRES_K, TextBox txtRES_RR, TextBox txtNDTARGR, TextBox txtWURTNF, TextBox txtOFLOWMN_FPS, TextBox txtSTARG_FPS, ComboBox cmbIRESCO, ComboBox cmbIFLOD1R, ComboBox cmbIFLOD2R)
        {
            string way = "";
            try
            {
                if (Convert.ToInt32(str) < 10)//判断水库编号的大小，进行文件名的字符串拼接
                    way = Application.StartupPath + "\\TxtInOut\\0000" + str.ToString() + "0000.res";
                else if (Convert.ToInt32(str) > 9 && Convert.ToInt32(str) < 100)
                    way = Application.StartupPath + "\\TxtInOut\\000" + str.ToString() + "0000.res";
                else if (Convert.ToInt32(str) >= 100 && Convert.ToInt32(str) <= 999)
                    way = Application.StartupPath + "\\TxtInOut\\00" + str.ToString() + "0000.res";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            string IYRES1 = outputline(find(way, "| IYRES :"), way);//修改TYRES水库开始运行的年份
            string IYRES2 = IYRES1.Replace(IYRES1.Substring(0, 16), txtIYRES.Text.PadLeft(16, ' '));
            string strFilePathIYRES = string.Format(way);
            if (File.Exists(strFilePathIYRES))
            {
                string strContent = File.ReadAllText(strFilePathIYRES);
                strContent = strContent.Replace(IYRES1, IYRES2);
                File.WriteAllText(strFilePathIYRES, strContent);
            }

            string RES_ESA1 = outputline(find(way, "| RES_ESA :"), way);//修改RES_ESA非常溢洪道水位时的水库面积
            string RES_ESA2 = RES_ESA1.Replace(RES_ESA1.Substring(0, 16), txtRES_ESA.Text.PadLeft(16, ' '));
            string strFilePathRES_ESA = string.Format(way);
            if (File.Exists(strFilePathRES_ESA))
            {
                string strContent = File.ReadAllText(strFilePathRES_ESA);
                strContent = strContent.Replace(RES_ESA1, RES_ESA2);
                File.WriteAllText(strFilePathRES_ESA, strContent);
            }

            string RES_EVOL1 = outputline(find(way, "| RES_EVOL :"), way);//修改RES_EVOL非常溢洪水位时的水库蓄水量
            string RES_EVOL2 = RES_EVOL1.Replace(RES_EVOL1.Substring(0, 16), txtRES_EVOL.Text.PadLeft(16, ' '));
            string strFilePathRES_EVOL = string.Format(way);
            if (File.Exists(strFilePathRES_EVOL))
            {
                string strContent = File.ReadAllText(strFilePathRES_EVOL);
                strContent = strContent.Replace(RES_EVOL1, RES_EVOL2);
                File.WriteAllText(strFilePathRES_EVOL, strContent);
            }

            string RES_PSA1 = outputline(find(way, "| RES_PSA :"), way);//修改RES_PSA正常溢洪道水位时的水库面积
            string RES_PSA2 = RES_PSA1.Replace(RES_PSA1.Substring(0, 16), txtRES_PSA.Text.PadLeft(16, ' '));
            string strFilePathRES_PSA = string.Format(way);
            if (File.Exists(strFilePathRES_PSA))
            {
                string strContent = File.ReadAllText(strFilePathRES_PSA);
                strContent = strContent.Replace(RES_PSA1, RES_PSA2);
                File.WriteAllText(strFilePathRES_PSA, strContent);
            }

            string RES_PVOL1 = outputline(find(way, "| RES_PVOL :"), way);//修改RES_PVOL正常溢洪水位时的水库蓄水量
            string RES_PVOL2 = RES_PVOL1.Replace(RES_PVOL1.Substring(0, 16), txtRES_PVOL.Text.PadLeft(16, ' '));
            string strFilePathRES_PVOL = string.Format(way);
            if (File.Exists(strFilePathRES_PVOL))
            {
                string strContent = File.ReadAllText(strFilePathRES_PVOL);
                strContent = strContent.Replace(RES_PVOL1, RES_PVOL2);
                File.WriteAllText(strFilePathRES_PVOL, strContent);
            }

            string RES_VOL1 = outputline(find(way, "| RES_VOL :"), way);//修改RES_VOl水库的初始蓄水量
            string RES_VOL2 = RES_VOL1.Replace(RES_VOL1.Substring(0, 16), txtRES_VOL.Text.PadLeft(16, ' '));
            string strFilePathRES_VOL = string.Format(way);
            if (File.Exists(strFilePathRES_VOL))
            {
                string strContent = File.ReadAllText(strFilePathRES_VOL);
                strContent = strContent.Replace(RES_VOL1, RES_VOL2);
                File.WriteAllText(strFilePathRES_VOL, strContent);
            }

            string RES_SED1 = outputline(find(way, "| RES_SED :"), way);//修改RES_SED水库的初始含沙量
            string RES_SED2 = RES_SED1.Replace(RES_SED1.Substring(0, 16), txtRES_SED.Text.PadLeft(16, ' '));
            string strFilePathRES_SED = string.Format(way);
            if (File.Exists(strFilePathRES_SED))
            {
                string strContent = File.ReadAllText(strFilePathRES_SED);
                strContent = strContent.Replace(RES_SED1, RES_SED2);
                File.WriteAllText(strFilePathRES_SED, strContent);
            }

            string RES_NSED1 = outputline(find(way, "| RES_NSED :"), way);//修改RES_NSED水库的平衡含沙量
            string RES_NSED2 = RES_NSED1.Replace(RES_NSED1.Substring(0, 16), txtRES_NSED.Text.PadLeft(16, ' '));
            string strFilePathRES_NSED = string.Format(way);
            if (File.Exists(strFilePathRES_NSED))
            {
                string strContent = File.ReadAllText(strFilePathRES_NSED);
                strContent = strContent.Replace(RES_NSED1, RES_NSED2);
                File.WriteAllText(strFilePathRES_NSED, strContent);
            }

            string RES_D501 = outputline(find(way, "| RES_D50 :"), way);//修改RES_D50泥沙的中值粒径
            string RES_D502 = RES_D501.Replace(RES_D501.Substring(0, 16), txtRES_D50.Text.PadLeft(16, ' '));
            string strFilePathRES_D50 = string.Format(way);
            if (File.Exists(strFilePathRES_D50))
            {
                string strContent = File.ReadAllText(strFilePathRES_D50);
                strContent = strContent.Replace(RES_D501, RES_D502);
                File.WriteAllText(strFilePathRES_D50, strContent);
            }

            string RES_K1 = outputline(find(way, "| RES_K :"), way);//修改RES_K水库底部的渗透系数
            string RES_K2 = RES_K1.Replace(RES_K1.Substring(0, 16), txtRES_K.Text.PadLeft(16, ' '));
            string strFilePathRES_K = string.Format(way);
            if (File.Exists(strFilePathRES_K))
            {
                string strContent = File.ReadAllText(strFilePathRES_K);
                strContent = strContent.Replace(RES_K1, RES_K2);
                File.WriteAllText(strFilePathRES_K, strContent);
            }


            string str_iresco = ""; //判断模拟代码
            if (cmbIRESCO.Text == "Average Annual Release")
                str_iresco = "0";
            else if (cmbIRESCO.Text == "Meaured Monthly Outflow")
                str_iresco = "1";
            else if (cmbIRESCO.Text == "Simulated Target Release")
                str_iresco = "2";
            else if (cmbIRESCO.Text == "Measured Daily Outflow")
                str_iresco = "3";
            string IRESCO1 = outputline(find(way, "| IRESCO :"), way);//修改IRESCO出流量的模拟代码
            string IRESCO2 = IRESCO1.Replace(IRESCO1.Substring(0, 16), str_iresco.ToString().PadLeft(16, ' '));
            string strFilePathIRESCO = string.Format(way);
            if (File.Exists(strFilePathIRESCO))
            {
                string strContent = File.ReadAllText(strFilePathIRESCO);
                strContent = strContent.Replace(IRESCO1, IRESCO2);
                File.WriteAllText(strFilePathIRESCO, strContent);
            }


            string RES_RR1 = outputline(find(way, "| RES_RR :"), way);//修改RES_RR正常溢洪道的日均泄流量
            string RES_RR2 = RES_RR1.Replace(RES_RR1.Substring(0, 16), txtRES_RR.Text.PadLeft(16, ' '));
            string strFilePathRES_RR = string.Format(way);
            if (File.Exists(strFilePathRES_RR))
            {
                string strContent = File.ReadAllText(strFilePathRES_RR);
                strContent = strContent.Replace(RES_RR1, RES_RR2);
                File.WriteAllText(strFilePathRES_RR, strContent);
            }

            string mono = "";
            if (Convert.ToInt32(str) < 10)//判断水库编号的大小，进行文件名的字符串拼接
                mono = "0000" + str.ToString() + "0000.mon";
            else if (Convert.ToInt32(str) > 9 && Convert.ToInt32(str) < 100)
                mono = "000" + str.ToString() + "0000.mon";
            else if (Convert.ToInt32(str) >= 100 && Convert.ToInt32(str) <= 999)
                mono = "00" + str.ToString() + "0000.mon";
            string RES_MONO1 = outputline(find(way, "| RESMONO :"), way);//修改RES_RR正常溢洪道的日均泄流量
            string RES_MONO2 = RES_MONO1.Replace(RES_MONO1.Substring(0, 16), mono.PadRight(16, ' '));
            string strFilePathRES_MONO = string.Format(way);
            if (File.Exists(strFilePathRES_MONO))
            {
                string strContent = File.ReadAllText(strFilePathRES_MONO);
                strContent = strContent.Replace(RES_MONO1, RES_MONO2);
                File.WriteAllText(strFilePathRES_MONO, strContent);
            }


            string str_IFLOD1R = "";
            if (cmbIFLOD1R.Text == "Jan")
                str_IFLOD1R = "1";
            else if (cmbIFLOD1R.Text == "Feb")
                str_IFLOD1R = "2";
            else if (cmbIFLOD1R.Text == "Mar")
                str_IFLOD1R = "3";
            else if (cmbIFLOD1R.Text == "Apr")
                str_IFLOD1R = "4";
            else if (cmbIFLOD1R.Text == "May")
                str_IFLOD1R = "5";
            else if (cmbIFLOD1R.Text == "Jun")
                str_IFLOD1R = "6";
            else if (cmbIFLOD1R.Text == "Jul")
                str_IFLOD1R = "7";
            else if (cmbIFLOD1R.Text == "Aug")
                str_IFLOD1R = "8";
            else if (cmbIFLOD1R.Text == "Sep")
                str_IFLOD1R = "9";
            else if (cmbIFLOD1R.Text == "Oct")
                str_IFLOD1R = "10";
            else if (cmbIFLOD1R.Text == "Nov")
                str_IFLOD1R = "11";
            else if (cmbIFLOD1R.Text == "Dec")
                str_IFLOD1R = "12";
            string RES_IFLOD1R1 = outputline(find(way, "| IFLOD1R :"), way);//修改RES_IFLOD1R非汛期的起始月份
            string RES_IFLOD1R2 = RES_IFLOD1R1.Replace(RES_IFLOD1R1.Substring(0, 16), str_IFLOD1R.PadLeft(16, ' '));
            string strFilePathRES_IFLOD1R = string.Format(way);
            if (File.Exists(strFilePathRES_IFLOD1R))
            {
                string strContent = File.ReadAllText(strFilePathRES_IFLOD1R);
                strContent = strContent.Replace(RES_IFLOD1R1, RES_IFLOD1R2);
                File.WriteAllText(strFilePathRES_IFLOD1R, strContent);
            }

            string str_IFLOD2R = "";
            if (cmbIFLOD2R.Text == "Jan")
                str_IFLOD2R = "1";
            else if (cmbIFLOD2R.Text == "Feb")
                str_IFLOD2R = "2";
            else if (cmbIFLOD2R.Text == "Mar")
                str_IFLOD2R = "3";
            else if (cmbIFLOD2R.Text == "Apr")
                str_IFLOD2R = "4";
            else if (cmbIFLOD2R.Text == "May")
                str_IFLOD2R = "5";
            else if (cmbIFLOD2R.Text == "Jun")
                str_IFLOD2R = "6";
            else if (cmbIFLOD2R.Text == "Jul")
                str_IFLOD2R = "7";
            else if (cmbIFLOD2R.Text == "Aug")
                str_IFLOD2R = "8";
            else if (cmbIFLOD2R.Text == "Sep")
                str_IFLOD2R = "9";
            else if (cmbIFLOD2R.Text == "Oct")
                str_IFLOD2R = "10";
            else if (cmbIFLOD2R.Text == "Nov")
                str_IFLOD2R = "11";
            else if (cmbIFLOD2R.Text == "Dec")
                str_IFLOD2R = "12";
            string RES_IFLOD2R1 = outputline(find(way, "| IFLOD2R :"), way);//修改RES_IFLOD2R非汛期的终止月份
            string RES_IFLOD2R2 = RES_IFLOD2R1.Replace(RES_IFLOD2R1.Substring(0, 16), str_IFLOD2R.PadLeft(16, ' '));
            string strFilePathRES_IFLOD2R = string.Format(way);
            if (File.Exists(strFilePathRES_IFLOD2R))
            {
                string strContent = File.ReadAllText(strFilePathRES_IFLOD2R);
                strContent = strContent.Replace(RES_IFLOD2R1, RES_IFLOD2R2);
                File.WriteAllText(strFilePathRES_IFLOD2R, strContent);
            }


            string RES_NDTARGR1 = outputline(find(way, "| NDTARGR :"), way);//修改NDTARGR达到水库目标蓄水量所需的天数
            string RES_NDTARGR2 = RES_NDTARGR1.Replace(RES_NDTARGR1.Substring(0, 16), txtNDTARGR.Text.PadLeft(16, ' '));
            string strFilePathRES_NDTARGR = string.Format(way);
            if (File.Exists(strFilePathRES_NDTARGR))
            {
                string strContent = File.ReadAllText(strFilePathRES_NDTARGR);
                strContent = strContent.Replace(RES_NDTARGR1, RES_NDTARGR2);
                File.WriteAllText(strFilePathRES_NDTARGR, strContent);
            }

            string WURTNF1 = outputline(find(way, "| WURTNF :"), way);//修改WURTNF回归到水库并成为水库出流量的水量站调水量的分数
            string WURTNF2 = WURTNF1.Replace(WURTNF1.Substring(0, 16), txtWURTNF.Text.PadLeft(16, ' '));
            string strFilePathWURTNF = string.Format(way);
            if (File.Exists(strFilePathWURTNF))
            {
                string strContent = File.ReadAllText(strFilePathWURTNF);
                strContent = strContent.Replace(WURTNF1, WURTNF2);
                File.WriteAllText(strFilePathWURTNF, strContent);
            }

            string OFLOWMN_FPS1 = outputline(find(way, "| OFLOWMN_FPS :"), way);//修改以正常溢洪道水量分数表示水库最小出流量
            string OFLOWMN_FPS2 = OFLOWMN_FPS1.Replace(OFLOWMN_FPS1.Substring(0, 16), txtOFLOWMN_FPS.Text.PadLeft(16, ' '));
            string strFilePathOFLOWMN_FPS = string.Format(way);
            if (File.Exists(strFilePathOFLOWMN_FPS))
            {
                string strContent = File.ReadAllText(strFilePathOFLOWMN_FPS);
                strContent = strContent.Replace(OFLOWMN_FPS1, OFLOWMN_FPS2);
                File.WriteAllText(strFilePathOFLOWMN_FPS, strContent);
            }

            string STARG_FPS1 = outputline(find(way, "| STARG_FPS :"), way);//修改以正常溢洪道水量分数表示的目标蓄水量
            string STARG_FPS2 = STARG_FPS1.Replace(STARG_FPS1.Substring(0, 16), txtSTARG_FPS.Text.PadLeft(16, ' '));
            string strFilePathSTARG_FPS = string.Format(way);
            if (File.Exists(strFilePathSTARG_FPS))
            {
                string strContent = File.ReadAllText(strFilePathSTARG_FPS);
                strContent = strContent.Replace(STARG_FPS1, STARG_FPS2);
                File.WriteAllText(strFilePathSTARG_FPS, strContent);
            }
        }

    }
}
