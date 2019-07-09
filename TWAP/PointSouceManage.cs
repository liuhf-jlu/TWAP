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
    public partial class PointSouceManage : Form
    {

        public PointSouceManage()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 窗体加载时执行的操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PointSouceManage_Load(object sender, EventArgs e)
        {
            //初始化点源列表
            InitPointList();
            //设置为只读
            ComboBoxPointId.DropDownStyle = ComboBoxStyle.DropDownList;
           
        }
        /// <summary>
        /// 初始化点源列表：从数据库中读取点源信息，然后列出到下拉框中
        /// </summary>
        private void InitPointList()
        {
            AccessHelper helper = new AccessHelper();
            string sql = @"select Subbasin from MonitoringPoint where Type='P'";
            DataTable dt = helper.GetDataTableFromDB(sql);
            foreach (DataRow dr in dt.Rows)
            {
                ComboBoxPointId.Items.Add(dr[0]);
            }
            if (ComboBoxPointId.Items.Count != 0)
            {
                ComboBoxPointId.SelectedIndex = 0;
            }
        }
        /// <summary>
        /// 保存编辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            PointSource point = new PointSource(ComboBoxPointId.Text.ToString(), textBoxYearFile.Text.ToString());
            point.WriteDat();
            //point.WriteFig(); 
            MessageBox.Show("保存完成！");
        }

        /// <summary>
        /// 退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 浏览文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Reset();
                Text = openFileDialog1.Title;
                openFileDialog1.Filter = "*.txt|*.txt";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    textBoxYearFile.Text = openFileDialog1.FileName;
                }
            }
            catch (Exception ex)
            {
                ;
            }
        }
       
    }
}
