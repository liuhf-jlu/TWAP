using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TWAP
{
    public partial class Main : Form
    {
        /// <summary>
        /// 主页面初始化
        /// </summary>
        public Main()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Normal;
        }
      
        /// <summary>
        /// 窗体加载时执行的操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
        }
        /// <summary>
        /// 水质模拟
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbWaterQuality_Click(object sender, EventArgs e)
        {
            WaterQuality waterQuality = new WaterQuality();
            waterQuality.WindowState = FormWindowState.Maximized;
            waterQuality.Show();
            this.Hide();
        }
        /// <summary>
        /// 水量管理页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbWaterYield_Click(object sender, EventArgs e)
        {
            WaterYield waterYield = new WaterYield();
            waterYield.WindowState = FormWindowState.Maximized;     //窗体最大化
            waterYield.Show();
            this.Hide();
        }
        /// <summary>
        /// 主页面退出系统
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("是否关闭系统？", "关闭系统", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dr==DialogResult.Yes)
                Application.Exit();
        }
        /// <summary>
        /// 水生态安全评估
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbWaterEcology_Click(object sender, EventArgs e)
        {

        }
       
        /// <summary>
        /// 状态栏添加时间信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            mainTime.Text = "您好，欢迎登陆系统！  登录时间：" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
        }

        private void tsbHelp_Click(object sender, EventArgs e)
        {
            if(System.IO.Directory.Exists("TWAP用户手册"))
            {

            }
            else
            {
                MessageBox.Show("《TWAP用户手册》不存在");
            }
        }

        private void tsbAbout_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

    }
}
