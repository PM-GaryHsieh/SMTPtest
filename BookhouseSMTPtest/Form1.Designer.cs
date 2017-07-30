namespace BookhouseSMTPtest
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSMTP_USERNAME = new System.Windows.Forms.TextBox();
            this.txtSMTP_SENDERMAILNAME = new System.Windows.Forms.TextBox();
            this.txtSMTP_SENDERMAIL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSMTP_PASSWORD = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSMTP_USESSL = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSMTP_PATH = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSMTP_PORT = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 552);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 581);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(14, 518);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(249, 22);
            this.textBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 503);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "收件者";
            // 
            // txtSMTP_USERNAME
            // 
            this.txtSMTP_USERNAME.Location = new System.Drawing.Point(14, 171);
            this.txtSMTP_USERNAME.Name = "txtSMTP_USERNAME";
            this.txtSMTP_USERNAME.Size = new System.Drawing.Size(249, 22);
            this.txtSMTP_USERNAME.TabIndex = 3;
            // 
            // txtSMTP_SENDERMAILNAME
            // 
            this.txtSMTP_SENDERMAILNAME.Location = new System.Drawing.Point(12, 122);
            this.txtSMTP_SENDERMAILNAME.Name = "txtSMTP_SENDERMAILNAME";
            this.txtSMTP_SENDERMAILNAME.Size = new System.Drawing.Size(249, 22);
            this.txtSMTP_SENDERMAILNAME.TabIndex = 3;
            // 
            // txtSMTP_SENDERMAIL
            // 
            this.txtSMTP_SENDERMAIL.Location = new System.Drawing.Point(12, 74);
            this.txtSMTP_SENDERMAIL.Name = "txtSMTP_SENDERMAIL";
            this.txtSMTP_SENDERMAIL.Size = new System.Drawing.Size(249, 22);
            this.txtSMTP_SENDERMAIL.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "SMTP_USERNAME";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "SMTP_SENDERMAILNAME";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "SMTP_SENDERMAIL";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtSMTP_PASSWORD
            // 
            this.txtSMTP_PASSWORD.Location = new System.Drawing.Point(14, 226);
            this.txtSMTP_PASSWORD.Name = "txtSMTP_PASSWORD";
            this.txtSMTP_PASSWORD.Size = new System.Drawing.Size(249, 22);
            this.txtSMTP_PASSWORD.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "SMTP_PASSWORD";
            // 
            // txtSMTP_USESSL
            // 
            this.txtSMTP_USESSL.Location = new System.Drawing.Point(10, 281);
            this.txtSMTP_USESSL.Name = "txtSMTP_USESSL";
            this.txtSMTP_USESSL.Size = new System.Drawing.Size(249, 22);
            this.txtSMTP_USESSL.TabIndex = 7;
            this.txtSMTP_USESSL.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 12);
            this.label8.TabIndex = 6;
            this.label8.Text = "SMTP_USESSL";
            // 
            // txtSMTP_PATH
            // 
            this.txtSMTP_PATH.Location = new System.Drawing.Point(14, 345);
            this.txtSMTP_PATH.Name = "txtSMTP_PATH";
            this.txtSMTP_PATH.Size = new System.Drawing.Size(249, 22);
            this.txtSMTP_PATH.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 330);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 12);
            this.label9.TabIndex = 8;
            this.label9.Text = "SMTP_PATH";
            // 
            // txtSMTP_PORT
            // 
            this.txtSMTP_PORT.Location = new System.Drawing.Point(12, 400);
            this.txtSMTP_PORT.Name = "txtSMTP_PORT";
            this.txtSMTP_PORT.Size = new System.Drawing.Size(249, 22);
            this.txtSMTP_PORT.TabIndex = 11;
            this.txtSMTP_PORT.Text = "25";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 385);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 12);
            this.label10.TabIndex = 10;
            this.label10.Text = "SMTP_PORT";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 629);
            this.Controls.Add(this.txtSMTP_PORT);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtSMTP_PATH);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSMTP_USESSL);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSMTP_PASSWORD);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSMTP_SENDERMAIL);
            this.Controls.Add(this.txtSMTP_SENDERMAILNAME);
            this.Controls.Add(this.txtSMTP_USERNAME);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSMTP_USERNAME;
        private System.Windows.Forms.TextBox txtSMTP_SENDERMAILNAME;
        private System.Windows.Forms.TextBox txtSMTP_SENDERMAIL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSMTP_PASSWORD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSMTP_USESSL;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSMTP_PATH;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSMTP_PORT;
        private System.Windows.Forms.Label label10;
    }
}

