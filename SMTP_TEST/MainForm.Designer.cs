namespace SMTP_TEST
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnSmtpTest = new System.Windows.Forms.Button();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.cbxIsAnonymous = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxServer = new System.Windows.Forms.TextBox();
            this.tbxResult = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxSender = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxReceiver = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxBody = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxSubject = new System.Windows.Forms.TextBox();
            this.cbxUseSSL = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnSmtpTest
            // 
            this.btnSmtpTest.Location = new System.Drawing.Point(10, 190);
            this.btnSmtpTest.Name = "btnSmtpTest";
            this.btnSmtpTest.Size = new System.Drawing.Size(416, 45);
            this.btnSmtpTest.TabIndex = 0;
            this.btnSmtpTest.Text = "SMTP Test";
            this.btnSmtpTest.UseVisualStyleBackColor = true;
            this.btnSmtpTest.Click += new System.EventHandler(this.btnSmtpTest_Click);
            // 
            // tbxUsername
            // 
            this.tbxUsername.Location = new System.Drawing.Point(10, 40);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(100, 20);
            this.tbxUsername.TabIndex = 1;
            this.tbxUsername.Text = "cankaya\\exctest";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(120, 40);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(100, 20);
            this.tbxPassword.TabIndex = 3;
            this.tbxPassword.Text = "1234";
            this.tbxPassword.UseSystemPasswordChar = true;
            // 
            // cbxIsAnonymous
            // 
            this.cbxIsAnonymous.AutoSize = true;
            this.cbxIsAnonymous.Location = new System.Drawing.Point(10, 163);
            this.cbxIsAnonymous.Name = "cbxIsAnonymous";
            this.cbxIsAnonymous.Size = new System.Drawing.Size(98, 17);
            this.cbxIsAnonymous.TabIndex = 5;
            this.cbxIsAnonymous.Text = "Is Anonymous?";
            this.cbxIsAnonymous.UseVisualStyleBackColor = true;
            this.cbxIsAnonymous.CheckedChanged += new System.EventHandler(this.cbxIsAnonymous_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Server";
            // 
            // tbxServer
            // 
            this.tbxServer.Location = new System.Drawing.Point(10, 86);
            this.tbxServer.Name = "tbxServer";
            this.tbxServer.Size = new System.Drawing.Size(210, 20);
            this.tbxServer.TabIndex = 6;
            this.tbxServer.Text = "cbsrvexc.tccb.gov.tr";
            // 
            // tbxResult
            // 
            this.tbxResult.Location = new System.Drawing.Point(10, 250);
            this.tbxResult.Multiline = true;
            this.tbxResult.Name = "tbxResult";
            this.tbxResult.Size = new System.Drawing.Size(416, 74);
            this.tbxResult.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(225, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Sender";
            // 
            // tbxSender
            // 
            this.tbxSender.Location = new System.Drawing.Point(225, 40);
            this.tbxSender.Name = "tbxSender";
            this.tbxSender.Size = new System.Drawing.Size(200, 20);
            this.tbxSender.TabIndex = 9;
            this.tbxSender.Text = "exctest@tccb.gov.tr";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(225, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Receiver";
            // 
            // tbxReceiver
            // 
            this.tbxReceiver.Location = new System.Drawing.Point(225, 86);
            this.tbxReceiver.Name = "tbxReceiver";
            this.tbxReceiver.Size = new System.Drawing.Size(200, 20);
            this.tbxReceiver.TabIndex = 11;
            this.tbxReceiver.Text = "cbolukbas@tccb.gov.tr";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(225, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Body";
            // 
            // tbxBody
            // 
            this.tbxBody.Location = new System.Drawing.Point(225, 129);
            this.tbxBody.Multiline = true;
            this.tbxBody.Name = "tbxBody";
            this.tbxBody.Size = new System.Drawing.Size(200, 50);
            this.tbxBody.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Subject";
            // 
            // tbxSubject
            // 
            this.tbxSubject.Location = new System.Drawing.Point(10, 129);
            this.tbxSubject.Name = "tbxSubject";
            this.tbxSubject.Size = new System.Drawing.Size(210, 20);
            this.tbxSubject.TabIndex = 13;
            // 
            // cbxUseSSL
            // 
            this.cbxUseSSL.AutoSize = true;
            this.cbxUseSSL.Checked = true;
            this.cbxUseSSL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxUseSSL.Location = new System.Drawing.Point(150, 163);
            this.cbxUseSSL.Name = "cbxUseSSL";
            this.cbxUseSSL.Size = new System.Drawing.Size(68, 17);
            this.cbxUseSSL.TabIndex = 17;
            this.cbxUseSSL.Text = "Use SSL";
            this.cbxUseSSL.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 336);
            this.Controls.Add(this.cbxUseSSL);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbxBody);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbxSubject);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxReceiver);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxSender);
            this.Controls.Add(this.tbxResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxServer);
            this.Controls.Add(this.cbxIsAnonymous);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxUsername);
            this.Controls.Add(this.btnSmtpTest);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(450, 374);
            this.Name = "MainForm";
            this.Text = "SMTP Test";
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSmtpTest;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.CheckBox cbxIsAnonymous;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxServer;
        private System.Windows.Forms.TextBox tbxResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxSender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxReceiver;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxBody;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxSubject;
        private System.Windows.Forms.CheckBox cbxUseSSL;
    }
}

