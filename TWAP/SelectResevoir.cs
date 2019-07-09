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
    public partial class SelectResevoir : Form
    {
        AccessHelper helper = new AccessHelper();   //数据库连接帮助类对象
        DataTable dt;  //接收数据表

        public SelectResevoir()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 打开编辑水库数据页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFinish_Click(object sender, EventArgs e)
        {
            EditReservoirData editReservoir = new EditReservoirData();
            editReservoir.str = this.comboBoxReservoirID.Text.ToString(); //发送水库编号
            editReservoir.Show();
            this.Close();
        }
        /// <summary>
        /// 将水库编号加载到combox中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectResevoir_Load(object sender, EventArgs e)
        {
            comboBoxReservoirID.DropDownStyle = ComboBoxStyle.DropDownList; //combox不可编辑
            string sql = "select GRID_CODE from MonitoringPoint where Type='R' order by GRID_CODE ASC";
            dt = helper.GetDataTableFromDB(sql);
            foreach (DataRow dr in dt.Rows)
            {
                this.comboBoxReservoirID.Items.Add(dr[0].ToString()); //从GRID_CODE列中读取水库编号
            }
            if (comboBoxReservoirID.Items.Count == 0)
            {
                this.btnFinish.Enabled = false; //当combox里面没有水库号时，按钮不可点击  
            }
            else
            {
                this.comboBoxReservoirID.Sorted = true; //对数值进行排序
                this.comboBoxReservoirID.SelectedIndex = 0; //默认选择第一个
            }
        }
        /// <summary>
        /// 取消选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
