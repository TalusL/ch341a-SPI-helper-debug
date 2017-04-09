namespace WindowsFormsApplication5
{
    partial class spihelper
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
            this.transport = new System.Windows.Forms.Button();
            this.dataw = new System.Windows.Forms.TextBox();
            this.datar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.countDataw = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.formatdw = new System.Windows.Forms.Button();
            this.cleardatar = new System.Windows.Forms.Button();
            this.claerdataw = new System.Windows.Forms.Button();
            this.close341 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.datalen = new System.Windows.Forms.TextBox();
            this.open341 = new System.Windows.Forms.Button();
            this.Message = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.about = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // transport
            // 
            this.transport.Enabled = false;
            this.transport.Location = new System.Drawing.Point(5, 121);
            this.transport.Name = "transport";
            this.transport.Size = new System.Drawing.Size(116, 23);
            this.transport.TabIndex = 0;
            this.transport.Text = "TranSport";
            this.transport.UseVisualStyleBackColor = true;
            this.transport.Click += new System.EventHandler(this.transport_Click);
            // 
            // dataw
            // 
            this.dataw.Enabled = false;
            this.dataw.Location = new System.Drawing.Point(6, 36);
            this.dataw.Multiline = true;
            this.dataw.Name = "dataw";
            this.dataw.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataw.Size = new System.Drawing.Size(479, 131);
            this.dataw.TabIndex = 1;
            this.dataw.Text = "FF";
            // 
            // datar
            // 
            this.datar.Enabled = false;
            this.datar.Location = new System.Drawing.Point(6, 185);
            this.datar.Multiline = true;
            this.datar.Name = "datar";
            this.datar.ReadOnly = true;
            this.datar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.datar.Size = new System.Drawing.Size(479, 136);
            this.datar.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "dataToWrite";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.countDataw);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dataw);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.datar);
            this.groupBox1.Location = new System.Drawing.Point(145, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 322);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "data";
            // 
            // countDataw
            // 
            this.countDataw.AutoSize = true;
            this.countDataw.Location = new System.Drawing.Point(361, 21);
            this.countDataw.Name = "countDataw";
            this.countDataw.Size = new System.Drawing.Size(41, 12);
            this.countDataw.TabIndex = 5;
            this.countDataw.Text = "count:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "dataReadBack";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.about);
            this.groupBox2.Controls.Add(this.formatdw);
            this.groupBox2.Controls.Add(this.cleardatar);
            this.groupBox2.Controls.Add(this.claerdataw);
            this.groupBox2.Controls.Add(this.close341);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.datalen);
            this.groupBox2.Controls.Add(this.open341);
            this.groupBox2.Controls.Add(this.transport);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(127, 322);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ctrl";
            // 
            // formatdw
            // 
            this.formatdw.Enabled = false;
            this.formatdw.Location = new System.Drawing.Point(6, 150);
            this.formatdw.Name = "formatdw";
            this.formatdw.Size = new System.Drawing.Size(115, 23);
            this.formatdw.TabIndex = 8;
            this.formatdw.Text = "format Dataw";
            this.formatdw.UseVisualStyleBackColor = true;
            this.formatdw.Click += new System.EventHandler(this.formatdw_Click);
            // 
            // cleardatar
            // 
            this.cleardatar.Enabled = false;
            this.cleardatar.Location = new System.Drawing.Point(5, 208);
            this.cleardatar.Name = "cleardatar";
            this.cleardatar.Size = new System.Drawing.Size(116, 23);
            this.cleardatar.TabIndex = 7;
            this.cleardatar.Text = "Clear DataR";
            this.cleardatar.UseVisualStyleBackColor = true;
            this.cleardatar.Click += new System.EventHandler(this.cleardatar_Click);
            // 
            // claerdataw
            // 
            this.claerdataw.Enabled = false;
            this.claerdataw.Location = new System.Drawing.Point(5, 179);
            this.claerdataw.Name = "claerdataw";
            this.claerdataw.Size = new System.Drawing.Size(116, 23);
            this.claerdataw.TabIndex = 6;
            this.claerdataw.Text = "Clear DataW";
            this.claerdataw.UseVisualStyleBackColor = true;
            this.claerdataw.Click += new System.EventHandler(this.claerdataw_Click);
            // 
            // close341
            // 
            this.close341.Enabled = false;
            this.close341.Location = new System.Drawing.Point(5, 49);
            this.close341.Name = "close341";
            this.close341.Size = new System.Drawing.Size(116, 23);
            this.close341.TabIndex = 5;
            this.close341.Text = "closeCh341A";
            this.close341.UseVisualStyleBackColor = true;
            this.close341.Click += new System.EventHandler(this.close341_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "R\\W length(<2048)";
            // 
            // datalen
            // 
            this.datalen.Enabled = false;
            this.datalen.Location = new System.Drawing.Point(5, 94);
            this.datalen.Name = "datalen";
            this.datalen.Size = new System.Drawing.Size(116, 21);
            this.datalen.TabIndex = 3;
            this.datalen.Text = "1";
            // 
            // open341
            // 
            this.open341.Location = new System.Drawing.Point(6, 19);
            this.open341.Name = "open341";
            this.open341.Size = new System.Drawing.Size(115, 23);
            this.open341.TabIndex = 1;
            this.open341.Text = "openCh341A";
            this.open341.UseVisualStyleBackColor = true;
            this.open341.Click += new System.EventHandler(this.open341_Click);
            // 
            // Message
            // 
            this.Message.AutoSize = true;
            this.Message.Location = new System.Drawing.Point(63, 343);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(0, 12);
            this.Message.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "Message:";
            // 
            // about
            // 
            this.about.Location = new System.Drawing.Point(5, 238);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(116, 23);
            this.about.TabIndex = 9;
            this.about.Text = "about";
            this.about.UseVisualStyleBackColor = true;
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // spihelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 364);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(666, 403);
            this.MinimumSize = new System.Drawing.Size(666, 403);
            this.Name = "spihelper";
            this.Text = "Ch341A SPI Debugger";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button transport;
        private System.Windows.Forms.TextBox dataw;
        private System.Windows.Forms.TextBox datar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox datalen;
        private System.Windows.Forms.Button open341;
        private System.Windows.Forms.Label Message;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button close341;
        private System.Windows.Forms.Button cleardatar;
        private System.Windows.Forms.Button claerdataw;
        private System.Windows.Forms.Label countDataw;
        private System.Windows.Forms.Button formatdw;
        private System.Windows.Forms.Button about;
    }
}

