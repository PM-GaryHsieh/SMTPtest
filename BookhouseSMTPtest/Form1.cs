using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BookhouseSMTPtest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Error;
            SmtpHelper.SmtpConfig con = new SmtpHelper.SmtpConfig();
            con.SMTP_PORT = "25";
            

            con.SMTP_SENDERMAIL = txtSMTP_SENDERMAIL.Text;
            con.SMTP_SENDERMAILNAME = txtSMTP_SENDERMAIL.Text;
            con.SMTP_USERNAME = txtSMTP_USERNAME.Text;
            con.SMTP_PASSWORD = txtSMTP_PASSWORD.Text;
            con.SMTP_USESSL = txtSMTP_USESSL.Text;
            con.SMTP_PATH = txtSMTP_PATH.Text;
            con.SMTP_PORT = txtSMTP_PORT.Text;


            var strarray = this.textBox1.Text.Split(',').ToList();
            var b = SmtpHelper.SendMail(con, strarray, "GaryTest", "test", out Error);
            label1.Text = b.ToString();
            label2.Text = Error;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
