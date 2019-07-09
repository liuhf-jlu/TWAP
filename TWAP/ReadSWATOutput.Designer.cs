namespace TWAP
{
    partial class ReadSWATOutput
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxSimu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSaveSimu = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxReadSWATOutput = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.groupBox2.SuspendLayout();
            this.groupBoxReadSWATOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxSimu);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnSaveSimu);
            this.groupBox2.Location = new System.Drawing.Point(12, 274);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(551, 104);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "保存模拟结果";
            // 
            // textBoxSimu
            // 
            this.textBoxSimu.Location = new System.Drawing.Point(18, 62);
            this.textBoxSimu.Name = "textBoxSimu";
            this.textBoxSimu.Size = new System.Drawing.Size(394, 21);
            this.textBoxSimu.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "保存当前SWAT模拟";
            // 
            // btnSaveSimu
            // 
            this.btnSaveSimu.Location = new System.Drawing.Point(447, 54);
            this.btnSaveSimu.Name = "btnSaveSimu";
            this.btnSaveSimu.Size = new System.Drawing.Size(83, 34);
            this.btnSaveSimu.TabIndex = 0;
            this.btnSaveSimu.Text = "保存模拟";
            this.btnSaveSimu.UseVisualStyleBackColor = true;
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(459, 411);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(83, 36);
            this.btnCancle.TabIndex = 2;
            this.btnCancle.Text = "取消";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "文件导入数据库";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(18, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 37);
            this.button2.TabIndex = 1;
            this.button2.Text = "打开 SWATOutput.mdb";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(18, 128);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 40);
            this.button3.TabIndex = 2;
            this.button3.Text = "打开 output.std";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(18, 181);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(143, 41);
            this.button4.TabIndex = 3;
            this.button4.Text = "打开 input.std";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "将SWAT输出文本文件的选定部分输入到Access数据库";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(203, 59);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(84, 16);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "output.rch";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(303, 59);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(84, 16);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "output.sub";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(407, 59);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(84, 16);
            this.checkBox3.TabIndex = 7;
            this.checkBox3.Text = "output.hru";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(201, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(329, 48);
            this.label3.TabIndex = 8;
            this.label3.Text = "*output.std 输出文件包含模型运行的有效汇总信息，\r\n\r\n包括流域尺度的统计，有助于确定SWAT模型是否生成合理结果\r\n\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(201, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(263, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "*input.std 输出文件包含了模型输入数据的信息\r\n";
            // 
            // groupBoxReadSWATOutput
            // 
            this.groupBoxReadSWATOutput.Controls.Add(this.label4);
            this.groupBoxReadSWATOutput.Controls.Add(this.label3);
            this.groupBoxReadSWATOutput.Controls.Add(this.checkBox3);
            this.groupBoxReadSWATOutput.Controls.Add(this.checkBox2);
            this.groupBoxReadSWATOutput.Controls.Add(this.checkBox1);
            this.groupBoxReadSWATOutput.Controls.Add(this.label1);
            this.groupBoxReadSWATOutput.Controls.Add(this.button4);
            this.groupBoxReadSWATOutput.Controls.Add(this.button3);
            this.groupBoxReadSWATOutput.Controls.Add(this.button2);
            this.groupBoxReadSWATOutput.Controls.Add(this.button1);
            this.groupBoxReadSWATOutput.Location = new System.Drawing.Point(12, 12);
            this.groupBoxReadSWATOutput.Name = "groupBoxReadSWATOutput";
            this.groupBoxReadSWATOutput.Size = new System.Drawing.Size(551, 242);
            this.groupBoxReadSWATOutput.TabIndex = 0;
            this.groupBoxReadSWATOutput.TabStop = false;
            this.groupBoxReadSWATOutput.Text = "输出结果管理";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 484);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(598, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ReadSWATOutput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 506);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxReadSWATOutput);
            this.Name = "ReadSWATOutput";
            this.Text = "读取SWAT输出结果";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxReadSWATOutput.ResumeLayout(false);
            this.groupBoxReadSWATOutput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxSimu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSaveSimu;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBoxReadSWATOutput;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}