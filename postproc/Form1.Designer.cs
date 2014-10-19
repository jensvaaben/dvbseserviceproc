namespace postproc
{
    partial class Form1
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
            this.buttonProcess = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFile = new System.Windows.Forms.TextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMethod = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxStatusCode = new System.Windows.Forms.TextBox();
            this.textBoxResponseBody = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxNetworkType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxContentType = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonProcess
            // 
            this.buttonProcess.Location = new System.Drawing.Point(19, 436);
            this.buttonProcess.Name = "buttonProcess";
            this.buttonProcess.Size = new System.Drawing.Size(75, 23);
            this.buttonProcess.TabIndex = 0;
            this.buttonProcess.Text = "Process";
            this.buttonProcess.UseVisualStyleBackColor = true;
            this.buttonProcess.Click += new System.EventHandler(this.buttonProcess_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "File";
            // 
            // textBoxFile
            // 
            this.textBoxFile.Location = new System.Drawing.Point(44, 21);
            this.textBoxFile.Name = "textBoxFile";
            this.textBoxFile.Size = new System.Drawing.Size(208, 20);
            this.textBoxFile.TabIndex = 2;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(284, 20);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowse.TabIndex = 3;
            this.buttonBrowse.Text = "Browse...";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "URL";
            // 
            // textBoxURL
            // 
            this.textBoxURL.Location = new System.Drawing.Point(49, 76);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(208, 20);
            this.textBoxURL.TabIndex = 5;
            this.textBoxURL.TextChanged += new System.EventHandler(this.textBoxURL_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Method";
            // 
            // textBoxMethod
            // 
            this.textBoxMethod.Location = new System.Drawing.Point(65, 112);
            this.textBoxMethod.Name = "textBoxMethod";
            this.textBoxMethod.Size = new System.Drawing.Size(100, 20);
            this.textBoxMethod.TabIndex = 7;
            this.textBoxMethod.TextChanged += new System.EventHandler(this.textBoxMethod_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Status";
            // 
            // textBoxStatusCode
            // 
            this.textBoxStatusCode.Location = new System.Drawing.Point(78, 173);
            this.textBoxStatusCode.Name = "textBoxStatusCode";
            this.textBoxStatusCode.ReadOnly = true;
            this.textBoxStatusCode.Size = new System.Drawing.Size(281, 20);
            this.textBoxStatusCode.TabIndex = 9;
            // 
            // textBoxResponseBody
            // 
            this.textBoxResponseBody.Location = new System.Drawing.Point(78, 199);
            this.textBoxResponseBody.Multiline = true;
            this.textBoxResponseBody.Name = "textBoxResponseBody";
            this.textBoxResponseBody.ReadOnly = true;
            this.textBoxResponseBody.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResponseBody.Size = new System.Drawing.Size(281, 226);
            this.textBoxResponseBody.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Network type";
            // 
            // comboBoxNetworkType
            // 
            this.comboBoxNetworkType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNetworkType.FormattingEnabled = true;
            this.comboBoxNetworkType.Items.AddRange(new object[] {
            "DVB-S",
            "DVB-T",
            "DVB-C"});
            this.comboBoxNetworkType.Location = new System.Drawing.Point(96, 47);
            this.comboBoxNetworkType.Name = "comboBoxNetworkType";
            this.comboBoxNetworkType.Size = new System.Drawing.Size(141, 21);
            this.comboBoxNetworkType.TabIndex = 12;
            this.comboBoxNetworkType.SelectedIndexChanged += new System.EventHandler(this.comboBoxNetworkType_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Content-Type";
            // 
            // textBoxContentType
            // 
            this.textBoxContentType.Location = new System.Drawing.Point(97, 144);
            this.textBoxContentType.Name = "textBoxContentType";
            this.textBoxContentType.Size = new System.Drawing.Size(190, 20);
            this.textBoxContentType.TabIndex = 14;
            this.textBoxContentType.TextChanged += new System.EventHandler(this.textBoxContentType_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(110, 441);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Copyright 2014 Jens Vaaben";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 476);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxContentType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxNetworkType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxResponseBody);
            this.Controls.Add(this.textBoxStatusCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxMethod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxURL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.textBoxFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonProcess);
            this.Name = "Form1";
            this.Text = "DVBSE service file processor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonProcess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFile;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMethod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxStatusCode;
        private System.Windows.Forms.TextBox textBoxResponseBody;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxNetworkType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxContentType;
        private System.Windows.Forms.Label label7;
    }
}

