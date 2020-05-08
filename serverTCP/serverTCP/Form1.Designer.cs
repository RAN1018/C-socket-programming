namespace serverTCP
{
    partial class Server
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
            this.textBoxDisplay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonService = new System.Windows.Forms.Button();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.IP = new System.Windows.Forms.Label();
            this.labelIP = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxListen = new System.Windows.Forms.ComboBox();
            this.textBoxSend = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.buttonFlash = new System.Windows.Forms.Button();
            this.buttonFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxDisplay
            // 
            this.textBoxDisplay.AcceptsReturn = true;
            this.textBoxDisplay.Location = new System.Drawing.Point(290, 12);
            this.textBoxDisplay.Multiline = true;
            this.textBoxDisplay.Name = "textBoxDisplay";
            this.textBoxDisplay.ReadOnly = true;
            this.textBoxDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDisplay.Size = new System.Drawing.Size(424, 426);
            this.textBoxDisplay.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Port";
            // 
            // buttonService
            // 
            this.buttonService.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonService.Location = new System.Drawing.Point(29, 167);
            this.buttonService.Name = "buttonService";
            this.buttonService.Size = new System.Drawing.Size(236, 38);
            this.buttonService.TabIndex = 2;
            this.buttonService.Text = "Start Listening";
            this.buttonService.UseVisualStyleBackColor = true;
            this.buttonService.Click += new System.EventHandler(this.buttonService_Click);
            // 
            // textBoxPort
            // 
            this.textBoxPort.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPort.Location = new System.Drawing.Point(82, 49);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(115, 30);
            this.textBoxPort.TabIndex = 3;
            // 
            // IP
            // 
            this.IP.AutoSize = true;
            this.IP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IP.Location = new System.Drawing.Point(24, 11);
            this.IP.Name = "IP";
            this.IP.Size = new System.Drawing.Size(29, 23);
            this.IP.TabIndex = 4;
            this.IP.Text = "IP";
            // 
            // labelIP
            // 
            this.labelIP.AutoSize = true;
            this.labelIP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIP.Location = new System.Drawing.Point(61, 12);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(65, 22);
            this.labelIP.TabIndex = 6;
            this.labelIP.Text = "0.0.0.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Waiting List";
            // 
            // comboBoxListen
            // 
            this.comboBoxListen.DisplayMember = "1";
            this.comboBoxListen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxListen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxListen.FormattingEnabled = true;
            this.comboBoxListen.Items.AddRange(new object[] {
            "1",
            "5",
            "10",
            "20",
            "50",
            "100"});
            this.comboBoxListen.Location = new System.Drawing.Point(143, 112);
            this.comboBoxListen.Name = "comboBoxListen";
            this.comboBoxListen.Size = new System.Drawing.Size(121, 30);
            this.comboBoxListen.TabIndex = 8;
            this.comboBoxListen.Tag = "";
            this.comboBoxListen.ValueMember = "1";
            // 
            // textBoxSend
            // 
            this.textBoxSend.Location = new System.Drawing.Point(29, 239);
            this.textBoxSend.Name = "textBoxSend";
            this.textBoxSend.Size = new System.Drawing.Size(237, 25);
            this.textBoxSend.TabIndex = 9;
            // 
            // buttonSend
            // 
            this.buttonSend.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSend.Location = new System.Drawing.Point(29, 287);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(237, 37);
            this.buttonSend.TabIndex = 10;
            this.buttonSend.Text = "Send Message";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // buttonFlash
            // 
            this.buttonFlash.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFlash.Location = new System.Drawing.Point(29, 342);
            this.buttonFlash.Name = "buttonFlash";
            this.buttonFlash.Size = new System.Drawing.Size(237, 37);
            this.buttonFlash.TabIndex = 11;
            this.buttonFlash.Text = "Flashing";
            this.buttonFlash.UseVisualStyleBackColor = true;
            this.buttonFlash.Click += new System.EventHandler(this.buttonFlash_Click);
            // 
            // buttonFile
            // 
            this.buttonFile.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFile.Location = new System.Drawing.Point(29, 393);
            this.buttonFile.Name = "buttonFile";
            this.buttonFile.Size = new System.Drawing.Size(237, 37);
            this.buttonFile.TabIndex = 12;
            this.buttonFile.Text = "Send File";
            this.buttonFile.UseVisualStyleBackColor = true;
            this.buttonFile.Click += new System.EventHandler(this.buttonFile_Click);
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 450);
            this.Controls.Add(this.buttonFile);
            this.Controls.Add(this.buttonFlash);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.textBoxSend);
            this.Controls.Add(this.comboBoxListen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelIP);
            this.Controls.Add(this.IP);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.buttonService);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDisplay);
            this.Name = "Server";
            this.Text = "Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonService;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Label IP;
        private System.Windows.Forms.Label labelIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxListen;
        private System.Windows.Forms.TextBox textBoxSend;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button buttonFlash;
        private System.Windows.Forms.Button buttonFile;
    }
}

