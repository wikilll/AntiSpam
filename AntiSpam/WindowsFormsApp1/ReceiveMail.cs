using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// 添加命名空间
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Net.Sockets;
using System.IO;
using jmail;



// 接收邮件和显示邮件内容的窗口

namespace WindowsFormsApp1
{
    public partial class ReceiveMail : Form
    {
        // 定义接收邮件对象
        private POP3Class popClient;

        // 定义邮件信息接口
        private jmail.Message messageMail;

        // 接收邮件界面界面初始化
        public ReceiveMail()
        {
            InitializeComponent();

            replyMailButton.Enabled = false;    // 刚进入时未选择邮件，无法回复，其他控件正常使用

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        // 读取邮件内容
        private void readMailButton_Click(object sender, EventArgs e)
        {

        }

        // 删除邮件
        private void deleteMailButton_Click(object sender, EventArgs e)
        {
            //if (lstViewMailList.SelectedItems.Count == 0)
            //{
            //    MessageBox.Show("请先选择阅读的邮件！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}

            //int index = lstViewMailList.SelectedItems[0].Index;
            //messageMail = popClient.Messages[index + 1];
            //if (MessageBox.Show("确认要删除邮件" + messageMail.Subject + "吗？", "删除确认", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            //{
            //    popClient.DeleteSingleMessage(index + 1);
            //    popClient.Disconnect();
            //    btnRefreshMailList.PerformClick();
            //}
        }
    }
}
