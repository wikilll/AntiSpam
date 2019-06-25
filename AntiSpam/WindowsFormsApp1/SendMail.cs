using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SendMail : Form
    {
        // 定义邮件发送类
        private SmtpClient smtpClient;
        private TcpClient tcpClient;
        private NetworkStream networkStream;
        private StreamReader streamReader;
        private StreamWriter streamWriter;

        public SendMail()
        {
            InitializeComponent();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            // 实例化一个发送的邮件
            // 相当于与现实生活中先写信，程序中把信（邮件）抽象为邮件类了
            MailMessage mailMessage = new MailMessage();
            // 指明邮件发送的地址，主题，内容等信息
            // 发信人的地址为登录收发器的地址，这个收发器相当于我们平时Web版的邮箱或者是OutLook中配置的邮箱
            mailMessage.From = new MailAddress(tbxUserMail.Text);   //tbxUserMail获取之前登陆中的用户名
            mailMessage.To.Add(receiverText.Text);
            mailMessage.Subject = subjectText.Text;
            mailMessage.SubjectEncoding = Encoding.Default;
            mailMessage.Body = richTextBox.Text;
            mailMessage.BodyEncoding = Encoding.Default;
            // 设置邮件正文不是Html格式的内容
            mailMessage.IsBodyHtml = false;
            // 设置邮件的优先级为普通优先级
            mailMessage.Priority = MailPriority.Normal;
            //mailMessage.ReplyTo = new MailAddress(tbxUserMail.Text);

            // 发送写好的邮件
            try
            {
                // SmtpClient类用于将邮件发送到SMTP服务器
                // 该类封装了SMTP协议的实现，
                // 通过该类可以简化发送邮件的过程，只需要调用该类的Send方法就可以发送邮件到SMTP服务器了。
                smtpClient.Send(mailMessage);
                MessageBox.Show("邮件发送成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (SmtpException smtpError)
            {
                MessageBox.Show("邮件发送失败：[" + smtpError.StatusCode + "]；["
                    + smtpError.Message + "];\r\n[" + smtpError.StackTrace + "]."
                    , "错误", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            finally
            {
                mailMessage.Dispose();
                this.Cursor = Cursors.Default;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
