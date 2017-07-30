using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;

namespace BookhouseSMTPtest
{
    /// <summary>
    /// Smtp函式庫
    /// </summary>
    public static class SmtpHelper
    {
        public class SmtpConfig
        {
            /// <summary>
            /// SMTP位址
            /// </summary>
            public string SMTP_PATH { get; set; }
            /// <summary>
            /// SMTP埠號
            /// </summary>
            public string SMTP_PORT { get; set; }
            /// <summary>
            /// 寄件者郵件
            /// </summary>
            public string SMTP_SENDERMAIL { get; set; }
            /// <summary>
            /// 寄件者名稱
            /// </summary>
            public string SMTP_SENDERMAILNAME { get; set; }
            /// <summary>
            /// SMTP認證帳號
            /// </summary>
            public string SMTP_USERNAME { get; set; }
            /// <summary>
            /// SMTP認證密碼
            /// </summary>
            public string SMTP_PASSWORD { get; set; }
            /// <summary>
            /// 是否使用SSL
            /// </summary>
            public string SMTP_USESSL { get; set; }
            /// <summary>
            /// DOMAIN名稱
            /// </summary>
            public string SMTP_DOMAINNAME { get; set; }
            /// <summary>
            /// IIS路徑
            /// </summary>
            public string SMTP_IISPATH { get; set; }
            public string SMTP_BATCHNUM { get; set; }
        }

        /// <summary>
        /// SendMail
        /// </summary>
        /// <param name="toEmail">收件者</param>
        /// <param name="subject">主旨</param>
        /// <param name="content">內容</param>
        /// <param name="msg">錯誤回傳msg</param>
        /// <returns>true or false</returns>
        public static bool SendMail(SmtpConfig smtpConfig, List<string> toEmail, string subject, string content, out string msg, List<string> ccEmail = null, List<string> BccEmail = null)
        {
            msg = "";
            string smtp_sendermailname = string.Empty; //doc.SelectSingleNode("SaveObject/webtitle").InnerText;
            string smtp_sendermail = string.Empty;//doc.SelectSingleNode("SaveObject/mainAdminMail").InnerText;
            string smtp_host = "";
            string smtp_port = "";
            string maileDomainName = "";
            string smtp_username = "";
            string smtp_password = "";
            string smtp_usessl = string.Empty;

            if (!smtpConfig.SMTP_PATH.Equals(string.Empty))
            {
                smtp_host = smtpConfig.SMTP_PATH;
                smtp_port = smtpConfig.SMTP_PORT;
                maileDomainName = smtpConfig.SMTP_DOMAINNAME;
                smtp_sendermail = smtpConfig.SMTP_SENDERMAIL;
                smtp_sendermailname = smtpConfig.SMTP_SENDERMAILNAME;
                smtp_username = smtpConfig.SMTP_USERNAME;
                smtp_password = smtpConfig.SMTP_PASSWORD;
                smtp_usessl = smtpConfig.SMTP_USESSL;
            }
            string fromEmail = smtp_sendermail;
            string fromName = smtp_sendermailname;

            MailAddress from = new MailAddress(fromEmail, fromName, Encoding.Default);

            MailMessage mail = new MailMessage();

            mail.From = from;

            if (toEmail != null && toEmail.Count() > 0)
            {
                foreach (string addr in toEmail)
                {
                    mail.To.Add(new MailAddress(addr));
                }
            }
            else
            {
                msg = "無收件者信箱";
                return false;
            }

            if (ccEmail != null && ccEmail.Count() > 0)
            {
                foreach (string addr in ccEmail)
                {
                    mail.CC.Add(new MailAddress(addr));
                }
            }

            if (BccEmail != null && BccEmail.Count() > 0)
            {
                foreach (string addr in BccEmail)
                {
                    mail.Bcc.Add(new MailAddress(addr));
                }
            }

            mail.SubjectEncoding = Encoding.Default;
            mail.Subject = subject;
            mail.BodyEncoding = Encoding.Default;
            mail.Body = content;
            mail.IsBodyHtml = true;
            mail.Priority = MailPriority.Normal;

            SmtpClient client = new SmtpClient();
            client.Host = smtp_host;
            client.Timeout = 200000;
            client.UseDefaultCredentials = true;
            client.Port = int.Parse(smtp_port);
            client.EnableSsl = smtp_usessl.ToUpper().Equals("TRUE") || smtp_usessl.Equals("1");

            if (smtp_username != "")
            {
                client.Credentials = new NetworkCredential(smtp_username, smtp_password);
            }
            try
            {
                client.Send(mail);
                return true;
            }
            catch (Exception ex)
            {
                msg = ex.ToString();
                return false;
            }
        }

    }
}
