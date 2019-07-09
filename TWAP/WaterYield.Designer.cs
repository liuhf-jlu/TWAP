namespace TWAP
{
    partial class WaterYield
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WaterYield));
            this.toolStripWaterYield = new System.Windows.Forms.ToolStrip();
            this.tsbBackHome = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAddWeatherData = new System.Windows.Forms.ToolStripButton();
            this.tsbReservoirManage = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.tsbRunSWATModel = new System.Windows.Forms.ToolStripButton();
            this.tsbOutputDataManag = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.statusWaterYield = new System.Windows.Forms.StatusStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeViewInput = new System.Windows.Forms.TreeView();
            this.treeViewOutput = new System.Windows.Forms.TreeView();
            this.toolStripWaterYield.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripWaterYield
            // 
            this.toolStripWaterYield.AutoSize = false;
            this.toolStripWaterYield.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbBackHome,
            this.toolStripSeparator1,
            this.tsbAddWeatherData,
            this.tsbReservoirManage,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripSeparator2,
            this.toolStripLabel4,
            this.tsbRunSWATModel,
            this.tsbOutputDataManag,
            this.toolStripSeparator3,
            this.tsbRefresh});
            this.toolStripWaterYield.Location = new System.Drawing.Point(0, 0);
            this.toolStripWaterYield.Name = "toolStripWaterYield";
            this.toolStripWaterYield.Size = new System.Drawing.Size(877, 64);
            this.toolStripWaterYield.TabIndex = 0;
            this.toolStripWaterYield.Text = "toolStrip1";
            this.toolStripWaterYield.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStripWaterYield_ItemClicked);
            // 
            // tsbBackHome
            // 
            this.tsbBackHome.Image = ((System.Drawing.Image)(resources.GetObject("tsbBackHome.Image")));
            this.tsbBackHome.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbBackHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBackHome.Name = "tsbBackHome";
            this.tsbBackHome.Size = new System.Drawing.Size(48, 61);
            this.tsbBackHome.Text = "主页面";
            this.tsbBackHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbBackHome.Click += new System.EventHandler(this.tsbBackHome_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 64);
            // 
            // tsbAddWeatherData
            // 
            this.tsbAddWeatherData.Image = ((System.Drawing.Image)(resources.GetObject("tsbAddWeatherData.Image")));
            this.tsbAddWeatherData.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbAddWeatherData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddWeatherData.Name = "tsbAddWeatherData";
            this.tsbAddWeatherData.Size = new System.Drawing.Size(60, 61);
            this.tsbAddWeatherData.Text = "气象管理";
            this.tsbAddWeatherData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbAddWeatherData.Click += new System.EventHandler(this.tsbAddWeatherData_Click);
            // 
            // tsbReservoirManage
            // 
            this.tsbReservoirManage.Image = ((System.Drawing.Image)(resources.GetObject("tsbReservoirManage.Image")));
            this.tsbReservoirManage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbReservoirManage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbReservoirManage.Name = "tsbReservoirManage";
            this.tsbReservoirManage.Size = new System.Drawing.Size(60, 61);
            this.tsbReservoirManage.Text = "水库管理";
            this.tsbReservoirManage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbReservoirManage.Click += new System.EventHandler(this.tsbReservoirManage_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(72, 61);
            this.toolStripButton2.Text = "入水口管理";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(96, 61);
            this.toolStripButton3.Text = "人工取水口管理";
            this.toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 64);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(0, 61);
            // 
            // tsbRunSWATModel
            // 
            this.tsbRunSWATModel.Image = ((System.Drawing.Image)(resources.GetObject("tsbRunSWATModel.Image")));
            this.tsbRunSWATModel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbRunSWATModel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRunSWATModel.Name = "tsbRunSWATModel";
            this.tsbRunSWATModel.Size = new System.Drawing.Size(60, 61);
            this.tsbRunSWATModel.Text = "运行模拟";
            this.tsbRunSWATModel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbRunSWATModel.Click += new System.EventHandler(this.tsbRunSWATModel_Click);
            // 
            // tsbOutputDataManag
            // 
            this.tsbOutputDataManag.Image = ((System.Drawing.Image)(resources.GetObject("tsbOutputDataManag.Image")));
            this.tsbOutputDataManag.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbOutputDataManag.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOutputDataManag.Name = "tsbOutputDataManag";
            this.tsbOutputDataManag.Size = new System.Drawing.Size(60, 61);
            this.tsbOutputDataManag.Text = "输出管理";
            this.tsbOutputDataManag.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbOutputDataManag.Click += new System.EventHandler(this.tsbOutputDataManag_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 64);
            // 
            // tsbRefresh
            // 
            this.tsbRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tsbRefresh.Image")));
            this.tsbRefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefresh.Name = "tsbRefresh";
            this.tsbRefresh.Size = new System.Drawing.Size(36, 61);
            this.tsbRefresh.Text = "刷新";
            this.tsbRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbRefresh.Click += new System.EventHandler(this.tsbRefresh_Click);
            // 
            // statusWaterYield
            // 
            this.statusWaterYield.Location = new System.Drawing.Point(0, 429);
            this.statusWaterYield.Name = "statusWaterYield";
            this.statusWaterYield.Size = new System.Drawing.Size(877, 22);
            this.statusWaterYield.TabIndex = 2;
            this.statusWaterYield.Text = "statusStrip1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 64);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.treeViewInput);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.treeViewOutput);
            this.splitContainer1.Size = new System.Drawing.Size(877, 365);
            this.splitContainer1.SplitterDistance = 434;
            this.splitContainer1.TabIndex = 3;
            // 
            // treeViewInput
            // 
            this.treeViewInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewInput.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.treeViewInput.ForeColor = System.Drawing.Color.Black;
            this.treeViewInput.LineColor = System.Drawing.Color.Red;
            this.treeViewInput.Location = new System.Drawing.Point(0, 0);
            this.treeViewInput.Name = "treeViewInput";
            this.treeViewInput.Size = new System.Drawing.Size(434, 365);
            this.treeViewInput.TabIndex = 0;
            this.treeViewInput.DoubleClick += new System.EventHandler(this.treeViewOfWaterYield_DoubleClick);
            // 
            // treeViewOutput
            // 
            this.treeViewOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewOutput.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.treeViewOutput.LineColor = System.Drawing.Color.Lime;
            this.treeViewOutput.Location = new System.Drawing.Point(0, 0);
            this.treeViewOutput.Name = "treeViewOutput";
            this.treeViewOutput.Size = new System.Drawing.Size(439, 365);
            this.treeViewOutput.TabIndex = 0;
            this.treeViewOutput.DoubleClick += new System.EventHandler(this.treeViewOutput_DoubleClick);
            // 
            // WaterYield
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 451);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusWaterYield);
            this.Controls.Add(this.toolStripWaterYield);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WaterYield";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "水量模拟";
            this.Load += new System.EventHandler(this.WaterYield_Load);
            this.toolStripWaterYield.ResumeLayout(false);
            this.toolStripWaterYield.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripWaterYield;
        private System.Windows.Forms.ToolStripButton tsbAddWeatherData;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripButton tsbRunSWATModel;
        private System.Windows.Forms.ToolStripButton tsbOutputDataManag;
        private System.Windows.Forms.ToolStripButton tsbBackHome;
        private System.Windows.Forms.StatusStrip statusWaterYield;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private System.Windows.Forms.ToolStripButton tsbReservoirManage;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeViewInput;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.TreeView treeViewOutput;

    }
}