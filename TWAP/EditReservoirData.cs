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
namespace TWAP
{
    public partial class EditReservoirData : Form
    {
        public string str;  //接收水库的编号
        
        public EditReservoirData()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 设置加载页面时执行的操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditReservoirData_Load(object sender, EventArgs e)
        {
            //combox为不可编辑状态
            this.cmbMORES.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbIRESCO.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbIFLOD1R.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbIFLOD2R.DropDownStyle = ComboBoxStyle.DropDownList;
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            btnEditCancel.Enabled = false;
            btnSave.Enabled = false;
            cmbIRESCO.SelectedIndex = 1;
            if (this.cmbIRESCO.Text == "Average Annual Release" || this.cmbIRESCO.Text == "Simulated Target Release")//设置浏览按钮的可用性
            {
                this.btnadd.Enabled = false;
                this.txtRESDAYO.Enabled = false;
            }
            else
            {
                this.btnadd.Enabled = true;
                this.txtRESDAYO.Enabled = true;
            }
            reset();
        }
        /// <summary>
        /// 进入编辑操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            btnEditCancel.Enabled = true;
            btnSave.Enabled = true;
        }
        /// <summary>
        /// 保存编辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            EditResFile res = new EditResFile();
            if (this.txtRESDAYO.Text == "")
            {
                MessageBox.Show("请选择相应的文件！");
            }
            else
            {
                res.EditRes(str, txtIYRES, txtRES_ESA, txtRES_EVOL, txtRES_PSA, txtRES_PVOL, txtRES_VOL, txtRES_SED, txtRES_NSED, txtRES_D50, txtRES_K, txtRES_RR, txtNDTARGR, txtWURTNF, txtOFLOWMN_FPS, txtSTARG_FPS, cmbIRESCO, cmbIFLOD1R, cmbIFLOD2R);
                EditResMonFile mon = new EditResMonFile();
                mon.creatMonFile(str, this.txtRESDAYO.Text);
                MessageBox.Show("保存编辑完成！");
                WaterYield wy = new WaterYield();
                wy.InitTreeViewInput();
                wy.InitTreeViewOutput();
            }
        }

        /// <summary>
        /// 撤销编辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditCancel_Click(object sender, EventArgs e)
        {
            reset();
        }
        /// <summary>
        /// 退出水库编辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 添加数据文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnadd_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "打开文件...";
            openFileDialog1.Filter = "数据库文件(*.dbf)|*.dbf";//打开文件类型
            openFileDialog1.InitialDirectory = "桌面";//打开文件起始位置
            openFileDialog1.FileName = "";
            openFileDialog1.RestoreDirectory = false;//在关闭前不还原当前目录
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtRESDAYO.Text = openFileDialog1.FileName;
            }
        }
        /// <summary>
        /// 设置控件的状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbIRESCO_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbIRESCO.Text == "Average Annual Release" || this.cmbIRESCO.Text == "Simulated Target Release")//设置浏览按钮的可用性
            {
                this.btnadd.Enabled = false;
                this.txtRESDAYO.Enabled = false;
            }
            else
            {
                this.btnadd.Enabled = true;
                this.txtRESDAYO.Enabled = true;
            }
        }

        public int find(string way, string char1)      //输入文件路径和字符串，输出字符串所在文件的第几行
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
        public string outputline(int line, string way)   //输入文件路径和行数，输出指定行
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

        /// <summary>
        /// 
        /// </summary>
        public void reset()
        {
            string way = "";
            if (Convert.ToInt32(str) < 10)//判断水库编号的大小，进行文件名的字符串拼接
                way = Application.StartupPath + "\\TxtInOut\\0000" + str.ToString() + "0000.res";
            else if (Convert.ToInt32(str) > 9 && Convert.ToInt32(str) < 100)
                way = Application.StartupPath + "\\TxtInOut\\000" + str.ToString() + "0000.res";
            else if (Convert.ToInt32(str) >= 100 && Convert.ToInt32(str) <= 999)
                way = Application.StartupPath + "\\TxtInOut\\00" + str.ToString() + "0000.res";
            string IYRES1 = outputline(find(way, "| IYRES :"), way);//TYRES水库开始运行的年份
            string RES_ESA1 = outputline(find(way, "| RES_ESA :"), way);//RES_ESA非常溢洪道水位时的水库面积
            string RES_EVOL1 = outputline(find(way, "| RES_EVOL :"), way);//RES_EVOL非常溢洪水位时的水库蓄水量
            string RES_PSA1 = outputline(find(way, "| RES_PSA :"), way);//RES_PSA正常溢洪道水位时的水库面积
            string RES_PVOL1 = outputline(find(way, "| RES_PVOL :"), way);//RES_PVOL正常溢洪水位时的水库蓄水量
            string RES_VOL1 = outputline(find(way, "| RES_VOL :"), way);//RES_VOl水库的初始蓄水量
            string RES_SED1 = outputline(find(way, "| RES_SED :"), way);//RES_SED水库的初始含沙量
            string RES_NSED1 = outputline(find(way, "| RES_NSED :"), way);//RES_NSED水库的平衡含沙量
            string RES_D501 = outputline(find(way, "| RES_D50 :"), way);//RES_D50泥沙的中值粒径
            string RES_K1 = outputline(find(way, "| RES_K :"), way);//RES_K水库底部的渗透系数
            string IRESCO1 = outputline(find(way, "| IRESCO :"), way);//IRESCO出流量的模拟代码
            string RES_RR1 = outputline(find(way, "| RES_RR :"), way);//RES_RR正常溢洪道的日均泄流量
            string RES_IFLOD1R1 = outputline(find(way, "| IFLOD1R :"), way);//RES_IFLOD1R非汛期的起始月份
            string RES_IFLOD2R1 = outputline(find(way, "| IFLOD2R :"), way);//RES_IFLOD2R非汛期的终止月份
            string RES_NDTARGR1 = outputline(find(way, "| NDTARGR :"), way);//NDTARGR达到水库目标蓄水量所需的天数
            string WURTNF1 = outputline(find(way, "| WURTNF :"), way);//WURTNF回归到水库并成为水库出流量的水量站调水量的分数
            string OFLOWMN_FPS1 = outputline(find(way, "| OFLOWMN_FPS :"), way);//以正常溢洪道水量分数表示水库最小出流量
            string STARG_FPS1 = outputline(find(way, "| STARG_FPS :"), way);//以正常溢洪道水量分数表示的目标蓄水量

            FileStream f = new FileStream(way, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(f);

            txtIYRES.Text = IYRES1.Substring(0, 16).Replace(" ", "");
            txtRES_ESA.Text = RES_ESA1.Substring(0, 16).Replace(" ", "");
            txtRES_EVOL.Text = RES_EVOL1.Substring(0, 16).Replace(" ", "");
            txtRES_PSA.Text = RES_PSA1.Substring(0, 16).Replace(" ", "");
            txtRES_PVOL.Text = RES_PVOL1.Substring(0, 16).Replace(" ", "");
            txtRES_VOL.Text = RES_VOL1.Substring(0, 16).Replace(" ", "");
            txtRES_SED.Text = RES_SED1.Substring(0, 16).Replace(" ", "");
            txtRES_NSED.Text = RES_NSED1.Substring(0, 16).Replace(" ", "");
            txtRES_D50.Text = RES_D501.Substring(0, 16).Replace(" ", "");
            txtRES_K.Text = RES_K1.Substring(0, 16).Replace(" ", "");
            cmbIRESCO.Text = IRESCO1.Substring(0, 16).Replace(" ", "");
            txtRES_RR.Text = RES_RR1.Substring(0, 16).Replace(" ", "");
            cmbIFLOD1R.Text = RES_IFLOD1R1.Substring(0, 16).Replace(" ", "");
            cmbIFLOD2R.Text = RES_IFLOD2R1.Substring(0, 16).Replace(" ", "");
            txtWURTNF.Text = WURTNF1.Substring(0, 16).Replace(" ", "");
            txtOFLOWMN_FPS.Text = OFLOWMN_FPS1.Substring(0, 16).Replace(" ", "");
            txtSTARG_FPS.Text = STARG_FPS1.Substring(0, 16).Replace(" ", "");

            sr.Close();
            f.Close();
        }

        /// <summary>
        /// 还原默认值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtIYRES.Text = "0";//设置默认值
            txtRES_ESA.Text = "0";
            txtRES_EVOL.Text = "0";
            txtRES_PSA.Text = "0";
            txtRES_PVOL.Text = "0";
            txtRES_VOL.Text = "0";
            txtRES_SED.Text = "4000";
            txtRES_NSED.Text = "4000";
            txtRES_D50.Text = "10";
            txtRES_K.Text = "0";
            txtEVRSV.Text = "0.6";
            txtRES_RR.Text = "0";
            txtNDTARGR.Text = "1";
            txtWURTNF.Text = "0";
            txtOFLOWMN_FPS.Text = "0";
            txtSTARG_FPS.Text = "1";
        }

    }
}
