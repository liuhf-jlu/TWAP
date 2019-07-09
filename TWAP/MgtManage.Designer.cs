namespace TWAP
{
    partial class MgtManage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MgtManage));
            this.dataGridViewMgt = new System.Windows.Forms.DataGridView();
            this.btnStartEdit = new System.Windows.Forms.Button();
            this.btnDeleteOperation = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSaveEdit = new System.Windows.Forms.Button();
            this.tabControlMgt = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.PLANT_ID = new System.Windows.Forms.ComboBox();
            this.LAI_INIT = new System.Windows.Forms.TextBox();
            this.PLANT_DAY = new System.Windows.Forms.ComboBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.PLANT_CNOP = new System.Windows.Forms.TextBox();
            this.BIO_TARG = new System.Windows.Forms.TextBox();
            this.HI_TARG = new System.Windows.Forms.TextBox();
            this.BIO_INIT = new System.Windows.Forms.TextBox();
            this.PLANT_HEAT_UNITS = new System.Windows.Forms.TextBox();
            this.CURYR_MAT = new System.Windows.Forms.TextBox();
            this.PLANT_MONTH = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.IRR_AMT = new System.Windows.Forms.TextBox();
            this.IRR_NO = new System.Windows.Forms.TextBox();
            this.IRR_SC = new System.Windows.Forms.TextBox();
            this.IRR_SQ = new System.Windows.Forms.TextBox();
            this.IRR_EFM = new System.Windows.Forms.TextBox();
            this.IRR_SALT = new System.Windows.Forms.TextBox();
            this.IRR_DAY = new System.Windows.Forms.ComboBox();
            this.IRR_MONTH = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.FERT_ID = new System.Windows.Forms.ComboBox();
            this.FRT_SURFACE = new System.Windows.Forms.TextBox();
            this.FRT_KG = new System.Windows.Forms.TextBox();
            this.FRT_DAY = new System.Windows.Forms.ComboBox();
            this.FRT_MONTH = new System.Windows.Forms.ComboBox();
            this.lab5 = new System.Windows.Forms.Label();
            this.lab4 = new System.Windows.Forms.Label();
            this.lab3 = new System.Windows.Forms.Label();
            this.lab2 = new System.Windows.Forms.Label();
            this.lab1 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.HARV_CNOP = new System.Windows.Forms.TextBox();
            this.HARV_DAY = new System.Windows.Forms.ComboBox();
            this.HARV_MONTH = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAddOperation = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.statusStripMgt = new System.Windows.Forms.StatusStrip();
            this.label = new System.Windows.Forms.ToolStripStatusLabel();
            this.MgtMessage = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMgt)).BeginInit();
            this.tabControlMgt.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.statusStripMgt.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewMgt
            // 
            this.dataGridViewMgt.AllowUserToResizeRows = false;
            this.dataGridViewMgt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMgt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridViewMgt.Location = new System.Drawing.Point(18, 12);
            this.dataGridViewMgt.Name = "dataGridViewMgt";
            this.dataGridViewMgt.RowTemplate.Height = 23;
            this.dataGridViewMgt.Size = new System.Drawing.Size(733, 211);
            this.dataGridViewMgt.TabIndex = 14;
            this.dataGridViewMgt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMgt_CellClick);
            // 
            // btnStartEdit
            // 
            this.btnStartEdit.Location = new System.Drawing.Point(31, 487);
            this.btnStartEdit.Name = "btnStartEdit";
            this.btnStartEdit.Size = new System.Drawing.Size(94, 36);
            this.btnStartEdit.TabIndex = 11;
            this.btnStartEdit.Text = "进入编辑状态";
            this.btnStartEdit.UseVisualStyleBackColor = true;
            this.btnStartEdit.Click += new System.EventHandler(this.btnEditOperation_Click);
            // 
            // btnDeleteOperation
            // 
            this.btnDeleteOperation.Location = new System.Drawing.Point(375, 487);
            this.btnDeleteOperation.Name = "btnDeleteOperation";
            this.btnDeleteOperation.Size = new System.Drawing.Size(94, 36);
            this.btnDeleteOperation.TabIndex = 12;
            this.btnDeleteOperation.Text = "删除操作";
            this.btnDeleteOperation.UseVisualStyleBackColor = true;
            this.btnDeleteOperation.Click += new System.EventHandler(this.btnDeleteOperation_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(639, 487);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 36);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSaveEdit
            // 
            this.btnSaveEdit.Location = new System.Drawing.Point(494, 487);
            this.btnSaveEdit.Name = "btnSaveEdit";
            this.btnSaveEdit.Size = new System.Drawing.Size(112, 36);
            this.btnSaveEdit.TabIndex = 18;
            this.btnSaveEdit.Text = "保存编辑";
            this.btnSaveEdit.UseVisualStyleBackColor = true;
            this.btnSaveEdit.Click += new System.EventHandler(this.btnSaveEdit_Click);
            // 
            // tabControlMgt
            // 
            this.tabControlMgt.Controls.Add(this.tabPage1);
            this.tabControlMgt.Controls.Add(this.tabPage2);
            this.tabControlMgt.Controls.Add(this.tabPage3);
            this.tabControlMgt.Controls.Add(this.tabPage4);
            this.tabControlMgt.Location = new System.Drawing.Point(18, 229);
            this.tabControlMgt.Name = "tabControlMgt";
            this.tabControlMgt.SelectedIndex = 0;
            this.tabControlMgt.Size = new System.Drawing.Size(737, 241);
            this.tabControlMgt.TabIndex = 19;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.PLANT_ID);
            this.tabPage1.Controls.Add(this.LAI_INIT);
            this.tabPage1.Controls.Add(this.PLANT_DAY);
            this.tabPage1.Controls.Add(this.label28);
            this.tabPage1.Controls.Add(this.label32);
            this.tabPage1.Controls.Add(this.PLANT_CNOP);
            this.tabPage1.Controls.Add(this.BIO_TARG);
            this.tabPage1.Controls.Add(this.HI_TARG);
            this.tabPage1.Controls.Add(this.BIO_INIT);
            this.tabPage1.Controls.Add(this.PLANT_HEAT_UNITS);
            this.tabPage1.Controls.Add(this.CURYR_MAT);
            this.tabPage1.Controls.Add(this.PLANT_MONTH);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.label26);
            this.tabPage1.Controls.Add(this.label27);
            this.tabPage1.Controls.Add(this.label29);
            this.tabPage1.Controls.Add(this.label30);
            this.tabPage1.Controls.Add(this.label31);
            this.tabPage1.Controls.Add(this.label33);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(729, 215);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "种植操作";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // PLANT_ID
            // 
            this.PLANT_ID.FormattingEnabled = true;
            this.PLANT_ID.Location = new System.Drawing.Point(365, 37);
            this.PLANT_ID.Name = "PLANT_ID";
            this.PLANT_ID.Size = new System.Drawing.Size(93, 20);
            this.PLANT_ID.TabIndex = 48;
            // 
            // LAI_INIT
            // 
            this.LAI_INIT.Location = new System.Drawing.Point(535, 88);
            this.LAI_INIT.Name = "LAI_INIT";
            this.LAI_INIT.Size = new System.Drawing.Size(93, 21);
            this.LAI_INIT.TabIndex = 47;
            this.LAI_INIT.Text = "0";
            // 
            // PLANT_DAY
            // 
            this.PLANT_DAY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PLANT_DAY.FormattingEnabled = true;
            this.PLANT_DAY.Location = new System.Drawing.Point(195, 34);
            this.PLANT_DAY.Name = "PLANT_DAY";
            this.PLANT_DAY.Size = new System.Drawing.Size(93, 20);
            this.PLANT_DAY.TabIndex = 46;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(533, 67);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(125, 12);
            this.label28.TabIndex = 45;
            this.label28.Text = "页面积指数(LAI_INIT)";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(193, 15);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(29, 12);
            this.label32.TabIndex = 44;
            this.label32.Text = "日期";
            // 
            // PLANT_CNOP
            // 
            this.PLANT_CNOP.Location = new System.Drawing.Point(193, 147);
            this.PLANT_CNOP.Name = "PLANT_CNOP";
            this.PLANT_CNOP.Size = new System.Drawing.Size(93, 21);
            this.PLANT_CNOP.TabIndex = 42;
            this.PLANT_CNOP.Text = "0";
            // 
            // BIO_TARG
            // 
            this.BIO_TARG.Location = new System.Drawing.Point(25, 147);
            this.BIO_TARG.Name = "BIO_TARG";
            this.BIO_TARG.Size = new System.Drawing.Size(93, 21);
            this.BIO_TARG.TabIndex = 41;
            this.BIO_TARG.Text = "0";
            // 
            // HI_TARG
            // 
            this.HI_TARG.Location = new System.Drawing.Point(364, 87);
            this.HI_TARG.Name = "HI_TARG";
            this.HI_TARG.Size = new System.Drawing.Size(93, 21);
            this.HI_TARG.TabIndex = 40;
            this.HI_TARG.Text = "0";
            // 
            // BIO_INIT
            // 
            this.BIO_INIT.Location = new System.Drawing.Point(193, 90);
            this.BIO_INIT.Name = "BIO_INIT";
            this.BIO_INIT.Size = new System.Drawing.Size(93, 21);
            this.BIO_INIT.TabIndex = 39;
            this.BIO_INIT.Text = "0";
            // 
            // PLANT_HEAT_UNITS
            // 
            this.PLANT_HEAT_UNITS.Location = new System.Drawing.Point(25, 90);
            this.PLANT_HEAT_UNITS.Name = "PLANT_HEAT_UNITS";
            this.PLANT_HEAT_UNITS.Size = new System.Drawing.Size(93, 21);
            this.PLANT_HEAT_UNITS.TabIndex = 38;
            this.PLANT_HEAT_UNITS.Text = "0";
            // 
            // CURYR_MAT
            // 
            this.CURYR_MAT.Location = new System.Drawing.Point(535, 37);
            this.CURYR_MAT.Name = "CURYR_MAT";
            this.CURYR_MAT.Size = new System.Drawing.Size(93, 21);
            this.CURYR_MAT.TabIndex = 37;
            this.CURYR_MAT.Text = "0";
            // 
            // PLANT_MONTH
            // 
            this.PLANT_MONTH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PLANT_MONTH.FormattingEnabled = true;
            this.PLANT_MONTH.Location = new System.Drawing.Point(25, 34);
            this.PLANT_MONTH.Name = "PLANT_MONTH";
            this.PLANT_MONTH.Size = new System.Drawing.Size(93, 20);
            this.PLANT_MONTH.TabIndex = 36;
            this.PLANT_MONTH.SelectedIndexChanged += new System.EventHandler(this.PLANT_MONTH_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(191, 123);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(119, 12);
            this.label15.TabIndex = 35;
            this.label15.Text = "SCS径流曲线数(CNOP)";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(23, 123);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(113, 12);
            this.label17.TabIndex = 34;
            this.label17.Text = "目标干重(BIO_TARG)";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(362, 66);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(131, 12);
            this.label26.TabIndex = 33;
            this.label26.Text = "目标收获指数(HI_TARG)";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(193, 66);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(113, 12);
            this.label27.TabIndex = 32;
            this.label27.Text = "初始干重(BIO_INIT)";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(23, 66);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(131, 12);
            this.label29.TabIndex = 31;
            this.label29.Text = "所需总热（HeatUnits) ";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(533, 16);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(107, 12);
            this.label30.TabIndex = 30;
            this.label30.Text = "树龄（CURYR_MAT）";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(362, 16);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(125, 12);
            this.label31.TabIndex = 29;
            this.label31.Text = "植物代码（PLANT_ID）";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(23, 19);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(29, 12);
            this.label33.TabIndex = 28;
            this.label33.Text = "月份";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.IRR_AMT);
            this.tabPage2.Controls.Add(this.IRR_NO);
            this.tabPage2.Controls.Add(this.IRR_SC);
            this.tabPage2.Controls.Add(this.IRR_SQ);
            this.tabPage2.Controls.Add(this.IRR_EFM);
            this.tabPage2.Controls.Add(this.IRR_SALT);
            this.tabPage2.Controls.Add(this.IRR_DAY);
            this.tabPage2.Controls.Add(this.IRR_MONTH);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.label21);
            this.tabPage2.Controls.Add(this.label22);
            this.tabPage2.Controls.Add(this.label23);
            this.tabPage2.Controls.Add(this.label24);
            this.tabPage2.Controls.Add(this.label25);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(729, 215);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "灌溉操作";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // IRR_AMT
            // 
            this.IRR_AMT.Location = new System.Drawing.Point(371, 33);
            this.IRR_AMT.Name = "IRR_AMT";
            this.IRR_AMT.Size = new System.Drawing.Size(147, 21);
            this.IRR_AMT.TabIndex = 43;
            this.IRR_AMT.Text = "0";
            // 
            // IRR_NO
            // 
            this.IRR_NO.Location = new System.Drawing.Point(548, 98);
            this.IRR_NO.Name = "IRR_NO";
            this.IRR_NO.Size = new System.Drawing.Size(171, 21);
            this.IRR_NO.TabIndex = 42;
            this.IRR_NO.Text = "0";
            // 
            // IRR_SC
            // 
            this.IRR_SC.Location = new System.Drawing.Point(371, 98);
            this.IRR_SC.Name = "IRR_SC";
            this.IRR_SC.Size = new System.Drawing.Size(147, 21);
            this.IRR_SC.TabIndex = 41;
            this.IRR_SC.Text = "0";
            // 
            // IRR_SQ
            // 
            this.IRR_SQ.Location = new System.Drawing.Point(198, 98);
            this.IRR_SQ.Name = "IRR_SQ";
            this.IRR_SQ.Size = new System.Drawing.Size(121, 21);
            this.IRR_SQ.TabIndex = 40;
            this.IRR_SQ.Text = "0";
            // 
            // IRR_EFM
            // 
            this.IRR_EFM.Location = new System.Drawing.Point(8, 98);
            this.IRR_EFM.Name = "IRR_EFM";
            this.IRR_EFM.Size = new System.Drawing.Size(132, 21);
            this.IRR_EFM.TabIndex = 39;
            this.IRR_EFM.Text = "0";
            // 
            // IRR_SALT
            // 
            this.IRR_SALT.Location = new System.Drawing.Point(548, 32);
            this.IRR_SALT.Name = "IRR_SALT";
            this.IRR_SALT.Size = new System.Drawing.Size(171, 21);
            this.IRR_SALT.TabIndex = 38;
            this.IRR_SALT.Text = "0";
            // 
            // IRR_DAY
            // 
            this.IRR_DAY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IRR_DAY.FormattingEnabled = true;
            this.IRR_DAY.Location = new System.Drawing.Point(198, 33);
            this.IRR_DAY.Name = "IRR_DAY";
            this.IRR_DAY.Size = new System.Drawing.Size(121, 20);
            this.IRR_DAY.TabIndex = 36;
            // 
            // IRR_MONTH
            // 
            this.IRR_MONTH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IRR_MONTH.FormattingEnabled = true;
            this.IRR_MONTH.Location = new System.Drawing.Point(8, 33);
            this.IRR_MONTH.Name = "IRR_MONTH";
            this.IRR_MONTH.Size = new System.Drawing.Size(134, 20);
            this.IRR_MONTH.TabIndex = 37;
            this.IRR_MONTH.SelectedIndexChanged += new System.EventHandler(this.IRR_MONTH_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(546, 83);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(95, 12);
            this.label18.TabIndex = 35;
            this.label18.Text = "水源位置 IRR_NO";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(369, 83);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(95, 12);
            this.label19.TabIndex = 34;
            this.label19.Text = "水源代码 IRR_SC";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(196, 83);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(107, 12);
            this.label20.TabIndex = 33;
            this.label20.Text = "地表径流比 IRR_SQ";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 83);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(101, 12);
            this.label21.TabIndex = 32;
            this.label21.Text = "灌溉效率 IRR_EFM";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(546, 18);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(173, 12);
            this.label22.TabIndex = 31;
            this.label22.Text = "灌溉水的盐度 IRR_SALT(mg/kg)";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(369, 18);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(131, 12);
            this.label23.TabIndex = 30;
            this.label23.Text = "灌溉水深 IRR_AMT (mm)";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(196, 18);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(29, 12);
            this.label24.TabIndex = 29;
            this.label24.Text = "日期";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(6, 18);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(35, 12);
            this.label25.TabIndex = 28;
            this.label25.Text = " 月份";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.FERT_ID);
            this.tabPage3.Controls.Add(this.FRT_SURFACE);
            this.tabPage3.Controls.Add(this.FRT_KG);
            this.tabPage3.Controls.Add(this.FRT_DAY);
            this.tabPage3.Controls.Add(this.FRT_MONTH);
            this.tabPage3.Controls.Add(this.lab5);
            this.tabPage3.Controls.Add(this.lab4);
            this.tabPage3.Controls.Add(this.lab3);
            this.tabPage3.Controls.Add(this.lab2);
            this.tabPage3.Controls.Add(this.lab1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(729, 215);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "施肥操作";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // FERT_ID
            // 
            this.FERT_ID.FormattingEnabled = true;
            this.FERT_ID.Location = new System.Drawing.Point(18, 105);
            this.FERT_ID.Name = "FERT_ID";
            this.FERT_ID.Size = new System.Drawing.Size(121, 20);
            this.FERT_ID.TabIndex = 29;
            // 
            // FRT_SURFACE
            // 
            this.FRT_SURFACE.Location = new System.Drawing.Point(413, 104);
            this.FRT_SURFACE.Name = "FRT_SURFACE";
            this.FRT_SURFACE.Size = new System.Drawing.Size(135, 21);
            this.FRT_SURFACE.TabIndex = 27;
            this.FRT_SURFACE.Text = "0";
            // 
            // FRT_KG
            // 
            this.FRT_KG.Location = new System.Drawing.Point(224, 104);
            this.FRT_KG.Name = "FRT_KG";
            this.FRT_KG.Size = new System.Drawing.Size(121, 21);
            this.FRT_KG.TabIndex = 28;
            this.FRT_KG.Text = "0";
            // 
            // FRT_DAY
            // 
            this.FRT_DAY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FRT_DAY.FormattingEnabled = true;
            this.FRT_DAY.Location = new System.Drawing.Point(224, 27);
            this.FRT_DAY.Name = "FRT_DAY";
            this.FRT_DAY.Size = new System.Drawing.Size(121, 20);
            this.FRT_DAY.TabIndex = 25;
            // 
            // FRT_MONTH
            // 
            this.FRT_MONTH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FRT_MONTH.FormattingEnabled = true;
            this.FRT_MONTH.Location = new System.Drawing.Point(18, 27);
            this.FRT_MONTH.Name = "FRT_MONTH";
            this.FRT_MONTH.Size = new System.Drawing.Size(121, 20);
            this.FRT_MONTH.TabIndex = 26;
            this.FRT_MONTH.SelectedIndexChanged += new System.EventHandler(this.FRT_MONTH_SelectedIndexChanged);
            // 
            // lab5
            // 
            this.lab5.AutoSize = true;
            this.lab5.Location = new System.Drawing.Point(411, 82);
            this.lab5.Name = "lab5";
            this.lab5.Size = new System.Drawing.Size(137, 12);
            this.lab5.TabIndex = 20;
            this.lab5.Text = "肥料利用率 FRT_SURFACE";
            // 
            // lab4
            // 
            this.lab4.AutoSize = true;
            this.lab4.Location = new System.Drawing.Point(222, 82);
            this.lab4.Name = "lab4";
            this.lab4.Size = new System.Drawing.Size(83, 12);
            this.lab4.TabIndex = 21;
            this.lab4.Text = "施肥量 FRT_KG";
            // 
            // lab3
            // 
            this.lab3.AutoSize = true;
            this.lab3.Location = new System.Drawing.Point(16, 82);
            this.lab3.Name = "lab3";
            this.lab3.Size = new System.Drawing.Size(113, 12);
            this.lab3.TabIndex = 22;
            this.lab3.Text = "肥料识别码 FERT_ID";
            // 
            // lab2
            // 
            this.lab2.AutoSize = true;
            this.lab2.Location = new System.Drawing.Point(222, 9);
            this.lab2.Name = "lab2";
            this.lab2.Size = new System.Drawing.Size(29, 12);
            this.lab2.TabIndex = 23;
            this.lab2.Text = "日期";
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.Location = new System.Drawing.Point(16, 9);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(29, 12);
            this.lab1.TabIndex = 24;
            this.lab1.Text = "月份";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.HARV_CNOP);
            this.tabPage4.Controls.Add(this.HARV_DAY);
            this.tabPage4.Controls.Add(this.HARV_MONTH);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(729, 215);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "收割操作";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // HARV_CNOP
            // 
            this.HARV_CNOP.Location = new System.Drawing.Point(16, 98);
            this.HARV_CNOP.Name = "HARV_CNOP";
            this.HARV_CNOP.Size = new System.Drawing.Size(150, 21);
            this.HARV_CNOP.TabIndex = 19;
            this.HARV_CNOP.Text = "0";
            // 
            // HARV_DAY
            // 
            this.HARV_DAY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HARV_DAY.FormattingEnabled = true;
            this.HARV_DAY.Location = new System.Drawing.Point(209, 44);
            this.HARV_DAY.Name = "HARV_DAY";
            this.HARV_DAY.Size = new System.Drawing.Size(121, 20);
            this.HARV_DAY.TabIndex = 17;
            // 
            // HARV_MONTH
            // 
            this.HARV_MONTH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HARV_MONTH.FormattingEnabled = true;
            this.HARV_MONTH.Location = new System.Drawing.Point(16, 39);
            this.HARV_MONTH.Name = "HARV_MONTH";
            this.HARV_MONTH.Size = new System.Drawing.Size(150, 20);
            this.HARV_MONTH.TabIndex = 18;
            this.HARV_MONTH.SelectedIndexChanged += new System.EventHandler(this.HARV_MONTH_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "SCS径流曲线数 CNOP";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(207, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 15;
            this.label7.Text = "日期";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 16;
            this.label8.Text = "月份";
            // 
            // btnAddOperation
            // 
            this.btnAddOperation.Location = new System.Drawing.Point(265, 487);
            this.btnAddOperation.Name = "btnAddOperation";
            this.btnAddOperation.Size = new System.Drawing.Size(87, 36);
            this.btnAddOperation.TabIndex = 20;
            this.btnAddOperation.Text = "添加操作";
            this.btnAddOperation.UseVisualStyleBackColor = true;
            this.btnAddOperation.Click += new System.EventHandler(this.btnAddOperation_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(163, 487);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(83, 36);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "更新参数";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // statusStripMgt
            // 
            this.statusStripMgt.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.label,
            this.MgtMessage});
            this.statusStripMgt.Location = new System.Drawing.Point(0, 546);
            this.statusStripMgt.Name = "statusStripMgt";
            this.statusStripMgt.Size = new System.Drawing.Size(789, 22);
            this.statusStripMgt.TabIndex = 22;
            this.statusStripMgt.Text = "statusStrip1";
            // 
            // label
            // 
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(68, 17);
            this.label.Text = "提示信息：";
            // 
            // MgtMessage
            // 
            this.MgtMessage.Name = "MgtMessage";
            this.MgtMessage.Size = new System.Drawing.Size(0, 17);
            // 
            // MgtManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 568);
            this.Controls.Add(this.statusStripMgt);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAddOperation);
            this.Controls.Add(this.tabControlMgt);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSaveEdit);
            this.Controls.Add(this.dataGridViewMgt);
            this.Controls.Add(this.btnStartEdit);
            this.Controls.Add(this.btnDeleteOperation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MgtManage";
            this.Text = "面源管理";
            this.Load += new System.EventHandler(this.MgtManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMgt)).EndInit();
            this.tabControlMgt.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.statusStripMgt.ResumeLayout(false);
            this.statusStripMgt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMgt;
        private System.Windows.Forms.Button btnStartEdit;
        private System.Windows.Forms.Button btnDeleteOperation;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSaveEdit;
        private System.Windows.Forms.TabControl tabControlMgt;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox LAI_INIT;
        private System.Windows.Forms.ComboBox PLANT_DAY;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox PLANT_CNOP;
        private System.Windows.Forms.TextBox BIO_TARG;
        private System.Windows.Forms.TextBox HI_TARG;
        private System.Windows.Forms.TextBox BIO_INIT;
        private System.Windows.Forms.TextBox PLANT_HEAT_UNITS;
        private System.Windows.Forms.TextBox CURYR_MAT;
        private System.Windows.Forms.ComboBox PLANT_MONTH;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox IRR_AMT;
        private System.Windows.Forms.TextBox IRR_NO;
        private System.Windows.Forms.TextBox IRR_SC;
        private System.Windows.Forms.TextBox IRR_SQ;
        private System.Windows.Forms.TextBox IRR_EFM;
        private System.Windows.Forms.TextBox IRR_SALT;
        private System.Windows.Forms.ComboBox IRR_DAY;
        private System.Windows.Forms.ComboBox IRR_MONTH;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox FRT_SURFACE;
        private System.Windows.Forms.TextBox FRT_KG;
        private System.Windows.Forms.ComboBox FRT_DAY;
        private System.Windows.Forms.ComboBox FRT_MONTH;
        private System.Windows.Forms.Label lab5;
        private System.Windows.Forms.Label lab4;
        private System.Windows.Forms.Label lab3;
        private System.Windows.Forms.Label lab2;
        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.TextBox HARV_CNOP;
        private System.Windows.Forms.ComboBox HARV_DAY;
        private System.Windows.Forms.ComboBox HARV_MONTH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAddOperation;
        private System.Windows.Forms.ComboBox PLANT_ID;
        private System.Windows.Forms.ComboBox FERT_ID;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.StatusStrip statusStripMgt;
        private System.Windows.Forms.ToolStripStatusLabel label;
        private System.Windows.Forms.ToolStripStatusLabel MgtMessage;
    }
}