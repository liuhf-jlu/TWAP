namespace TWAP
{
    partial class RunSwatModel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RunSwatModel));
            this.dtStartTime = new System.Windows.Forms.DateTimePicker();
            this.dtEndTime = new System.Windows.Forms.DateTimePicker();
            this.btnSetSWATModel = new System.Windows.Forms.Button();
            this.btnRunSWATModel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txNYSKIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbMaxDate = new System.Windows.Forms.Label();
            this.lbMinDate = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelRunMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnNotSelectAll = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.cbIWTR = new System.Windows.Forms.CheckBox();
            this.cbIMGT = new System.Windows.Forms.CheckBox();
            this.cbITEMP = new System.Windows.Forms.CheckBox();
            this.cbISNOW = new System.Windows.Forms.CheckBox();
            this.cbIHUMUS = new System.Windows.Forms.CheckBox();
            this.cbIA_B = new System.Windows.Forms.CheckBox();
            this.cbI_SUBW = new System.Windows.Forms.CheckBox();
            this.cbISOL = new System.Windows.Forms.CheckBox();
            this.cbISTO = new System.Windows.Forms.CheckBox();
            this.cbIPHR = new System.Windows.Forms.CheckBox();
            this.cbIPRP = new System.Windows.Forms.CheckBox();
            this.cbILOG = new System.Windows.Forms.CheckBox();
            this.cbOutputFileVariables = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rbYear = new System.Windows.Forms.RadioButton();
            this.rbMonth = new System.Windows.Forms.RadioButton();
            this.rbDay = new System.Windows.Forms.RadioButton();
            this.btnDefaultSettings = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtStartTime
            // 
            this.dtStartTime.Location = new System.Drawing.Point(63, 25);
            this.dtStartTime.Name = "dtStartTime";
            this.dtStartTime.Size = new System.Drawing.Size(200, 21);
            this.dtStartTime.TabIndex = 4;
            this.dtStartTime.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // dtEndTime
            // 
            this.dtEndTime.Location = new System.Drawing.Point(362, 25);
            this.dtEndTime.Name = "dtEndTime";
            this.dtEndTime.Size = new System.Drawing.Size(200, 21);
            this.dtEndTime.TabIndex = 5;
            this.dtEndTime.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // btnSetSWATModel
            // 
            this.btnSetSWATModel.Location = new System.Drawing.Point(259, 498);
            this.btnSetSWATModel.Name = "btnSetSWATModel";
            this.btnSetSWATModel.Size = new System.Drawing.Size(105, 38);
            this.btnSetSWATModel.TabIndex = 6;
            this.btnSetSWATModel.Text = "设置SWAT参数";
            this.btnSetSWATModel.UseVisualStyleBackColor = true;
            this.btnSetSWATModel.Click += new System.EventHandler(this.btnSetSWATModel_Click);
            // 
            // btnRunSWATModel
            // 
            this.btnRunSWATModel.Location = new System.Drawing.Point(395, 498);
            this.btnRunSWATModel.Name = "btnRunSWATModel";
            this.btnRunSWATModel.Size = new System.Drawing.Size(105, 38);
            this.btnRunSWATModel.TabIndex = 8;
            this.btnRunSWATModel.Text = "运行SWAT";
            this.btnRunSWATModel.UseVisualStyleBackColor = true;
            this.btnRunSWATModel.Click += new System.EventHandler(this.btnRunSWATModel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "开始日期";
            // 
            // txNYSKIP
            // 
            this.txNYSKIP.Location = new System.Drawing.Point(328, 31);
            this.txNYSKIP.Name = "txNYSKIP";
            this.txNYSKIP.Size = new System.Drawing.Size(57, 21);
            this.txNYSKIP.TabIndex = 11;
            this.txNYSKIP.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "结束日期";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "预热期";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(540, 498);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 38);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbMaxDate);
            this.groupBox1.Controls.Add(this.lbMinDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtEndTime);
            this.groupBox1.Controls.Add(this.dtStartTime);
            this.groupBox1.Location = new System.Drawing.Point(8, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(627, 86);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "选择模拟起止日期";
            // 
            // lbMaxDate
            // 
            this.lbMaxDate.AutoSize = true;
            this.lbMaxDate.ForeColor = System.Drawing.Color.Green;
            this.lbMaxDate.Location = new System.Drawing.Point(370, 53);
            this.lbMaxDate.Name = "lbMaxDate";
            this.lbMaxDate.Size = new System.Drawing.Size(71, 12);
            this.lbMaxDate.TabIndex = 14;
            this.lbMaxDate.Text = "Max Date = ";
            // 
            // lbMinDate
            // 
            this.lbMinDate.AutoSize = true;
            this.lbMinDate.ForeColor = System.Drawing.Color.Green;
            this.lbMinDate.Location = new System.Drawing.Point(63, 53);
            this.lbMinDate.Name = "lbMinDate";
            this.lbMinDate.Size = new System.Drawing.Size(71, 12);
            this.lbMinDate.TabIndex = 13;
            this.lbMinDate.Text = "Min Date = ";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelRunMessage});
            this.statusStrip1.Location = new System.Drawing.Point(0, 555);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(675, 22);
            this.statusStrip1.TabIndex = 18;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelRunMessage
            // 
            this.toolStripStatusLabelRunMessage.Name = "toolStripStatusLabelRunMessage";
            this.toolStripStatusLabelRunMessage.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabelRunMessage.Text = "toolStripStatusLabel1";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.panel1);
            this.groupBox4.Controls.Add(this.cbOutputFileVariables);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txNYSKIP);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.rbYear);
            this.groupBox4.Controls.Add(this.rbMonth);
            this.groupBox4.Controls.Add(this.rbDay);
            this.groupBox4.Location = new System.Drawing.Point(8, 122);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(627, 352);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "输出文件设置";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnNotSelectAll);
            this.panel1.Controls.Add(this.btnSelectAll);
            this.panel1.Controls.Add(this.cbIWTR);
            this.panel1.Controls.Add(this.cbIMGT);
            this.panel1.Controls.Add(this.cbITEMP);
            this.panel1.Controls.Add(this.cbISNOW);
            this.panel1.Controls.Add(this.cbIHUMUS);
            this.panel1.Controls.Add(this.cbIA_B);
            this.panel1.Controls.Add(this.cbI_SUBW);
            this.panel1.Controls.Add(this.cbISOL);
            this.panel1.Controls.Add(this.cbISTO);
            this.panel1.Controls.Add(this.cbIPHR);
            this.panel1.Controls.Add(this.cbIPRP);
            this.panel1.Controls.Add(this.cbILOG);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(46, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 223);
            this.panel1.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(16, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 14);
            this.label4.TabIndex = 42;
            this.label4.Text = "选择要输出的信息";
            // 
            // btnNotSelectAll
            // 
            this.btnNotSelectAll.Location = new System.Drawing.Point(429, 171);
            this.btnNotSelectAll.Name = "btnNotSelectAll";
            this.btnNotSelectAll.Size = new System.Drawing.Size(75, 32);
            this.btnNotSelectAll.TabIndex = 41;
            this.btnNotSelectAll.Text = "取消全选";
            this.btnNotSelectAll.UseVisualStyleBackColor = true;
            this.btnNotSelectAll.Click += new System.EventHandler(this.btnNotSelectAll_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new System.Drawing.Point(345, 171);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(63, 32);
            this.btnSelectAll.TabIndex = 40;
            this.btnSelectAll.Text = "全选";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // cbIWTR
            // 
            this.cbIWTR.AutoSize = true;
            this.cbIWTR.Location = new System.Drawing.Point(366, 132);
            this.cbIWTR.Name = "cbIWTR";
            this.cbIWTR.Size = new System.Drawing.Size(120, 16);
            this.cbIWTR.TabIndex = 39;
            this.cbIWTR.Text = "Print WTR Output";
            this.cbIWTR.UseVisualStyleBackColor = true;
            // 
            // cbIMGT
            // 
            this.cbIMGT.AutoSize = true;
            this.cbIMGT.Location = new System.Drawing.Point(183, 132);
            this.cbIMGT.Name = "cbIMGT";
            this.cbIMGT.Size = new System.Drawing.Size(120, 16);
            this.cbIMGT.TabIndex = 38;
            this.cbIMGT.Text = "Print MGT Output";
            this.cbIMGT.UseVisualStyleBackColor = true;
            // 
            // cbITEMP
            // 
            this.cbITEMP.AutoSize = true;
            this.cbITEMP.Location = new System.Drawing.Point(15, 132);
            this.cbITEMP.Name = "cbITEMP";
            this.cbITEMP.Size = new System.Drawing.Size(162, 16);
            this.cbITEMP.TabIndex = 37;
            this.cbITEMP.Text = "Print Vel./Depth Output";
            this.cbITEMP.UseVisualStyleBackColor = true;
            // 
            // cbISNOW
            // 
            this.cbISNOW.AutoSize = true;
            this.cbISNOW.Location = new System.Drawing.Point(366, 103);
            this.cbISNOW.Name = "cbISNOW";
            this.cbISNOW.Size = new System.Drawing.Size(126, 16);
            this.cbISNOW.TabIndex = 36;
            this.cbISNOW.Text = "Print Snow Output";
            this.cbISNOW.UseVisualStyleBackColor = true;
            // 
            // cbIHUMUS
            // 
            this.cbIHUMUS.AutoSize = true;
            this.cbIHUMUS.Location = new System.Drawing.Point(183, 103);
            this.cbIHUMUS.Name = "cbIHUMUS";
            this.cbIHUMUS.Size = new System.Drawing.Size(180, 16);
            this.cbIHUMUS.TabIndex = 35;
            this.cbIHUMUS.Text = "Print Water Quality Output";
            this.cbIHUMUS.UseVisualStyleBackColor = true;
            // 
            // cbIA_B
            // 
            this.cbIA_B.AutoSize = true;
            this.cbIA_B.Location = new System.Drawing.Point(15, 103);
            this.cbIA_B.Name = "cbIA_B";
            this.cbIA_B.Size = new System.Drawing.Size(138, 16);
            this.cbIA_B.TabIndex = 34;
            this.cbIA_B.Text = "Print Binary Output";
            this.cbIA_B.UseVisualStyleBackColor = true;
            // 
            // cbI_SUBW
            // 
            this.cbI_SUBW.AutoSize = true;
            this.cbI_SUBW.Location = new System.Drawing.Point(366, 74);
            this.cbI_SUBW.Name = "cbI_SUBW";
            this.cbI_SUBW.Size = new System.Drawing.Size(120, 16);
            this.cbI_SUBW.TabIndex = 33;
            this.cbI_SUBW.Text = "Print Headwaters";
            this.cbI_SUBW.UseVisualStyleBackColor = true;
            // 
            // cbISOL
            // 
            this.cbISOL.AutoSize = true;
            this.cbISOL.Location = new System.Drawing.Point(183, 74);
            this.cbISOL.Name = "cbISOL";
            this.cbISOL.Size = new System.Drawing.Size(144, 16);
            this.cbISOL.TabIndex = 32;
            this.cbISOL.Text = "Print Soil Nutriendt";
            this.cbISOL.UseVisualStyleBackColor = true;
            // 
            // cbISTO
            // 
            this.cbISTO.AutoSize = true;
            this.cbISTO.Location = new System.Drawing.Point(15, 74);
            this.cbISTO.Name = "cbISTO";
            this.cbISTO.Size = new System.Drawing.Size(132, 16);
            this.cbISTO.TabIndex = 31;
            this.cbISTO.Text = "Print Soil Storage";
            this.cbISTO.UseVisualStyleBackColor = true;
            // 
            // cbIPHR
            // 
            this.cbIPHR.AutoSize = true;
            this.cbIPHR.Location = new System.Drawing.Point(366, 45);
            this.cbIPHR.Name = "cbIPHR";
            this.cbIPHR.Size = new System.Drawing.Size(138, 16);
            this.cbIPHR.TabIndex = 30;
            this.cbIPHR.Text = "Print Hourly Output";
            this.cbIPHR.UseVisualStyleBackColor = true;
            // 
            // cbIPRP
            // 
            this.cbIPRP.AutoSize = true;
            this.cbIPRP.Location = new System.Drawing.Point(183, 45);
            this.cbIPRP.Name = "cbIPRP";
            this.cbIPRP.Size = new System.Drawing.Size(156, 16);
            this.cbIPRP.TabIndex = 29;
            this.cbIPRP.Text = "Print Pesticide Output";
            this.cbIPRP.UseVisualStyleBackColor = true;
            // 
            // cbILOG
            // 
            this.cbILOG.AutoSize = true;
            this.cbILOG.Location = new System.Drawing.Point(15, 45);
            this.cbILOG.Name = "cbILOG";
            this.cbILOG.Size = new System.Drawing.Size(108, 16);
            this.cbILOG.TabIndex = 28;
            this.cbILOG.Text = "Print Log Flow";
            this.cbILOG.UseVisualStyleBackColor = true;
            // 
            // cbOutputFileVariables
            // 
            this.cbOutputFileVariables.FormattingEnabled = true;
            this.cbOutputFileVariables.Items.AddRange(new object[] {
            "全部"});
            this.cbOutputFileVariables.Location = new System.Drawing.Point(103, 69);
            this.cbOutputFileVariables.Name = "cbOutputFileVariables";
            this.cbOutputFileVariables.Size = new System.Drawing.Size(158, 20);
            this.cbOutputFileVariables.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "可选输出变量";
            // 
            // rbYear
            // 
            this.rbYear.AutoSize = true;
            this.rbYear.Location = new System.Drawing.Point(190, 36);
            this.rbYear.Name = "rbYear";
            this.rbYear.Size = new System.Drawing.Size(71, 16);
            this.rbYear.TabIndex = 2;
            this.rbYear.Text = "按年输出";
            this.rbYear.UseVisualStyleBackColor = true;
            // 
            // rbMonth
            // 
            this.rbMonth.AutoSize = true;
            this.rbMonth.Checked = true;
            this.rbMonth.Location = new System.Drawing.Point(22, 36);
            this.rbMonth.Name = "rbMonth";
            this.rbMonth.Size = new System.Drawing.Size(71, 16);
            this.rbMonth.TabIndex = 1;
            this.rbMonth.TabStop = true;
            this.rbMonth.Text = "按月输出";
            this.rbMonth.UseVisualStyleBackColor = true;
            // 
            // rbDay
            // 
            this.rbDay.AutoSize = true;
            this.rbDay.Location = new System.Drawing.Point(106, 37);
            this.rbDay.Name = "rbDay";
            this.rbDay.Size = new System.Drawing.Size(71, 16);
            this.rbDay.TabIndex = 0;
            this.rbDay.Text = "按日输出";
            this.rbDay.UseVisualStyleBackColor = true;
            // 
            // btnDefaultSettings
            // 
            this.btnDefaultSettings.Location = new System.Drawing.Point(30, 498);
            this.btnDefaultSettings.Name = "btnDefaultSettings";
            this.btnDefaultSettings.Size = new System.Drawing.Size(96, 38);
            this.btnDefaultSettings.TabIndex = 21;
            this.btnDefaultSettings.Text = "恢复默认设置";
            this.btnDefaultSettings.UseVisualStyleBackColor = true;
            this.btnDefaultSettings.Click += new System.EventHandler(this.btnDefaultSettings_Click);
            // 
            // RunSwatModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 577);
            this.Controls.Add(this.btnDefaultSettings);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRunSWATModel);
            this.Controls.Add(this.btnSetSWATModel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RunSwatModel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "设置模型参数及运行swat模型";
            this.Load += new System.EventHandler(this.RunSwatModel_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtStartTime;
        private System.Windows.Forms.DateTimePicker dtEndTime;
        private System.Windows.Forms.Button btnSetSWATModel;
        private System.Windows.Forms.Button btnRunSWATModel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txNYSKIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label lbMaxDate;
        private System.Windows.Forms.Label lbMinDate;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbYear;
        private System.Windows.Forms.RadioButton rbMonth;
        private System.Windows.Forms.RadioButton rbDay;
        private System.Windows.Forms.ComboBox cbOutputFileVariables;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelRunMessage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNotSelectAll;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.CheckBox cbIWTR;
        private System.Windows.Forms.CheckBox cbIMGT;
        private System.Windows.Forms.CheckBox cbITEMP;
        private System.Windows.Forms.CheckBox cbISNOW;
        private System.Windows.Forms.CheckBox cbIHUMUS;
        private System.Windows.Forms.CheckBox cbIA_B;
        private System.Windows.Forms.CheckBox cbI_SUBW;
        private System.Windows.Forms.CheckBox cbISOL;
        private System.Windows.Forms.CheckBox cbISTO;
        private System.Windows.Forms.CheckBox cbIPHR;
        private System.Windows.Forms.CheckBox cbIPRP;
        private System.Windows.Forms.CheckBox cbILOG;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDefaultSettings;
    }
}