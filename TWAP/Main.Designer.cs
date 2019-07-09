namespace TWAP
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbWaterYield = new System.Windows.Forms.ToolStripButton();
            this.tsbWaterQuality = new System.Windows.Forms.ToolStripButton();
            this.tsbWaterEcology = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbHelp = new System.Windows.Forms.ToolStripButton();
            this.tsbAbout = new System.Windows.Forms.ToolStripButton();
            this.tsbExit = new System.Windows.Forms.ToolStripButton();
            this.MainStatus = new System.Windows.Forms.StatusStrip();
            this.mainTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            this.MainStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbWaterYield,
            this.tsbWaterQuality,
            this.tsbWaterEcology,
            this.toolStripSeparator1,
            this.tsbHelp,
            this.tsbAbout,
            this.tsbExit});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Margin = new System.Windows.Forms.Padding(1);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.toolStrip1.Size = new System.Drawing.Size(894, 70);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbWaterYield
            // 
            this.tsbWaterYield.Image = ((System.Drawing.Image)(resources.GetObject("tsbWaterYield.Image")));
            this.tsbWaterYield.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbWaterYield.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbWaterYield.Name = "tsbWaterYield";
            this.tsbWaterYield.Size = new System.Drawing.Size(60, 67);
            this.tsbWaterYield.Text = "水量模拟";
            this.tsbWaterYield.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbWaterYield.Click += new System.EventHandler(this.tsbWaterYield_Click);
            // 
            // tsbWaterQuality
            // 
            this.tsbWaterQuality.Image = ((System.Drawing.Image)(resources.GetObject("tsbWaterQuality.Image")));
            this.tsbWaterQuality.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbWaterQuality.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbWaterQuality.Name = "tsbWaterQuality";
            this.tsbWaterQuality.Size = new System.Drawing.Size(60, 67);
            this.tsbWaterQuality.Text = "水质模拟";
            this.tsbWaterQuality.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbWaterQuality.Click += new System.EventHandler(this.tsbWaterQuality_Click);
            // 
            // tsbWaterEcology
            // 
            this.tsbWaterEcology.Image = ((System.Drawing.Image)(resources.GetObject("tsbWaterEcology.Image")));
            this.tsbWaterEcology.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbWaterEcology.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbWaterEcology.Name = "tsbWaterEcology";
            this.tsbWaterEcology.Size = new System.Drawing.Size(96, 67);
            this.tsbWaterEcology.Text = "水生态安全评估";
            this.tsbWaterEcology.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbWaterEcology.Click += new System.EventHandler(this.tsbWaterEcology_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 70);
            // 
            // tsbHelp
            // 
            this.tsbHelp.Image = ((System.Drawing.Image)(resources.GetObject("tsbHelp.Image")));
            this.tsbHelp.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbHelp.Name = "tsbHelp";
            this.tsbHelp.Size = new System.Drawing.Size(52, 67);
            this.tsbHelp.Text = "帮助";
            this.tsbHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbHelp.Click += new System.EventHandler(this.tsbHelp_Click);
            // 
            // tsbAbout
            // 
            this.tsbAbout.Image = ((System.Drawing.Image)(resources.GetObject("tsbAbout.Image")));
            this.tsbAbout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAbout.Name = "tsbAbout";
            this.tsbAbout.Size = new System.Drawing.Size(52, 67);
            this.tsbAbout.Text = "关于";
            this.tsbAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbAbout.Click += new System.EventHandler(this.tsbAbout_Click);
            // 
            // tsbExit
            // 
            this.tsbExit.Image = ((System.Drawing.Image)(resources.GetObject("tsbExit.Image")));
            this.tsbExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExit.Name = "tsbExit";
            this.tsbExit.Size = new System.Drawing.Size(60, 67);
            this.tsbExit.Text = "退出系统";
            this.tsbExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbExit.Click += new System.EventHandler(this.tsbExit_Click);
            // 
            // MainStatus
            // 
            this.MainStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainTime});
            this.MainStatus.Location = new System.Drawing.Point(0, 513);
            this.MainStatus.Name = "MainStatus";
            this.MainStatus.Padding = new System.Windows.Forms.Padding(1, 0, 17, 0);
            this.MainStatus.Size = new System.Drawing.Size(894, 22);
            this.MainStatus.TabIndex = 6;
            this.MainStatus.Text = "statusStrip1";
            // 
            // mainTime
            // 
            this.mainTime.Name = "mainTime";
            this.mainTime.Size = new System.Drawing.Size(0, 17);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(894, 443);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(894, 535);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MainStatus);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "三水综合模拟预测系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.MainStatus.ResumeLayout(false);
            this.MainStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbWaterYield;
        private System.Windows.Forms.ToolStripButton tsbWaterQuality;
        private System.Windows.Forms.ToolStripButton tsbWaterEcology;
        private System.Windows.Forms.StatusStrip MainStatus;
        private System.Windows.Forms.ToolStripButton tsbExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripStatusLabel mainTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripButton tsbHelp;
        private System.Windows.Forms.ToolStripButton tsbAbout;
    }
}

