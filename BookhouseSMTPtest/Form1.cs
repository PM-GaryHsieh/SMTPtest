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
            //con.SMTP_SENDERMAIL = "academic60@qmail.nutc.edu.tw";
            //con.SMTP_SENDERMAILNAME = "academic60";
            //con.SMTP_USERNAME = "academic60";
            //con.SMTP_PASSWORD = "nutc1116";
            //con.SMTP_USESSL = "0";
            //con.SMTP_PATH = "qmail.nutc.edu.tw";

            //con.SMTP_SENDERMAIL = "dms_service@iscom.com.tw";
            //con.SMTP_SENDERMAILNAME = "dms_service";
            //con.SMTP_USERNAME = "dms_service@iscom.com.tw";
            //con.SMTP_PASSWORD = "IScom@123";
            //con.SMTP_USESSL = "0";
            //con.SMTP_PATH = "mail.iscom.com.tw";

            //con.SMTP_SENDERMAIL = "h105001@chash.chc.edu.tw";
            //con.SMTP_SENDERMAILNAME = "h105001";
            //con.SMTP_USERNAME = "h105001@chash.chc.edu.tw";
            //con.SMTP_PASSWORD = "chash@2016";
            //con.SMTP_USESSL = "1";
            //con.SMTP_PATH = "smtp.gmail.com";
            //con.SMTP_PORT = "587";

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
