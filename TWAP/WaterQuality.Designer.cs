namespace TWAP
{
    partial class WaterQuality
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WaterQuality));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.wqtsbBackhome = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.wqtsbPointSourceManage = new System.Windows.Forms.ToolStripButton();
            this.wqtsbMgtManage = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.wqtsbRunSWAT = new System.Windows.Forms.ToolStripButton();
            this.wqtsbOutputManage = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.wqtsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeViewInput = new System.Windows.Forms.TreeView();
            this.treeViewOutput = new System.Windows.Forms.TreeView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wqtsbBackhome,
            this.toolStripSeparator1,
            this.wqtsbPointSourceManage,
            this.wqtsbMgtManage,
            this.toolStripSeparator3,
            this.wqtsbRunSWAT,
            this.wqtsbOutputManage,
            this.toolStripSeparator2,
            this.wqtsbRefresh});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(878, 64);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // wqtsbBackhome
            // 
            this.wqtsbBackhome.Image = ((System.Drawing.Image)(resources.GetObject("wqtsbBackhome.Image")));
            this.wqtsbBackhome.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.wqtsbBackhome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.wqtsbBackhome.Name = "wqtsbBackhome";
            this.wqtsbBackhome.Size = new System.Drawing.Size(48, 61);
            this.wqtsbBackhome.Text = "主页面";
            this.wqtsbBackhome.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.wqtsbBackhome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.wqtsbBackhome.Click += new System.EventHandler(this.wqtsbBackhome_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 64);
            // 
            // wqtsbPointSourceManage
            // 
            this.wqtsbPointSourceManage.Image = ((System.Drawing.Image)(resources.GetObject("wqtsbPointSourceManage.Image")));
            this.wqtsbPointSourceManage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.wqtsbPointSourceManage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.wqtsbPointSourceManage.Name = "wqtsbPointSourceManage";
            this.wqtsbPointSourceManage.Size = new System.Drawing.Size(60, 61);
            this.wqtsbPointSourceManage.Text = "点源管理";
            this.wqtsbPointSourceManage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.wqtsbPointSourceManage.Click += new System.EventHandler(this.wqtsbPointSourceManage_Click);
            // 
            // wqtsbMgtManage
            // 
            this.wqtsbMgtManage.Image = ((System.Drawing.Image)(resources.GetObject("wqtsbMgtManage.Image")));
            this.wqtsbMgtManage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.wqtsbMgtManage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.wqtsbMgtManage.Name = "wqtsbMgtManage";
            this.wqtsbMgtManage.Size = new System.Drawing.Size(60, 61);
            this.wqtsbMgtManage.Text = "面源管理";
            this.wqtsbMgtManage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.wqtsbMgtManage.Click += new System.EventHandler(this.wqtsbMgtManage_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 64);
            // 
            // wqtsbRunSWAT
            // 
            this.wqtsbRunSWAT.Image = ((System.Drawing.Image)(resources.GetObject("wqtsbRunSWAT.Image")));
            this.wqtsbRunSWAT.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.wqtsbRunSWAT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.wqtsbRunSWAT.Name = "wqtsbRunSWAT";
            this.wqtsbRunSWAT.Size = new System.Drawing.Size(60, 61);
            this.wqtsbRunSWAT.Text = "运行模型";
            this.wqtsbRunSWAT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.wqtsbRunSWAT.Click += new System.EventHandler(this.wqtsbRunSWAT_Click);
            // 
            // wqtsbOutputManage
            // 
            this.wqtsbOutputManage.Image = ((System.Drawing.Image)(resources.GetObject("wqtsbOutputManage.Image")));
            this.wqtsbOutputManage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.wqtsbOutputManage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.wqtsbOutputManage.Name = "wqtsbOutputManage";
            this.wqtsbOutputManage.Size = new System.Drawing.Size(60, 61);
            this.wqtsbOutputManage.Text = "输出管理";
            this.wqtsbOutputManage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.wqtsbOutputManage.Click += new System.EventHandler(this.wqtsbOutputManage_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 64);
            // 
            // wqtsbRefresh
            // 
            this.wqtsbRefresh.Image = ((System.Drawing.Image)(resources.GetObject("wqtsbRefresh.Image")));
            this.wqtsbRefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.wqtsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.wqtsbRefresh.Name = "wqtsbRefresh";
            this.wqtsbRefresh.Size = new System.Drawing.Size(36, 61);
            this.wqtsbRefresh.Text = "刷新";
            this.wqtsbRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.wqtsbRefresh.Click += new System.EventHandler(this.wqtsbRefresh_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(878, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 64);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeViewInput);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.treeViewOutput);
            this.splitContainer1.Size = new System.Drawing.Size(878, 360);
            this.splitContainer1.SplitterDistance = 427;
            this.splitContainer1.TabIndex = 2;
            // 
            // treeViewInput
            // 
            this.treeViewInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewInput.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.treeViewInput.ForeColor = System.Drawing.SystemColors.WindowText;
            this.treeViewInput.LineColor = System.Drawing.Color.Red;
            this.treeViewInput.Location = new System.Drawing.Point(0, 0);
            this.treeViewInput.Name = "treeViewInput";
            this.treeViewInput.Size = new System.Drawing.Size(427, 360);
            this.treeViewInput.TabIndex = 0;
            this.treeViewInput.DoubleClick += new System.EventHandler(this.treeViewInput_DoubleClick);
            // 
            // treeViewOutput
            // 
            this.treeViewOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewOutput.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.treeViewOutput.LineColor = System.Drawing.Color.Lime;
            this.treeViewOutput.Location = new System.Drawing.Point(0, 0);
            this.treeViewOutput.Name = "treeViewOutput";
            this.treeViewOutput.Size = new System.Drawing.Size(447, 360);
            this.treeViewOutput.TabIndex = 0;
            this.treeViewOutput.DoubleClick += new System.EventHandler(this.treeViewOutput_DoubleClick);
            // 
            // WaterQuality
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 446);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WaterQuality";
            this.Text = "水质模拟";
            this.Load += new System.EventHandler(this.WaterQuality_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripButton wqtsbBackhome;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton wqtsbPointSourceManage;
        private System.Windows.Forms.ToolStripButton wqtsbMgtManage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton wqtsbRefresh;
        private System.Windows.Forms.ToolStripButton wqtsbRunSWAT;
        private System.Windows.Forms.ToolStripButton wqtsbOutputManage;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeViewInput;
        private System.Windows.Forms.TreeView treeViewOutput;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}