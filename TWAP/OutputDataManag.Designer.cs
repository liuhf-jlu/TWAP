namespace TWAP
{
    partial class OutputDataManag
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OutputDataManag));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnImportToAccess = new System.Windows.Forms.Button();
            this.btnSelectOutputData = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.tsbBack = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tscbShowTxt = new System.Windows.Forms.ToolStripComboBox();
            this.tsbShowTxt = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tsbImportToAccess = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.tscbShowAccess = new System.Windows.Forms.ToolStripComboBox();
            this.tsbShowAccess = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnDisplayAccess = new System.Windows.Forms.Button();
            this.btnSelectAccess = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tpContainer = new System.Windows.Forms.TabControl();
            this.tpTxt = new System.Windows.Forms.TabPage();
            this.dataGridTxt = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridAccess = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tpContainer.SuspendLayout();
            this.tpTxt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTxt)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAccess)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnImportToAccess);
            this.groupBox1.Controls.Add(this.btnSelectOutputData);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 67);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "文本文件导入数据库";
            // 
            // btnImportToAccess
            // 
            this.btnImportToAccess.Location = new System.Drawing.Point(319, 29);
            this.btnImportToAccess.Name = "btnImportToAccess";
            this.btnImportToAccess.Size = new System.Drawing.Size(103, 23);
            this.btnImportToAccess.TabIndex = 3;
            this.btnImportToAccess.Text = "导入到数据库";
            this.btnImportToAccess.UseVisualStyleBackColor = true;
            this.btnImportToAccess.Click += new System.EventHandler(this.btnImportToAccess_Click);
            // 
            // btnSelectOutputData
            // 
            this.btnSelectOutputData.Location = new System.Drawing.Point(238, 29);
            this.btnSelectOutputData.Name = "btnSelectOutputData";
            this.btnSelectOutputData.Size = new System.Drawing.Size(75, 23);
            this.btnSelectOutputData.TabIndex = 2;
            this.btnSelectOutputData.Text = "浏览...";
            this.btnSelectOutputData.UseVisualStyleBackColor = true;
            this.btnSelectOutputData.Click += new System.EventHandler(this.btnSelectOutputData_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(72, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 21);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "选择文件";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel4,
            this.tsbBack,
            this.toolStripSeparator3,
            this.toolStripLabel1,
            this.tscbShowTxt,
            this.tsbShowTxt,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.tsbImportToAccess,
            this.toolStripSeparator2,
            this.toolStripLabel3,
            this.tscbShowAccess,
            this.tsbShowAccess});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(933, 48);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(37, 45);
            this.toolStripLabel4.Text = "返回";
            // 
            // tsbBack
            // 
            this.tsbBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBack.Image = ((System.Drawing.Image)(resources.GetObject("tsbBack.Image")));
            this.tsbBack.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBack.Name = "tsbBack";
            this.tsbBack.Size = new System.Drawing.Size(36, 45);
            this.tsbBack.Text = "toolStripButton4";
            this.tsbBack.Click += new System.EventHandler(this.tsbBack_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 48);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(93, 45);
            this.toolStripLabel1.Text = "查看输出结果";
            // 
            // tscbShowTxt
            // 
            this.tscbShowTxt.Name = "tscbShowTxt";
            this.tscbShowTxt.Size = new System.Drawing.Size(121, 48);
            // 
            // tsbShowTxt
            // 
            this.tsbShowTxt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbShowTxt.Image = ((System.Drawing.Image)(resources.GetObject("tsbShowTxt.Image")));
            this.tsbShowTxt.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbShowTxt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbShowTxt.Name = "tsbShowTxt";
            this.tsbShowTxt.Size = new System.Drawing.Size(36, 45);
            this.tsbShowTxt.Text = "toolStripButton1";
            this.tsbShowTxt.Click += new System.EventHandler(this.tsbShowTxt_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 48);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(149, 45);
            this.toolStripLabel2.Text = "输出结果导入到数据库";
            // 
            // tsbImportToAccess
            // 
            this.tsbImportToAccess.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbImportToAccess.Image = ((System.Drawing.Image)(resources.GetObject("tsbImportToAccess.Image")));
            this.tsbImportToAccess.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbImportToAccess.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbImportToAccess.Name = "tsbImportToAccess";
            this.tsbImportToAccess.Size = new System.Drawing.Size(36, 45);
            this.tsbImportToAccess.Text = "toolStripButton2";
            this.tsbImportToAccess.Click += new System.EventHandler(this.tsbImportToAccess_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 48);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(107, 45);
            this.toolStripLabel3.Text = "查看数据库文件";
            // 
            // tscbShowAccess
            // 
            this.tscbShowAccess.Name = "tscbShowAccess";
            this.tscbShowAccess.Size = new System.Drawing.Size(121, 48);
            // 
            // tsbShowAccess
            // 
            this.tsbShowAccess.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbShowAccess.Image = ((System.Drawing.Image)(resources.GetObject("tsbShowAccess.Image")));
            this.tsbShowAccess.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbShowAccess.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbShowAccess.Name = "tsbShowAccess";
            this.tsbShowAccess.Size = new System.Drawing.Size(36, 45);
            this.tsbShowAccess.Text = "toolStripButton3";
            this.tsbShowAccess.Click += new System.EventHandler(this.tsbShowAccess_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.btnDisplayAccess);
            this.groupBox2.Controls.Add(this.btnSelectAccess);
            this.groupBox2.Location = new System.Drawing.Point(453, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 67);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "查看数据库文件";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "选择数据库";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(84, 28);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(206, 21);
            this.textBox2.TabIndex = 2;
            // 
            // btnDisplayAccess
            // 
            this.btnDisplayAccess.Location = new System.Drawing.Point(377, 28);
            this.btnDisplayAccess.Name = "btnDisplayAccess";
            this.btnDisplayAccess.Size = new System.Drawing.Size(63, 23);
            this.btnDisplayAccess.TabIndex = 1;
            this.btnDisplayAccess.Text = "查看数据";
            this.btnDisplayAccess.UseVisualStyleBackColor = true;
            this.btnDisplayAccess.Click += new System.EventHandler(this.btnDisplayAccess_Click);
            // 
            // btnSelectAccess
            // 
            this.btnSelectAccess.Location = new System.Drawing.Point(296, 26);
            this.btnSelectAccess.Name = "btnSelectAccess";
            this.btnSelectAccess.Size = new System.Drawing.Size(75, 23);
            this.btnSelectAccess.TabIndex = 0;
            this.btnSelectAccess.Text = "浏览...";
            this.btnSelectAccess.UseVisualStyleBackColor = true;
            this.btnSelectAccess.Click += new System.EventHandler(this.btnSelectAccess_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 98);
            this.panel1.TabIndex = 3;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 462);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(933, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tpContainer
            // 
            this.tpContainer.Controls.Add(this.tpTxt);
            this.tpContainer.Controls.Add(this.tabPage2);
            this.tpContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpContainer.Location = new System.Drawing.Point(0, 146);
            this.tpContainer.Name = "tpContainer";
            this.tpContainer.SelectedIndex = 0;
            this.tpContainer.Size = new System.Drawing.Size(933, 316);
            this.tpContainer.TabIndex = 6;
            // 
            // tpTxt
            // 
            this.tpTxt.Controls.Add(this.dataGridTxt);
            this.tpTxt.Location = new System.Drawing.Point(4, 22);
            this.tpTxt.Name = "tpTxt";
            this.tpTxt.Padding = new System.Windows.Forms.Padding(3);
            this.tpTxt.Size = new System.Drawing.Size(925, 290);
            this.tpTxt.TabIndex = 0;
            this.tpTxt.Text = "输出结果（文本）";
            this.tpTxt.UseVisualStyleBackColor = true;
            // 
            // dataGridTxt
            // 
            this.dataGridTxt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridTxt.Location = new System.Drawing.Point(3, 3);
            this.dataGridTxt.Name = "dataGridTxt";
            this.dataGridTxt.RowTemplate.Height = 23;
            this.dataGridTxt.Size = new System.Drawing.Size(919, 284);
            this.dataGridTxt.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridAccess);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1021, 290);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "输出结果（Access）";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridAccess
            // 
            this.dataGridAccess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAccess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridAccess.Location = new System.Drawing.Point(3, 3);
            this.dataGridAccess.Name = "dataGridAccess";
            this.dataGridAccess.RowTemplate.Height = 23;
            this.dataGridAccess.Size = new System.Drawing.Size(1015, 284);
            this.dataGridAccess.TabIndex = 0;
            // 
            // OutputDataManag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 484);
            this.Controls.Add(this.tpContainer);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "OutputDataManag";
            this.Text = "输出数据管理";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tpContainer.ResumeLayout(false);
            this.tpTxt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTxt)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAccess)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnImportToAccess;
        private System.Windows.Forms.Button btnSelectOutputData;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripButton tsbBack;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripComboBox tscbShowTxt;
        private System.Windows.Forms.ToolStripButton tsbShowTxt;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton tsbImportToAccess;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripComboBox tscbShowAccess;
        private System.Windows.Forms.ToolStripButton tsbShowAccess;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnDisplayAccess;
        private System.Windows.Forms.Button btnSelectAccess;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabControl tpContainer;
        private System.Windows.Forms.TabPage tpTxt;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridTxt;
        private System.Windows.Forms.DataGridView dataGridAccess;
    }
}