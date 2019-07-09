namespace TWAP
{
    partial class WeatherInputData
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeatherInputData));
            this.txShowPcp = new System.Windows.Forms.TextBox();
            this.btnAddPcp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddTmp = new System.Windows.Forms.Button();
            this.txShowTmp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btAddHmd = new System.Windows.Forms.Button();
            this.txShowHmd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddSlr = new System.Windows.Forms.Button();
            this.txShowSlr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btAddWnd = new System.Windows.Forms.Button();
            this.txShowWnd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pcpStatus = new System.Windows.Forms.Label();
            this.tmpStatus = new System.Windows.Forms.Label();
            this.hmdStatus = new System.Windows.Forms.Label();
            this.slrStatus = new System.Windows.Forms.Label();
            this.wndStatus = new System.Windows.Forms.Label();
            this.btnFinish = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.rtbMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txShowPcp
            // 
            this.txShowPcp.Location = new System.Drawing.Point(84, 30);
            this.txShowPcp.Name = "txShowPcp";
            this.txShowPcp.Size = new System.Drawing.Size(140, 21);
            this.txShowPcp.TabIndex = 5;
            this.txShowPcp.MouseEnter += new System.EventHandler(this.txShowPcp_MouseEnter);
            // 
            // btnAddPcp
            // 
            this.btnAddPcp.Location = new System.Drawing.Point(250, 28);
            this.btnAddPcp.Name = "btnAddPcp";
            this.btnAddPcp.Size = new System.Drawing.Size(75, 23);
            this.btnAddPcp.TabIndex = 4;
            this.btnAddPcp.Text = "添加";
            this.btnAddPcp.UseVisualStyleBackColor = true;
            this.btnAddPcp.Click += new System.EventHandler(this.btnAddPcp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "降雨量";
            // 
            // btnAddTmp
            // 
            this.btnAddTmp.Location = new System.Drawing.Point(250, 85);
            this.btnAddTmp.Name = "btnAddTmp";
            this.btnAddTmp.Size = new System.Drawing.Size(75, 23);
            this.btnAddTmp.TabIndex = 11;
            this.btnAddTmp.Text = "添加";
            this.btnAddTmp.UseVisualStyleBackColor = true;
            this.btnAddTmp.Click += new System.EventHandler(this.btnAddTmp_Click);
            // 
            // txShowTmp
            // 
            this.txShowTmp.Location = new System.Drawing.Point(84, 87);
            this.txShowTmp.Name = "txShowTmp";
            this.txShowTmp.Size = new System.Drawing.Size(140, 21);
            this.txShowTmp.TabIndex = 10;
            this.txShowTmp.MouseEnter += new System.EventHandler(this.txShowTmp_MouseEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "温度";
            // 
            // btAddHmd
            // 
            this.btAddHmd.Location = new System.Drawing.Point(250, 143);
            this.btAddHmd.Name = "btAddHmd";
            this.btAddHmd.Size = new System.Drawing.Size(75, 23);
            this.btAddHmd.TabIndex = 14;
            this.btAddHmd.Text = "添加";
            this.btAddHmd.UseVisualStyleBackColor = true;
            this.btAddHmd.Click += new System.EventHandler(this.btAddHmd_Click);
            // 
            // txShowHmd
            // 
            this.txShowHmd.Location = new System.Drawing.Point(84, 145);
            this.txShowHmd.Name = "txShowHmd";
            this.txShowHmd.Size = new System.Drawing.Size(140, 21);
            this.txShowHmd.TabIndex = 13;
            this.txShowHmd.MouseEnter += new System.EventHandler(this.txShowHmd_MouseEnter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "相对湿度";
            // 
            // btnAddSlr
            // 
            this.btnAddSlr.Location = new System.Drawing.Point(250, 196);
            this.btnAddSlr.Name = "btnAddSlr";
            this.btnAddSlr.Size = new System.Drawing.Size(75, 23);
            this.btnAddSlr.TabIndex = 17;
            this.btnAddSlr.Text = "添加";
            this.btnAddSlr.UseVisualStyleBackColor = true;
            this.btnAddSlr.Click += new System.EventHandler(this.btnAddSlr_Click);
            // 
            // txShowSlr
            // 
            this.txShowSlr.Location = new System.Drawing.Point(84, 198);
            this.txShowSlr.Name = "txShowSlr";
            this.txShowSlr.Size = new System.Drawing.Size(140, 21);
            this.txShowSlr.TabIndex = 16;
            this.txShowSlr.MouseEnter += new System.EventHandler(this.txShowSlr_MouseEnter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "太阳辐射";
            // 
            // btAddWnd
            // 
            this.btAddWnd.Location = new System.Drawing.Point(250, 255);
            this.btAddWnd.Name = "btAddWnd";
            this.btAddWnd.Size = new System.Drawing.Size(75, 25);
            this.btAddWnd.TabIndex = 20;
            this.btAddWnd.Text = "添加";
            this.btAddWnd.UseVisualStyleBackColor = true;
            this.btAddWnd.Click += new System.EventHandler(this.btAddWnd_Click);
            // 
            // txShowWnd
            // 
            this.txShowWnd.Location = new System.Drawing.Point(84, 259);
            this.txShowWnd.Name = "txShowWnd";
            this.txShowWnd.Size = new System.Drawing.Size(140, 21);
            this.txShowWnd.TabIndex = 19;
            this.txShowWnd.MouseEnter += new System.EventHandler(this.txShowWnd_MouseEnter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 18;
            this.label5.Text = "风速";
            // 
            // pcpStatus
            // 
            this.pcpStatus.AutoSize = true;
            this.pcpStatus.ForeColor = System.Drawing.Color.Red;
            this.pcpStatus.Location = new System.Drawing.Point(355, 33);
            this.pcpStatus.Name = "pcpStatus";
            this.pcpStatus.Size = new System.Drawing.Size(65, 12);
            this.pcpStatus.TabIndex = 21;
            this.pcpStatus.Text = "uncomplete";
            // 
            // tmpStatus
            // 
            this.tmpStatus.AutoSize = true;
            this.tmpStatus.ForeColor = System.Drawing.Color.Red;
            this.tmpStatus.Location = new System.Drawing.Point(355, 88);
            this.tmpStatus.Name = "tmpStatus";
            this.tmpStatus.Size = new System.Drawing.Size(65, 12);
            this.tmpStatus.TabIndex = 22;
            this.tmpStatus.Text = "uncomplete";
            // 
            // hmdStatus
            // 
            this.hmdStatus.AutoSize = true;
            this.hmdStatus.ForeColor = System.Drawing.Color.Red;
            this.hmdStatus.Location = new System.Drawing.Point(355, 146);
            this.hmdStatus.Name = "hmdStatus";
            this.hmdStatus.Size = new System.Drawing.Size(65, 12);
            this.hmdStatus.TabIndex = 23;
            this.hmdStatus.Text = "uncomplete";
            // 
            // slrStatus
            // 
            this.slrStatus.AutoSize = true;
            this.slrStatus.ForeColor = System.Drawing.Color.Red;
            this.slrStatus.Location = new System.Drawing.Point(355, 199);
            this.slrStatus.Name = "slrStatus";
            this.slrStatus.Size = new System.Drawing.Size(65, 12);
            this.slrStatus.TabIndex = 24;
            this.slrStatus.Text = "uncomplete";
            // 
            // wndStatus
            // 
            this.wndStatus.AutoSize = true;
            this.wndStatus.ForeColor = System.Drawing.Color.Red;
            this.wndStatus.Location = new System.Drawing.Point(355, 258);
            this.wndStatus.Name = "wndStatus";
            this.wndStatus.Size = new System.Drawing.Size(65, 12);
            this.wndStatus.TabIndex = 25;
            this.wndStatus.Text = "uncomplete";
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(140, 380);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(85, 32);
            this.btnFinish.TabIndex = 27;
            this.btnFinish.Text = "完成";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btAddWnd);
            this.groupBox1.Controls.Add(this.txShowWnd);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnAddSlr);
            this.groupBox1.Controls.Add(this.wndStatus);
            this.groupBox1.Controls.Add(this.txShowSlr);
            this.groupBox1.Controls.Add(this.slrStatus);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.hmdStatus);
            this.groupBox1.Controls.Add(this.btAddHmd);
            this.groupBox1.Controls.Add(this.tmpStatus);
            this.groupBox1.Controls.Add(this.txShowHmd);
            this.groupBox1.Controls.Add(this.pcpStatus);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnAddTmp);
            this.groupBox1.Controls.Add(this.txShowTmp);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txShowPcp);
            this.groupBox1.Controls.Add(this.btnAddPcp);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(56, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 303);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "五项指标";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.rtbMessage});
            this.statusStrip1.Location = new System.Drawing.Point(0, 455);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(560, 22);
            this.statusStrip1.TabIndex = 31;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(44, 17);
            this.toolStripStatusLabel1.Text = "消息：";
            // 
            // rtbMessage
            // 
            this.rtbMessage.Name = "rtbMessage";
            this.rtbMessage.Size = new System.Drawing.Size(56, 17);
            this.rtbMessage.Text = "提示信息";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(296, 380);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 32);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // WeatherInputData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(560, 477);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WeatherInputData";
            this.Text = "添加气候数据";
            this.Load += new System.EventHandler(this.WeatherInputData_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txShowPcp;
        private System.Windows.Forms.Button btnAddPcp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddTmp;
        private System.Windows.Forms.TextBox txShowTmp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btAddHmd;
        private System.Windows.Forms.TextBox txShowHmd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddSlr;
        private System.Windows.Forms.TextBox txShowSlr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btAddWnd;
        private System.Windows.Forms.TextBox txShowWnd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label pcpStatus;
        private System.Windows.Forms.Label tmpStatus;
        private System.Windows.Forms.Label hmdStatus;
        private System.Windows.Forms.Label slrStatus;
        private System.Windows.Forms.Label wndStatus;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel rtbMessage;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}