using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Text.RegularExpressions;   //正则表达式

namespace TWAP
{
    public partial class MgtManage : Form
    {
        AccessHelper helper = null;
        string subbasinId = null;
        DataTable dt = new DataTable();
        BindingSource bs = new BindingSource();
        public MgtManage()
        {
            InitializeComponent();
        }
        public MgtManage(string subbasinId_)
        {
            InitializeComponent();
            this.subbasinId = subbasinId_;
        }
        private void MgtManage_Load(object sender, EventArgs e)
        {
            //设置未编辑状态
            tabControlMgt.Enabled = false;
            btnUpdate.Enabled = false;
            btnAddOperation.Enabled = false;
            btnDeleteOperation.Enabled = false;
            btnSaveEdit.Enabled = false;
            //添加月
            getMonth();
            //添加作物列表
            getPlantID();
            //添加肥料列表
            getFERT_ID();
            //初始化dataGridView表,显示做过的操作
            InitDataTable();
        }
        /// <summary>
        /// 初始化dataGridViewMgt表
        /// </summary>
        public void InitDataTable()
        {
            dataGridViewMgt.Columns.Clear();    //清除原有的数据
            //datagridview添加列
            dataGridViewMgt.Columns.Add("year", "年");  //0
            dataGridViewMgt.Columns.Add("month", "月");  //1
            dataGridViewMgt.Columns.Add("day", "日");    //2
            dataGridViewMgt.Columns.Add("operation", "操作"); //3
            dataGridViewMgt.Columns.Add("crop", "作物");  //4
            dataGridViewMgt.Columns.Add("fert", "肥料");  //5
            dt = getMgtFromDB();    //获取mgt2表中的信息
            this.dataGridViewMgt.AutoGenerateColumns = false; //不允许自动生成
            foreach (DataRow dr in dt.Rows)
            {
                string mgtOpName = "";
                string plantName = "";
                string fertName = "";
                mgtOpName = getOperationNamebyID(Convert.ToInt32(dr[3]));
                if (dr[4] != null)
                    plantName = getPlantNameByID(Convert.ToInt32(dr[4]));
                if (dr[5] != null)
                    fertName = getFertNameByID(Convert.ToInt32(dr[5]));
                dataGridViewMgt.Rows.Add(dr[0], dr[1], dr[2], mgtOpName, plantName, fertName);
            }
        }
        /// <summary>
        /// 根据肥料ID获取肥料名称
        /// </summary>
        /// <param name="FertID">肥料ID</param>
        /// <returns>肥料名称</returns>
        private string getFertNameByID(int FertID)
        {
            if (FertID != 0)
            {
                string FertName = "";
                dt = new DataTable();
                string sql = "select FERTNM from fert where IFNUM =" + FertID;
                helper = new AccessHelper(Application.StartupPath + "\\SWAT2012.mdb");
                dt = helper.GetDataTableFromDB(sql);
                FertName = dt.Rows[0][0].ToString();
                return FertName;
            }
            else
                return "";
        }
        /// <summary>
        /// 根据操作ID获取操作名称
        /// </summary>
        /// <param name="OperationID">操作ID</param>
        /// <returns>操作名称</returns>
        private string getOperationNamebyID(int OperationID)
        {
            string OperationName = "";
            DataTable dt = new DataTable();
            string sql = "select OP from mgttype where OPNUM = " + OperationID;
            AccessHelper helper = new AccessHelper();
            dt = helper.GetDataTableFromDB(sql);
            OperationName = dt.Rows[0][0].ToString();
            return OperationName;
        }
        /// <summary>
        /// 根据作物ID获取作物名称
        /// </summary>
        /// <param name="PlantID">作物ID</param>
        /// <returns>作物名称</returns>
        private string getPlantNameByID(int PlantID)
        {
            if (PlantID != 0)
            {
                string PlantName = "";
                DataTable dt = new DataTable();
                string sql = "select CROPNAME from crop where ICNUM = " + PlantID;
                helper = new AccessHelper();
                dt = helper.GetDataTableFromDB(sql);
                PlantName = dt.Rows[0][0].ToString();
                return PlantName;

            }
            else
                return "";
        }
        /// <summary>
        /// 读取指定子流域的第一个HRU的信息
        /// </summary>
        /// <returns></returns>
        private DataTable getMgtFromDB()
        {
            //以每个子流域的第一个HRU为代表
            string sql = "select YEAR,MONTH,DAY,MGT_OP,PLANT_ID,FERT_ID from mgt2 where SUBBASIN =" + subbasinId + " and hru = 1 ";
            AccessHelper helper = new AccessHelper();
            DataTable dt = helper.GetDataTableFromDB(sql);
            return dt;
        }

        /// <summary>
        /// 读取指定行
        /// </summary>
        /// <param name="fileDir">指定文本文件</param>
        /// <param name="str">指定字符串</param>
        /// <returns>指定字符串所在的行数</returns>
        private int readTo(string fileDir, string str)
        {
            int line = 0;
            StreamReader sr = new StreamReader(fileDir);
            string content = sr.ReadToEnd();
            string[] arrayStr = Regex.Split(str, "\r\n");
            do
            {
                line++;
            } while (!(arrayStr[line - 1].Equals(str)));
            return line;
        }
        /// <summary>
        /// 月
        /// </summary>
        private void getMonth()
        {
            for (int i = 1; i <= 12; i++)
            {
                PLANT_MONTH.Items.Add(i);
                IRR_MONTH.Items.Add(i);
                FRT_MONTH.Items.Add(i);
                HARV_MONTH.Items.Add(i);
            }
        }
        /// <summary>
        /// 日
        /// </summary>
        /// <param name="month"></param>
        private void getDay(int month)
        {
            if (month == 1 || month == 3 || month == 5 | month == 7 || month == 8 || month == 10 || month == 12)
            {
                for (int i = 1; i <= 31; i++)
                {
                    PLANT_DAY.Items.Add(i);
                    IRR_DAY.Items.Add(i);
                    FRT_DAY.Items.Add(i);
                    HARV_DAY.Items.Add(i);
                }

            }
            else if (month == 2)
            {
                for (int i = 1; i <= 28; i++)
                {
                    PLANT_DAY.Items.Add(i);
                    IRR_DAY.Items.Add(i);
                    FRT_DAY.Items.Add(i);
                    HARV_DAY.Items.Add(i);
                }
            }
            else
            {
                for (int i = 1; i <= 30; i++)
                {
                    PLANT_DAY.Items.Add(i);
                    IRR_DAY.Items.Add(i);
                    FRT_DAY.Items.Add(i);
                    HARV_DAY.Items.Add(i);
                }
            }
        }
        /// <summary>
        /// 添加植物种类
        /// </summary>
        private void getPlantID()
        {
            AccessHelper helper = new AccessHelper(Application.StartupPath + "\\SWAT2012.mdb");
            string sql = "select ICNUM,CROPNAME from crop ";
            DataTable dt = helper.GetDataTableFromDB(sql);
            foreach (DataRow dr in dt.Rows)
            {
                PLANT_ID.Items.Add(dr[0].ToString() + "," + dr[1].ToString());
            }
        }
        /// <summary>
        /// 添加肥料种类
        /// </summary>
        private void getFERT_ID()
        {
            AccessHelper helper = new AccessHelper(Application.StartupPath + "\\SWAT2012.mdb");
            string sql = "select IFNUM,FERTNM from fert";
            DataTable dt = helper.GetDataTableFromDB(sql);
            foreach (DataRow dr in dt.Rows)
            {
                FERT_ID.Items.Add(dr[0].ToString() + "," + dr[1].ToString());
            }
        }

        /// <summary>
        /// 编辑操作，更改控件的可用性
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditOperation_Click(object sender, EventArgs e)
        {
            btnUpdate.Enabled = true;
            tabControlMgt.Enabled = true;
            btnUpdate.Enabled = true;
            btnAddOperation.Enabled = true;
            btnDeleteOperation.Enabled = true;
            btnSaveEdit.Enabled = true;
        }
        /// <summary>
        /// 删除操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteOperation_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("是否删除该操作？", "删除提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    int Month = Convert.ToInt32(dataGridViewMgt.CurrentRow.Cells["month"].Value.ToString());
                    int Day = Convert.ToInt32(dataGridViewMgt.CurrentRow.Cells["day"].Value.ToString());
                    int MGT_OP = GetMGT_OPByName(dataGridViewMgt.CurrentRow.Cells["operation"].Value.ToString());
                    int hruNum = getHruNum(Convert.ToInt32(subbasinId));
                    for (int i = 1; i <= hruNum; i++)
                    {
                        DeleteMGT_OP(Convert.ToInt32(subbasinId), i, Month, Day, MGT_OP);
                    }
                    InitDataTable();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }
        /// <summary>
        /// 根据指定的条件删除
        /// </summary>
        /// <param name="subbasinID"></param>
        /// <param name="hruID"></param>
        /// <param name="Month"></param>
        /// <param name="Day"></param>
        /// <param name="MGT_OP"></param>
        /// <returns></returns>
        private int DeleteMGT_OP(int subbasinID, int hruID, int Month, int Day, int MGT_OP)
        {
            string sql = "delete from mgt2 where SUBBASIN = " + subbasinID + " and HRU = " + hruID + " and MONTH = " + Month + " and DAY = " + Day + " and MGT_OP = " + MGT_OP;
            AccessHelper helper = new AccessHelper();
            int n = helper.ExcuteSql(sql);
            return n;
        
        }

        private int UpdateMGT_OP(MgtParameter mgt,int subbasinID, int hruID, int Month, int Day, int MGT_OP)
        {
            int n = 0;
            AccessHelper helper = new AccessHelper();
            if (MGT_OP == 1)
            {
                string sql = @"update mgt2 set [MONTH] ="+mgt.plant_month+",[DAY] = "+mgt.plant_day+",HUSC = "+mgt.plant_husc+",PLANT_ID = "+mgt.plant_id+",CURYR_MAT = "+
                               mgt.curyr_mat+",HEATUNITS = "+mgt.heat_units+",BIO_INIT = "+mgt.bio_init+",HI_TARG = "+mgt.hi_targ+",LAI_INIT = "+mgt.lai_init+",BIO_TARG = "+mgt.bio_init+",CNOP = "+mgt.plant_cnop+
                               " where SUBBASIN = " + subbasinID + " and HRU = " + hruID + " and MGT_OP = " + MGT_OP + " and MONTH = " + Month + " and DAY = " + Day;
                n = helper.ExcuteSql(sql);
            }
            else if (MGT_OP == 2)
            {
                string sql = @"update mgt2 set [MONTH] = " + mgt.irr_month + ",[DAY] = " + mgt.irr_day + ",HUSC = " + mgt.irr_husc + ",IRR_AMT = " + mgt.irr_amt + ",IRR_SALT = " + mgt.irr_salt +
                            ",IRR_EFM = " + mgt.irr_efm + ",IRR_SQ = " + mgt.irr_sq + ",IRR_SC = " + mgt.irr_sc+",IRR_NO = "+mgt.irr_no+
                            " where SUBBASIN = " + subbasinID + " and HRU = " + hruID + " and MGT_OP = " + MGT_OP + " and MONTH = " + Month + " and DAY = " + Day;
                n = helper.ExcuteSql(sql);
            }
            else if (MGT_OP == 3)
            {
                string sql = @"update mgt2 set [MONTH] = " +mgt.frt_month+",[DAY] = "+mgt.frt_day+",HUSC = "+mgt.frt_husc+",FERT_ID = "+mgt.fert_id+",FRT_KG = "+mgt.frt_kg+
                              ",FRT_SURFACE = "+mgt.frt_surface+
                              " where SUBBASIN = " + subbasinID + " and HRU = " + hruID + " and MGT_OP = " + MGT_OP + " and MONTH = " + Month + " and DAY = " + Day;
                n = helper.ExcuteSql(sql);

            }
            else if (MGT_OP == 5)
            {
                string sql = @"update mgt2 set [MONTH] = " +mgt.harv_month+",[DAY] = "+mgt.harv_day+",HUSC = "+mgt.harv_husc+",CNOP = "+mgt.harv_cnop+
                              " where SUBBASIN = " + subbasinID + " and HRU = " + hruID + " and MGT_OP = " + MGT_OP + " and MONTH = " + Month + " and DAY = " + Day;
                n = helper.ExcuteSql(sql);

            }
            return n;
        }
        /// <summary>
        /// 更新操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MgtParameter mgt = new MgtParameter();
            int hruNum = 0; //hru的数量
            DialogResult dr = MessageBox.Show("正在进行更新操作", "更新数据", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.Cancel)
                return;
            //判断不同的操作
            if (tabControlMgt.SelectedIndex == 0)   //种植
            {
                try
                {
                    int currentMonth = Convert.ToInt32(dataGridViewMgt.CurrentRow.Cells["Month"].Value.ToString());
                    int currentDay = Convert.ToInt32(dataGridViewMgt.CurrentRow.Cells["Day"].Value.ToString());

                    hruNum = getHruNum(Convert.ToInt32(subbasinId));
                    mgt.plant_month = Convert.ToInt32(PLANT_MONTH.SelectedItem);
                    mgt.plant_day = Convert.ToInt32(PLANT_DAY.SelectedItem);
                    mgt.plant_husc = 0;
                    mgt.plant_mgt_op = 1;
                    mgt.plant_id = Convert.ToInt32(PLANT_ID.Text.Split(',')[0]);
                    mgt.crop = getPlantNameByID(mgt.plant_id);  //作物名称
                    mgt.curyr_mat = Convert.ToInt32(CURYR_MAT.Text);
                    mgt.heat_units = Convert.ToDouble(PLANT_HEAT_UNITS.Text);
                    mgt.bio_init = Convert.ToDouble(BIO_INIT.Text);
                    mgt.hi_targ = Convert.ToDouble(HI_TARG.Text);
                    mgt.lai_init = Convert.ToDouble(LAI_INIT.Text);
                    mgt.bio_targ = Convert.ToDouble(BIO_TARG.Text);
                    mgt.plant_cnop = Convert.ToDouble(PLANT_CNOP.Text);
                    //对子流域的所有hru进行操作
                    for (int hruID = 1; hruID <= hruNum; hruID++)
                    {
                        UpdateMGT_OP(mgt, Convert.ToInt32(subbasinId), hruID, currentMonth, currentDay, mgt.plant_mgt_op);
                        MgtMessage.Text = "subbasin : "+subbasinId+",hru:"+hruID+" 更新参数成功！";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MgtMessage.Text = "更新参数失败，请重试！";
                }
                InitDataTable();
            }
            else if (tabControlMgt.SelectedIndex == 1)  //灌溉
            {
                try
                {
                    int currentMonth = Convert.ToInt32(dataGridViewMgt.CurrentRow.Cells["Month"].Value.ToString());
                    int currentDay = Convert.ToInt32(dataGridViewMgt.CurrentRow.Cells["Day"].Value.ToString());

                    hruNum = getHruNum(Convert.ToInt32(subbasinId));
                    mgt.irr_month = Convert.ToInt32(IRR_MONTH.SelectedItem);
                    mgt.irr_day = Convert.ToInt32(IRR_DAY.SelectedItem);
                    mgt.irr_husc = 0;
                    mgt.irr_mgt_op = 2;
                    mgt.irr_amt = Convert.ToDouble(IRR_AMT.Text);
                    mgt.irr_salt = Convert.ToDouble(IRR_SALT.Text);
                    mgt.irr_efm = Convert.ToDouble(IRR_EFM.Text);
                    mgt.irr_sq = Convert.ToDouble(IRR_SQ.Text);
                    mgt.irr_sc = Convert.ToDouble(IRR_SC.Text);
                    mgt.irr_no = Convert.ToDouble(IRR_NO.Text);
                    //对子流域的所有hru进行操作
                    for (int hruID = 1; hruID <= hruNum; hruID++)
                    {
                        UpdateMGT_OP(mgt, Convert.ToInt32(subbasinId), hruID, currentMonth, currentDay, mgt.irr_mgt_op);
                        MgtMessage.Text = "subbasin : " + subbasinId + ",hru:" + hruID + " 更新参数成功！";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MgtMessage.Text = "更新参数失败，请重试！";
                }
                InitDataTable();

            }
            else if (tabControlMgt.SelectedIndex == 2)  //施肥
            {
                try
                {
                    int currentMonth = Convert.ToInt32(dataGridViewMgt.CurrentRow.Cells["Month"].Value.ToString());
                    int currentDay = Convert.ToInt32(dataGridViewMgt.CurrentRow.Cells["Day"].Value.ToString());


                    hruNum = getHruNum(Convert.ToInt32(subbasinId));
                    mgt.frt_month = Convert.ToInt32(FRT_MONTH.SelectedItem);
                    mgt.frt_day = Convert.ToInt32(FRT_DAY.SelectedItem);
                    mgt.frt_husc = 0;
                    mgt.frt_mgt_op = 3;
                    mgt.fert_id = Convert.ToInt32(FERT_ID.Text.Split(',')[0]);
                    mgt.fert_name = getFertNameByID(mgt.fert_id);
                    mgt.frt_kg = Convert.ToDouble(FRT_KG.Text);
                    mgt.frt_surface = Convert.ToDouble(FRT_SURFACE.Text);
                    //对子流域的所有hru进行操作
                    for (int hruID = 1; hruID <= hruNum; hruID++)
                    {
                        UpdateMGT_OP(mgt, Convert.ToInt32(subbasinId), hruID, currentMonth, currentDay, mgt.frt_mgt_op);
                        MgtMessage.Text = "subbasin : " + subbasinId + ",hru:" + hruID + " 更新参数成功！";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MgtMessage.Text = "更新参数失败，请重试！";
                }
             
                InitDataTable();
            }
            else if (tabControlMgt.SelectedIndex == 3)  //收割
            {
                try
                {
                    int currentMonth = Convert.ToInt32(dataGridViewMgt.CurrentRow.Cells["Month"].Value.ToString());
                    int currentDay = Convert.ToInt32(dataGridViewMgt.CurrentRow.Cells["Day"].Value.ToString());


                    hruNum = getHruNum(Convert.ToInt32(subbasinId));
                    mgt.harv_month = Convert.ToInt32(HARV_MONTH.SelectedItem);
                    mgt.harv_day = Convert.ToInt32(HARV_DAY.SelectedItem);
                    mgt.harv_mgt_op = 5;
                    mgt.harv_husc = 0;
                    mgt.harv_cnop = Convert.ToDouble(HARV_CNOP.Text);
                    //对子流域的所有hru进行操作
                    for (int hruID = 1; hruID <= hruNum; hruID++)
                    {
                        UpdateMGT_OP(mgt, Convert.ToInt32(subbasinId), hruID, currentMonth, currentDay, mgt.harv_mgt_op);
                        MgtMessage.Text = "subbasin : " + subbasinId + ",hru:" + hruID + " 更新参数成功！";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MgtMessage.Text = "更新参数失败，请重试！";
                }
                MgtMessage.Text="更新参数成功！";
                InitDataTable();
            }
        }
        /// <summary>
        /// 保存编辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            helper = new AccessHelper();
            string sql = "select MGT_OP,MONTH,DAY from mgt2 where SUBBASIN =" + subbasinId + " AND HRU = 1;";
            DataTable dt_c = helper.GetDataTableFromDB(sql);
            DataTable dt_show = new DataTable();
            DataRow dr = dt_show.NewRow();
            string str = "";
            foreach (DataRow dr_c in dt_c.Rows)
            {
                switch (Convert.ToInt32(dr_c[0].ToString()))
                {
                    case 1:
                        //获取mgt2表中的信息
                        //以每个子流域的第一个HRU为代表
                        sql = "select  MONTH,DAY,HUSC,MGT_OP,PLANT_ID,CURYR_MAT,HEATUNITS,LAI_INIT,HI_TARG,BIO_INIT,BIO_TARG,CNOP from mgt2 where SUBBASIN =" + subbasinId + " and hru = 1 and MGT_OP=1 and MONTH=" + dr_c[1] + " and DAY=" + dr_c[2] + ";";
                        dt_show = helper.GetDataTableFromDB(sql);
                        str += " ";
                        str += dt_show.Rows[0].ItemArray[0].ToString().PadLeft(2, ' '); str += " ";
                        str += dt_show.Rows[0].ItemArray[1].ToString().PadLeft(2, ' '); str += " ";
                        str += string.Format("{0:0000.000}", Convert.ToDouble(dt_show.Rows[0].ItemArray[2])).PadLeft(8, ' '); str += " ";
                        str += dt_show.Rows[0].ItemArray[3].ToString().PadLeft(2, ' '); str += " ";
                        str += dt_show.Rows[0].ItemArray[4].ToString().PadLeft(4, ' '); str += " ";
                        str += dt_show.Rows[0].ItemArray[5].ToString().PadLeft(2, ' '); str += " ";
                        str += string.Format("{0:000000.00000}", Convert.ToDouble(dt_show.Rows[0].ItemArray[6])).PadLeft(12, ' '); str += " ";
                        str += string.Format("{0:000.00}", Convert.ToDouble(dt_show.Rows[0].ItemArray[7])).PadLeft(6, ' '); str += " ";
                        str += string.Format("{0:00000.00000}", Convert.ToDouble(dt_show.Rows[0].ItemArray[8])).PadLeft(11, ' '); str += " ";
                        str += string.Format("{0:0.00}", Convert.ToDouble(dt_show.Rows[0].ItemArray[9])).PadLeft(4, ' '); str += " ";
                        str += string.Format("{0:00000.00}", Convert.ToDouble(dt_show.Rows[0].ItemArray[10])).PadLeft(6, ' '); str += " ";
                        str += string.Format("{0:00.00}", Convert.ToDouble(dt_show.Rows[0].ItemArray[11])).PadLeft(5, ' '); str += " ";
                        str += "\r\n"; break;
                    case 2:
                        sql = "select MONTH,DAY,HUSC,MGT_OP,IRR_SC,IRR_NO,IRR_AMT,IRR_SALT,IRR_EFM,IRR_SQ from mgt2 where SUBBASIN =" + subbasinId + " and hru = 1 and MGT_OP=2  and MONTH=" + dr_c[1] + " and DAY=" + dr_c[2] + ";";
                        dt_show = helper.GetDataTableFromDB(sql);
                        str += " ";
                        str += dt_show.Rows[0].ItemArray[0].ToString().PadLeft(2, ' '); str += " ";
                        str += dt_show.Rows[0].ItemArray[1].ToString().PadLeft(2, ' '); str += " ";
                        str += string.Format("{0:0000.000}", Convert.ToDouble(dt_show.Rows[0].ItemArray[2])).PadLeft(8, ' '); str += " ";
                        str += dt_show.Rows[0].ItemArray[3].ToString().PadLeft(2, ' '); str += " ";
                        str += dt_show.Rows[0].ItemArray[4].ToString().PadLeft(3, ' '); str += " ";
                        str += dt_show.Rows[0].ItemArray[5].ToString().PadLeft(2, ' '); str += " ";
                        str += string.Format("{0:000000.00000}", Convert.ToDouble(dt_show.Rows[0].ItemArray[6])).PadLeft(12, ' '); str += " ";
                        str += string.Format("{0:000.00}", Convert.ToDouble(dt_show.Rows[0].ItemArray[7])).PadLeft(6, ' '); str += " ";
                        str += string.Format("{0:00000.00000}", Convert.ToDouble(dt_show.Rows[0].ItemArray[8])).PadLeft(11, ' '); str += " ";
                        str += string.Format("{0:000.00}", Convert.ToDouble(dt_show.Rows[0].ItemArray[9])).PadLeft(4, ' '); str += " ";
                        str += "\r\n"; break;
                    case 3:
                        sql = "select MONTH,DAY,HUSC,MGT_OP,FERT_ID,FRT_KG,FRT_SURFACE  from mgt2 where SUBBASIN =" + subbasinId + " and hru = 1 and MGT_OP=3 and MONTH=" + dr_c[1] + " and DAY=" + dr_c[2] + ";";
                        dt_show = helper.GetDataTableFromDB(sql);
                        str += " ";
                        str += dt_show.Rows[0].ItemArray[0].ToString().PadLeft(2, ' '); str += " ";
                        str += dt_show.Rows[0].ItemArray[1].ToString().PadLeft(2, ' '); str += " ";
                        str += string.Format("{0:0000.000}", Convert.ToDouble(dt_show.Rows[0].ItemArray[2])).PadLeft(8, ' '); str += " ";
                        str += dt_show.Rows[0].ItemArray[3].ToString().PadLeft(2, ' '); str += " ";
                        str += dt_show.Rows[0].ItemArray[4].ToString().PadLeft(4, ' '); str += " ";
                        str += string.Format("{0:000000.00000}", Convert.ToDouble(dt_show.Rows[0].ItemArray[5])).PadLeft(12, ' '); str += " ";
                        str += string.Format("{0:000.00}", Convert.ToDouble(dt_show.Rows[0].ItemArray[6])).PadLeft(6, ' '); str += " ";
                        str += "\r\n"; break;

                    case 5:
                        sql = "select MONTH,DAY,HUSC,MGT_OP,CNOP,HI_OVR,FRAC_HARVK from mgt2 where SUBBASIN =" + subbasinId + " and hru = 1 and MGT_OP=5 and MONTH=" + dr_c[1] + " and DAY=" + dr_c[2] + ";";
                        dt_show = helper.GetDataTableFromDB(sql);
                        str += " ";
                        str += dt_show.Rows[0].ItemArray[0].ToString().PadLeft(2, ' '); str += " ";
                        str += dt_show.Rows[0].ItemArray[1].ToString().PadLeft(2, ' '); str += " ";
                        str += string.Format("{0:0000.000}", Convert.ToDouble(dt_show.Rows[0].ItemArray[2])).PadLeft(8, ' '); str += " ";
                        str += dt_show.Rows[0].ItemArray[3].ToString().PadLeft(2, ' '); str += " ";
                        str += string.Format("{0:000000.00000}", Convert.ToDouble(dt_show.Rows[0].ItemArray[4])).PadLeft(12, ' '); str += " ";
                        str += string.Format("{0:000.00}", Convert.ToDouble(dt_show.Rows[0].ItemArray[5])).PadLeft(6, ' '); str += " ";
                        str += string.Format("{0:00.00}", Convert.ToDouble(dt_show.Rows[0].ItemArray[6])).PadLeft(5, ' '); str += " ";
                        str += "\r\n"; break;
                }
            }
            string way = Application.StartupPath + @"\TxtInOut";
            DirectoryInfo folder = new DirectoryInfo(way);
            foreach (FileInfo file in folder.GetFiles(subbasinId.ToString().PadLeft(5, '0') + "*.mgt")) //遍历所有指定的mgt文件
            {
                int rows = find(Application.StartupPath + @"\TxtInOut\" + file.Name, "Operation Schedule:"); //查找指定字符串"Operation Schedule:"所在行数
                if (rows == 0)
                    MessageBox.Show(file.Name + "文件格式错误！");
                var lines = File.ReadAllLines(Application.StartupPath + @"\TxtInOut\" + file.Name);  //读取文件的所有行
                var query = lines.Take(rows).ToArray();     //读取"Operation Schedule:"之前（包含）的字符串
                File.WriteAllLines(Application.StartupPath + @"\TxtInOut\" + file.Name, query);  //重写
                using (StreamWriter sw = new StreamWriter(Application.StartupPath + @"\TxtInOut\" + file.Name, true))
                {
                    sw.WriteLine(str);
                }
            }
            MessageBox.Show("保存编辑完成！");
        }
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
        /// 退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PLANT_MONTH_SelectedIndexChanged(object sender, EventArgs e)
        {
            PLANT_DAY.Items.Clear();
            getDay(Convert.ToInt32(PLANT_MONTH.SelectedItem));
        }

        private void IRR_MONTH_SelectedIndexChanged(object sender, EventArgs e)
        {
            IRR_DAY.Items.Clear();
            getDay(Convert.ToInt32(IRR_MONTH.SelectedItem));
        }

        private void FRT_MONTH_SelectedIndexChanged(object sender, EventArgs e)
        {
            FRT_DAY.Items.Clear();
            getDay(Convert.ToInt32(FRT_MONTH.SelectedItem));
        }

        private void HARV_MONTH_SelectedIndexChanged(object sender, EventArgs e)
        {
            HARV_DAY.Items.Clear();
            getDay(Convert.ToInt32(HARV_MONTH.SelectedItem));
        }
        /// <summary>
        /// 添加操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddOperation_Click(object sender, EventArgs e)
        {
            MgtParameter mgt = new MgtParameter();
            int hruNum = 0; //hru的数量
            //判断不同的操作
            if (tabControlMgt.SelectedIndex == 0)   //种植
            {
                try
                {
                    hruNum = getHruNum(Convert.ToInt32(subbasinId));
                    mgt.plant_month = Convert.ToInt32(PLANT_MONTH.SelectedItem);
                    mgt.plant_day = Convert.ToInt32(PLANT_DAY.SelectedItem);
                    mgt.plant_husc = 0;
                    mgt.plant_mgt_op = 1;
                    mgt.plant_id = Convert.ToInt32(PLANT_ID.Text.Split(',')[0]);
                    mgt.crop = getPlantNameByID(mgt.plant_id);  //作物名称
                    mgt.curyr_mat = Convert.ToInt32(CURYR_MAT.Text);
                    mgt.heat_units = Convert.ToInt32(PLANT_HEAT_UNITS.Text);
                    mgt.bio_init = Convert.ToDouble(BIO_INIT.Text);
                    mgt.hi_targ = Convert.ToDouble(HI_TARG.Text);
                    mgt.lai_init = Convert.ToDouble(LAI_INIT.Text);
                    mgt.bio_targ = Convert.ToDouble(BIO_TARG.Text);
                    mgt.plant_cnop = Convert.ToDouble(PLANT_CNOP.Text);
                    //对子流域的所有hru进行操作
                    for (int hruID = 1; hruID <= hruNum; hruID++)
                    {
                        CopyToSelf(Convert.ToInt32(subbasinId), hruID, 1, mgt); //※拷贝固定子流域的每一个HRU的副本，然后在对该副本进行更新数据
                        MgtMessage.Text = "subbasin : " + subbasinId + ",hru:" + hruID + " 添加成功！";

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MgtMessage.Text = "添加失败！";
                }
                InitDataTable();
            }
            else if (tabControlMgt.SelectedIndex == 1)  //灌溉
            {
                try
                {
                    hruNum = getHruNum(Convert.ToInt32(subbasinId));
                    mgt.irr_month = Convert.ToInt32(IRR_MONTH.SelectedItem);
                    mgt.irr_day = Convert.ToInt32(IRR_DAY.SelectedItem);
                    mgt.irr_husc = 0;
                    mgt.irr_mgt_op = 2;
                    mgt.irr_amt = Convert.ToDouble(IRR_AMT.Text);
                    mgt.irr_salt = Convert.ToDouble(IRR_SALT.Text);
                    mgt.irr_efm = Convert.ToDouble(IRR_EFM.Text);
                    mgt.irr_sq = Convert.ToDouble(IRR_SQ.Text);
                    mgt.irr_sc = Convert.ToDouble(IRR_SC.Text);
                    mgt.irr_no = Convert.ToDouble(IRR_NO.Text);
                    //对子流域的所有hru进行操作
                    for (int hruID = 1; hruID <= hruNum; hruID++)
                    {
                        CopyToSelf(Convert.ToInt32(subbasinId), hruID, 2, mgt); //复制一条数据
                        MgtMessage.Text = "subbasin : " + subbasinId + ",hru:" + hruID + " 添加成功！";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MgtMessage.Text = "添加失败！";
                }
                InitDataTable();

            }
            else if (tabControlMgt.SelectedIndex == 2)  //施肥
            {
                try
                {
                    hruNum = getHruNum(Convert.ToInt32(subbasinId));
                    mgt.frt_month = Convert.ToInt32(FRT_MONTH.SelectedItem);
                    mgt.frt_day = Convert.ToInt32(FRT_DAY.SelectedItem);
                    mgt.frt_husc = 0;
                    mgt.frt_mgt_op = 3;
                    mgt.fert_id = Convert.ToInt32(FERT_ID.Text.Split(',')[0]);
                    mgt.fert_name = getFertNameByID(mgt.fert_id);
                    mgt.frt_kg = Convert.ToDouble(FRT_KG.Text);
                    mgt.frt_surface = Convert.ToDouble(FRT_SURFACE.Text);
                    //对子流域的所有hru进行操作
                    for (int hruID = 1; hruID <= hruNum; hruID++)
                    {
                        CopyToSelf(Convert.ToInt32(subbasinId), hruID, 3, mgt); //复制一条数据
                        MgtMessage.Text = "subbasin : " + subbasinId + ",hru:" + hruID + " 添加成功！";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MgtMessage.Text = "添加失败！";
                }
                InitDataTable();
            }
            else if (tabControlMgt.SelectedIndex == 3)  //收割
            {
                try
                {
                    hruNum = getHruNum(Convert.ToInt32(subbasinId));
                    mgt.harv_month = Convert.ToInt32(HARV_MONTH.SelectedItem);
                    mgt.harv_day = Convert.ToInt32(HARV_DAY.SelectedItem);
                    mgt.harv_mgt_op = 5;
                    mgt.harv_husc = 0;
                    mgt.harv_cnop = Convert.ToDouble(HARV_CNOP.Text);
                    //对子流域的所有hru进行操作
                    for (int hruID = 1; hruID <= hruNum; hruID++)
                    {
                        CopyToSelf(Convert.ToInt32(subbasinId), hruID, 5, mgt); //复制一条数据
                        MgtMessage.Text = "subbasin : " + subbasinId + ",hru:" + hruID + " 添加成功！";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MgtMessage.Text="添加失败！";
                }
                InitDataTable();
            }
        }
        /// <summary>
        /// 返回指定子流域的hru的数量
        /// </summary>
        /// <param name="subbasinID">子流域编号</param>
        /// <returns>hru数量</returns>
        private int getHruNum(int subbasinID)
        {
            if (subbasinID == 0)
                return 0;
            AccessHelper helper = new AccessHelper();
            string sql = "select count(HRU) from hru where SUBBASIN = " + subbasinID;
            dt = helper.GetDataTableFromDB(sql);
            int hruNum = Convert.ToInt32(dt.Rows[0][0]);
            return hruNum;
        }
        /// <summary>
        /// 根据subbasin和hru得到landuse、soil、slope信息
        /// </summary>
        /// <param name="subbasin"></param>
        /// <param name="hru"></param>
        /// <returns></returns>
        private DataTable getLandUse_Soil_SlopeBySUBAndHRU(int subbasin,int hru)
        {
            AccessHelper helper = new AccessHelper();
            string sql = @"select LANDUSE,SOIL,SLOPE_CD from hru where SUBBASIN = "+subbasin+" AND HRU = "+hru;
            DataTable dt = helper.GetDataTableFromDB(sql);
            return dt;
        }
        /// <summary>
        /// 同一个表中复制一条记录到另外一条记录（主键除外）
        /// </summary>
        /// <param name="subbasinID">子流域编号</param>
        /// <param name="hruID">hru编号</param>
        /// <param name="MGT_OP">操作编号</param>
        /// <param name="mgt">MGT参数类</param>
        private void CopyToSelf(int subbasinID, int hruID, int MGT_OP, MgtParameter mgt)
        {
            AccessHelper MGTHelper = new AccessHelper();
            /*
             * 改代码舍弃！！！存在严重BUG
             * 拷贝指定子流域下的指定HRU的一个副本，然后对该副本进行更新数据（利用原来的数据表格式）
             * 由于YEAR,MONTH,DAY,都是ACCESS的关键字，所以要加中括号（“[]”）
             */
//            string sql = @"INSERT INTO mgt2(SUBBASIN,HRU,LANDUSE,SOIL, SLOPE_CD, CROP, [YEAR], [MONTH], [DAY], HUSC, MGT_OP, HEATUNITS, PLANT_ID, CURYR_MAT, LAI_INIT,BIO_INIT,
//				                               HI_TARG, BIO_TARG,CNOP, IRR_AMT, FERT_ID,FRT_KG,FRT_SURFACE,PEST_ID,PST_KG,TILLAGE_ID,HARVEFF,HI_OVR,GRZ_DAYS,MANURE_ID,BIO_EAT,
//				                               BIO_TRMP,MANURE_KG,WSTRS_ID,AUTO_WSTRS,AFERT_ID,AUTO_NSTRS,AUTO_NAPP,AUTO_NYR,AUTO_EFF,AFRT_SURFACE,SWEEPEFF,FR_CURB,IMP_TRIG,
//				                               FERT_DAYS,CFRT_ID,IFRT_FREQ,CFRT_KG, PST_DEP,IHV_GBM,IRR_SALT,IRR_EFM,IRR_SQ,IRR_EFF,IRR_MX,IRR_ASQ, CPST_ID,PEST_DAYS,IPEST_FREQ,
//				                               CPST_KG,BURN_FRLB,OP_NUM,IRR_SC,IRR_NO,IRR_SCA,IRR_NOA)
//                                 SELECT TOP 1  SUBBASIN,HRU,LANDUSE,SOIL, SLOPE_CD, CROP, YEAR, MONTH, DAY, HUSC, MGT_OP, HEATUNITS, PLANT_ID, CURYR_MAT, LAI_INIT,	 BIO_INIT,
//				                               HI_TARG, BIO_TARG,CNOP, IRR_AMT, FERT_ID,FRT_KG,FRT_SURFACE,PEST_ID,PST_KG,TILLAGE_ID,HARVEFF,HI_OVR,GRZ_DAYS,MANURE_ID,BIO_EAT,
//				                               BIO_TRMP,MANURE_KG,WSTRS_ID,AUTO_WSTRS,AFERT_ID,AUTO_NSTRS,AUTO_NAPP,AUTO_NYR,AUTO_EFF,AFRT_SURFACE,SWEEPEFF,FR_CURB,IMP_TRIG,
//				                               FERT_DAYS,CFRT_ID,IFRT_FREQ,CFRT_KG, PST_DEP,IHV_GBM,IRR_SALT,IRR_EFM,IRR_SQ,IRR_EFF,IRR_MX,IRR_ASQ, CPST_ID,PEST_DAYS,IPEST_FREQ,
//				                               CPST_KG,BURN_FRLB,OP_NUM,IRR_SC,IRR_NO,IRR_SCA,IRR_NOA
//	                             FROM mgt2 WHERE SUBBASIN = " + subbasinID + "  AND HRU = " + hruID + " AND MGT_OP = " + MGT_OP;
         
            DataTable hru_info = getLandUse_Soil_SlopeBySUBAndHRU(subbasinID, hruID);  //获得hru的三项信息
            string land_use = hru_info.Rows[0][0].ToString();
            string soil = hru_info.Rows[0][1].ToString();
            string slope = hru_info.Rows[0][2].ToString();                                    
            string sql=@"INSERT INTO mgt2(SUBBASIN,HRU,LANDUSE,SOIL, SLOPE_CD, CROP, [YEAR], [MONTH], [DAY], HUSC, 
                 MGT_OP,HEATUNITS, PLANT_ID, CURYR_MAT, LAI_INIT,BIO_INIT,HI_TARG, BIO_TARG,CNOP, IRR_AMT,
                 FERT_ID,FRT_KG,FRT_SURFACE,PEST_ID,PST_KG,TILLAGE_ID,HARVEFF,HI_OVR,GRZ_DAYS,MANURE_ID,
                 BIO_EAT,BIO_TRMP,MANURE_KG,WSTRS_ID,AUTO_WSTRS,AFERT_ID,AUTO_NSTRS,AUTO_NAPP,AUTO_NYR,AUTO_EFF,
                 AFRT_SURFACE,SWEEPEFF,FR_CURB,IMP_TRIG,FERT_DAYS,CFRT_ID,IFRT_FREQ,CFRT_KG, PST_DEP,IHV_GBM,
                 IRR_SALT,IRR_EFM,IRR_SQ,IRR_EFF,IRR_MX,IRR_ASQ, CPST_ID,PEST_DAYS,IPEST_FREQ,CPST_KG,
                 BURN_FRLB,OP_NUM,IRR_SC,IRR_NO,IRR_SCA,IRR_NOA) 
          values("+subbasinID+","+hruID+",'"+land_use+"','"+soil+"','"+slope+"','',1,1,1,0,"+
                 "1,0,0,0,0,0,0,0,0,0,"+
                 "0,0,0,0,0,0,0,0,0,0,"+
                 "0,0,0,0,0,0,0,0,0,0,"+
                 "0,0,0,0,0,0,0,0,0,0,"+
                 "0,0,0,0,0,0,0,0,0,0,"+
                 "0,0,0,0,0,0)";
            int n = MGTHelper.ExcuteSql(sql);
            //获取新加数据的OID编号
            sql = "select oid from mgt2 where subbasin = " + subbasinID + " and hru = " + hruID + " order by oid desc";
            DataTable dt = MGTHelper.GetDataTableFromDB(sql);
            int OID = Convert.ToInt32(dt.Rows[0][0]);
            //根据MGT_OP和OID更新数据
            if (MGT_OP == 1)    //种植
            {
                sql = @"update mgt2 set CROP = '" + mgt.crop + "',[YEAR] = 1" + ",[MONTH] = " + mgt.plant_month + ",[DAY] = " + mgt.plant_day + ",HUSC = 0" + ",MGT_OP = " + mgt.plant_mgt_op + ",HEATUNITS = " + mgt.heat_units + ",PLANT_ID = " + mgt.plant_id +
                       ",CURYR_MAT = " + mgt.curyr_mat + ",LAI_INIT = " + mgt.lai_init + ",HI_TARG = " + mgt.hi_targ + ",BIO_TARG = " + mgt.bio_targ + ",CNOP = " + mgt.plant_cnop + " WHERE OID =" + OID + " and subbasin = " + subbasinID + " and hru =" + hruID;
                n = MGTHelper.ExcuteSql(sql);
            }
            else if (MGT_OP == 2)   //灌溉
            {
                sql = @"update mgt2 set CROP = null,[YEAR] = 1" + ",[MONTH] = " + mgt.irr_month + ",[DAY] = " + mgt.irr_day + ",HUSC = " + mgt.irr_husc + ",MGT_OP = " + mgt.irr_mgt_op + ",IRR_AMT = " + mgt.irr_amt + ",IRR_SALT = " + mgt.irr_salt + ",IRR_EFM = " + mgt.irr_efm + ",IRR_SQ = " +
                       mgt.irr_sq + ",IRR_SC = " + mgt.irr_sc + ",IRR_NO = " + mgt.irr_no + " WHERE OID =" + OID + " and subbasin = " + subbasinID + " and hru =" + hruID;
                n = MGTHelper.ExcuteSql(sql);
            }
            else if (MGT_OP == 3)   //施肥
            {
                sql = @"update mgt2 set CROP = null,[YEAR] = 1" + ",[MONTH] = " + mgt.frt_month + ",[DAY] = " + mgt.frt_day + ",HUSC = " + mgt.frt_husc + ",MGT_OP =" + mgt.frt_mgt_op + ",FERT_ID = " + mgt.fert_id + ",FRT_KG = " + mgt.frt_kg + ",FRT_SURFACE = " + mgt.frt_surface
                      + " where OID = " + OID + " and subbasin = " + subbasinID + "  and hru = " + hruID;
                n = MGTHelper.ExcuteSql(sql);
            }
            else if (MGT_OP == 5)     //收割
            {
                sql = @"update mgt2 set CROP = null,[YEAR] = 1" + ",[MONTH] = " + mgt.harv_month + ",[DAY] = " + mgt.harv_day + ",HUSC = " + mgt.harv_husc + ",MGT_OP = " + mgt.harv_mgt_op + ",CNOP = " + mgt.harv_cnop
                      + "  where OID = " + OID + " and subbasin = " + subbasinID + "  and hru = " + hruID;
                n = MGTHelper.ExcuteSql(sql);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewMgt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                AccessHelper helper = new AccessHelper();
                DataTable dt;
                int Month = Convert.ToInt32(dataGridViewMgt.CurrentRow.Cells["month"].Value.ToString());
                int Day = Convert.ToInt32(dataGridViewMgt.CurrentRow.Cells["day"].Value.ToString());
                int MGT_OP = GetMGT_OPByName(dataGridViewMgt.CurrentRow.Cells["operation"].Value.ToString());
                if (MGT_OP == 1)    //种植
                {
                    tabControlMgt.SelectedIndex = 0;
                    string sql = @"select MONTH,DAY,MGT_OP,HEATUNITS,PLANT_ID,CURYR_MAT,LAI_INIT,BIO_INIT,HI_TARG,BIO_TARG,CNOP from mgt2 
                           WHERE SUBBASIN = " + subbasinId + " AND HRU = 1 " + "AND MONTH = " + Month + "  AND DAY = " + Day + " AND MGT_OP = " + MGT_OP;
                    dt = helper.GetDataTableFromDB(sql);
                    if (dt != null)
                    {
                        PLANT_MONTH.Text = dt.Rows[0][0].ToString();
                        PLANT_DAY.Text = dt.Rows[0][1].ToString();
                        PLANT_ID.Text = dt.Rows[0][4].ToString()+","+getPlantNameByID(Convert.ToInt32(dt.Rows[0][4].ToString()));
                        CURYR_MAT.Text = dt.Rows[0][5].ToString();

                        PLANT_HEAT_UNITS.Text = dt.Rows[0][3].ToString();
                        BIO_INIT.Text = dt.Rows[0][7].ToString();
                        HI_TARG.Text = dt.Rows[0][8].ToString();
                        LAI_INIT.Text = dt.Rows[0][6].ToString();

                        BIO_TARG.Text = dt.Rows[0][9].ToString();
                        PLANT_CNOP.Text = dt.Rows[0][10].ToString();
                    }
                }
                else if (MGT_OP == 2)
                {
                    tabControlMgt.SelectedIndex = 1;
                    string sql = @"select MONTH,DAY,MGT_OP,IRR_AMT,IRR_SALT,IRR_EFM,IRR_SQ,IRR_SC,IRR_NO from mgt2 
                             WHERE SUBBASIN = " + subbasinId + " AND HRU = 1 " + "AND MONTH = " + Month + "  AND DAY = " + Day + " AND MGT_OP = " + MGT_OP;
                    dt = helper.GetDataTableFromDB(sql);
                    if (dt != null)
                    {
                        IRR_MONTH.Text = dt.Rows[0][0].ToString();
                        IRR_DAY.Text = dt.Rows[0][1].ToString();
                        IRR_AMT.Text = dt.Rows[0][3].ToString();
                        IRR_SALT.Text = dt.Rows[0][4].ToString();
                        IRR_EFM.Text = dt.Rows[0][5].ToString();
                        IRR_SQ.Text = dt.Rows[0][6].ToString();
                        IRR_SC.Text = dt.Rows[0][7].ToString();
                        IRR_NO.Text = dt.Rows[0][8].ToString();
                    }
                }
                else if (MGT_OP == 3)
                {
                    tabControlMgt.SelectedIndex = 2;
                    string sql = @"select MONTH,DAY,MGT_OP,FERT_ID,FRT_KG,FRT_SURFACE from mgt2
                             WHERE SUBBASIN = " + subbasinId + " AND HRU = 1 " + "AND MONTH = " + Month + "  AND DAY = " + Day + " AND MGT_OP = " + MGT_OP;
                    dt = helper.GetDataTableFromDB(sql);
                    if (dt != null)
                    {
                        FRT_MONTH.Text = dt.Rows[0][0].ToString();
                        FRT_DAY.Text = dt.Rows[0][1].ToString();
                        FERT_ID.Text =dt.Rows[0][3].ToString()+","+getFertNameByID(Convert.ToInt32(dt.Rows[0][3].ToString()));
                        FRT_KG.Text = dt.Rows[0][4].ToString();
                        FRT_SURFACE.Text = dt.Rows[0][5].ToString();

                    }
                }
                else if (MGT_OP == 5)
                {
                    tabControlMgt.SelectedIndex = 3;
                    string sql = @"select MONTH,DAY,MGT_OP,CNOP from mgt2 
                             WHERE SUBBASIN = " + subbasinId + " AND HRU = 1 " + "AND MONTH = " + Month + "  AND DAY = " + Day + " AND MGT_OP = " + MGT_OP;
                    dt = helper.GetDataTableFromDB(sql);
                    if (dt != null)
                    {
                        HARV_MONTH.Text = dt.Rows[0][0].ToString();
                        HARV_DAY.Text = dt.Rows[0][1].ToString();
                        HARV_CNOP.Text = dt.Rows[0][3].ToString();
                        
                    }
                }
                else
                {
                    MessageBox.Show("错误");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private int GetMGT_OPByName(string mgtName)
        {
            int MGT_OP=0;
            AccessHelper helper = new AccessHelper();
            string sql = "select OPNUM from mgttype where OP = '"+mgtName+"'";
            DataTable dt = helper.GetDataTableFromDB(sql);
            if (dt == null)
                MGT_OP = 0;
            else
                MGT_OP = Convert.ToInt32(dt.Rows[0][0]);
            return MGT_OP;
        }

    }
}
