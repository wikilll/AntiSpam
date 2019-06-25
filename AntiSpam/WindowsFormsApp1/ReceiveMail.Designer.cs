namespace WindowsFormsApp1
{
    partial class ReceiveMail
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.refreshMailButton = new System.Windows.Forms.Button();
            this.readMailButton = new System.Windows.Forms.Button();
            this.receiveMailGroupBox = new System.Windows.Forms.GroupBox();
            this.deleteMailButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mailDetailGroupBox = new System.Windows.Forms.GroupBox();
            this.returnButton = new System.Windows.Forms.Button();
            this.mailDetailRichTextBox = new System.Windows.Forms.RichTextBox();
            this.replyMailButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.receiveMailGroupBox.SuspendLayout();
            this.panel2.SuspendLayout();
            this.mailDetailGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.refreshMailButton);
            this.panel1.Controls.Add(this.readMailButton);
            this.panel1.Controls.Add(this.receiveMailGroupBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 426);
            this.panel1.TabIndex = 0;
            // 
            // refreshMailButton
            // 
            this.refreshMailButton.Location = new System.Drawing.Point(151, 385);
            this.refreshMailButton.Name = "refreshMailButton";
            this.refreshMailButton.Size = new System.Drawing.Size(80, 30);
            this.refreshMailButton.TabIndex = 2;
            this.refreshMailButton.Text = "刷新";
            this.refreshMailButton.UseVisualStyleBackColor = true;
            // 
            // readMailButton
            // 
            this.readMailButton.Location = new System.Drawing.Point(9, 385);
            this.readMailButton.Name = "readMailButton";
            this.readMailButton.Size = new System.Drawing.Size(80, 30);
            this.readMailButton.TabIndex = 1;
            this.readMailButton.Text = "阅读邮件";
            this.readMailButton.UseVisualStyleBackColor = true;
            this.readMailButton.Click += new System.EventHandler(this.readMailButton_Click);
            // 
            // receiveMailGroupBox
            // 
            this.receiveMailGroupBox.Controls.Add(this.deleteMailButton);
            this.receiveMailGroupBox.Controls.Add(this.listView1);
            this.receiveMailGroupBox.Location = new System.Drawing.Point(3, 3);
            this.receiveMailGroupBox.Name = "receiveMailGroupBox";
            this.receiveMailGroupBox.Size = new System.Drawing.Size(374, 420);
            this.receiveMailGroupBox.TabIndex = 0;
            this.receiveMailGroupBox.TabStop = false;
            this.receiveMailGroupBox.Text = "收件箱";
            this.receiveMailGroupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // deleteMailButton
            // 
            this.deleteMailButton.Location = new System.Drawing.Point(288, 382);
            this.deleteMailButton.Name = "deleteMailButton";
            this.deleteMailButton.Size = new System.Drawing.Size(80, 30);
            this.deleteMailButton.TabIndex = 3;
            this.deleteMailButton.Text = "删除";
            this.deleteMailButton.UseVisualStyleBackColor = true;
            this.deleteMailButton.Click += new System.EventHandler(this.deleteMailButton_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(6, 24);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(362, 306);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.mailDetailGroupBox);
            this.panel2.Location = new System.Drawing.Point(398, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(390, 425);
            this.panel2.TabIndex = 1;
            // 
            // mailDetailGroupBox
            // 
            this.mailDetailGroupBox.Controls.Add(this.returnButton);
            this.mailDetailGroupBox.Controls.Add(this.mailDetailRichTextBox);
            this.mailDetailGroupBox.Controls.Add(this.replyMailButton);
            this.mailDetailGroupBox.Location = new System.Drawing.Point(3, 4);
            this.mailDetailGroupBox.Name = "mailDetailGroupBox";
            this.mailDetailGroupBox.Size = new System.Drawing.Size(384, 418);
            this.mailDetailGroupBox.TabIndex = 0;
            this.mailDetailGroupBox.TabStop = false;
            this.mailDetailGroupBox.Text = "详情";
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(262, 379);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(80, 29);
            this.returnButton.TabIndex = 3;
            this.returnButton.Text = "返回";
            this.returnButton.UseVisualStyleBackColor = true;
            // 
            // mailDetailRichTextBox
            // 
            this.mailDetailRichTextBox.Location = new System.Drawing.Point(7, 22);
            this.mailDetailRichTextBox.Name = "mailDetailRichTextBox";
            this.mailDetailRichTextBox.Size = new System.Drawing.Size(371, 306);
            this.mailDetailRichTextBox.TabIndex = 0;
            this.mailDetailRichTextBox.Text = "";
            // 
            // replyMailButton
            // 
            this.replyMailButton.Location = new System.Drawing.Point(39, 379);
            this.replyMailButton.Name = "replyMailButton";
            this.replyMailButton.Size = new System.Drawing.Size(80, 30);
            this.replyMailButton.TabIndex = 1;
            this.replyMailButton.Text = "回复";
            this.replyMailButton.UseVisualStyleBackColor = true;
            // 
            // ReceiveMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ReceiveMail";
            this.Text = "ReceiveMail";
            this.panel1.ResumeLayout(false);
            this.receiveMailGroupBox.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.mailDetailGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox receiveMailGroupBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button refreshMailButton;
        private System.Windows.Forms.Button readMailButton;
        private System.Windows.Forms.Button deleteMailButton;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox mailDetailGroupBox;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.RichTextBox mailDetailRichTextBox;
        private System.Windows.Forms.Button replyMailButton;
    }
}