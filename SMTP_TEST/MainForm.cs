using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;

namespace SMTP_TEST
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            tbxSubject.Text = "SMTP at " + DateTime.Now.ToString();
            tbxBody.Text = "SMTP Body at " + DateTime.Now.ToString();
        }

        private void btnSmtpTest_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpClient client = new SmtpClient(tbxServer.Text); //cbsrvexc.tccb.gov.tr yeni mail sunucularinin ortak DNS adi
                client.EnableSsl = cbxUseSSL.Checked; //kullanicilarin SSL'li gelmesi lazim, yoksa authenticate olamazlar
                client.UseDefaultCredentials = cbxIsAnonymous.Checked;
                if (!cbxIsAnonymous.Checked)
                    client.Credentials = new System.Net.NetworkCredential(tbxUsername.Text, tbxPassword.Text); //cankaya domain kullanici adi ve sifresi girilmeli
                MailMessage message = new MailMessage(tbxSender.Text, tbxReceiver.Text, tbxSubject.Text, tbxBody.Text);
                client.Send(message);
                tbxResult.Text = "Success! \r\n" + DateTime.Now.ToString();
            }
            catch (Exception ex)
            {
                tbxResult.Text = ex.Message + "\r\n" + DateTime.Now.ToString();
            }

            tbxSubject.Text = "SMTP at " + DateTime.Now.ToString();
            tbxBody.Text = "SMTP Body at " + DateTime.Now.ToString();
        }

        private void cbxIsAnonymous_CheckedChanged(object sender, EventArgs e)
        {
            tbxUsername.Enabled = !cbxIsAnonymous.Checked;
            tbxPassword.Enabled = !cbxIsAnonymous.Checked;
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            btnSmtpTest.Width = MainForm.ActiveForm.Width - 34;
            tbxResult.Height = MainForm.ActiveForm.Height - 300;
            tbxResult.Width = MainForm.ActiveForm.Width - 34;

            tbxUsername.Width = (MainForm.ActiveForm.Width - 50) / 4;
            tbxPassword.Width = (MainForm.ActiveForm.Width - 50) / 4;
            tbxPassword.Location = new Point(tbxUsername.Width + 20, tbxPassword.Location.Y);
            label2.Location = new Point(tbxUsername.Width + 20, label2.Location.Y);

            tbxSender.Width = (MainForm.ActiveForm.Width - 50) / 2;
            tbxSender.Location = new Point(MainForm.ActiveForm.Width / 2, tbxPassword.Location.Y);
            label4.Location = new Point(MainForm.ActiveForm.Width / 2, label4.Location.Y);

            tbxServer.Width = (MainForm.ActiveForm.Width - 50) / 2;

            tbxReceiver.Width = (MainForm.ActiveForm.Width - 50) / 2;
            tbxReceiver.Location = new Point(MainForm.ActiveForm.Width / 2, tbxReceiver.Location.Y);
            label5.Location = new Point(MainForm.ActiveForm.Width / 2, label5.Location.Y);

            tbxSubject.Width = (MainForm.ActiveForm.Width - 50) / 2;

            tbxBody.Width = (MainForm.ActiveForm.Width - 50) / 2;
            tbxBody.Location = new Point(MainForm.ActiveForm.Width / 2, tbxBody.Location.Y);
            label6.Location = new Point(MainForm.ActiveForm.Width / 2, label6.Location.Y);
        }
    }
}
