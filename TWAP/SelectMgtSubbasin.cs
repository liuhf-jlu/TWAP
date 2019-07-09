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
    public partial class SelectMgtSubbasin : Form
    {
        public SelectMgtSubbasin()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 窗体加载时将子流域加到下拉框中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectMgtSubbasin_Load(object sender, EventArgs e)
        {
            int subFileNum = GetFileNum("*.sub", Application.StartupPath + "\\TxtInOut");
            for (int i = 1; i <= subFileNum; i++)
            {
                comboBoxMgtSubbasin.Items.Add(i);
            }
            if(subFileNum!=0)
                comboBoxMgtSubbasin.SelectedIndex = 0;
        }
        /// <summary>
        /// 获取指定文件夹下指定文件类型的数量
        /// </summary>
        /// <param name="fileType">指定文件类型(*.sub)</param>
        /// <param name="dir">指定文件夹</param>
        /// <returns>指定文件的数量</returns>
        private int GetFileNum(string fileType,string dir)
        {
            int fileNum = 0;
            fileNum = System.IO.Directory.GetFiles(dir, fileType).Length;
            return fileNum;
        }
        /// <summary>
        /// 确定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMgtSubOK_Click(object sender, EventArgs e)
        {
            MgtManage mgtManage = new MgtManage(comboBoxMgtSubbasin.SelectedItem.ToString());
            mgtManage.Show();
            this.Close();
        }
        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMgtSubCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
