using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            //comboBox1.Items.Add("smtp.qq.com");
            //comboBox1.Items.Add("smtp.gmail.com");
            //comboBox1.Items.Add("smtp.163.com");

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            //comboBox2.Items.Add("@qq.com");
            //comboBox2.Items.Add("@gmail.com");
            //comboBox2.Items.Add("@163.com");

            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            //comboBox3.Items.Add("@qq.com");
            //comboBox3.Items.Add("@gmail.com");
            //comboBox3.Items.Add("@live.com");
            //comboBox3.Items.Add("@163.com");
            //comboBox3.Items.Add("@outlook.com");
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;

            RegistryKey root = Registry.LocalMachine;
            RegistryKey software = root.OpenSubKey("SOFTWARE", true);
            RegistryKey myresigtry = software.OpenSubKey("MYRESIGTRY", true);
            comboBox1.SelectedIndex = Convert.ToInt32(myresigtry.GetValue("fristserver"));
            comboBox2.SelectedIndex = Convert.ToInt32(myresigtry.GetValue("fristserver"));
            comboBox3.SelectedIndex = Convert.ToInt32(myresigtry.GetValue("tfristserver"));
            textBox1.Text = Convert.ToString(myresigtry.GetValue("ffristname"));
            textBox4.Text = Convert.ToString(myresigtry.GetValue("tfristname"));
            textBox5.Text = Convert.ToString(myresigtry.GetValue("tfristemail"));
            textBox2.Text = Convert.ToString(myresigtry.GetValue("ffristid"));
            textBox3.Text = Convert.ToString(myresigtry.GetValue("ffristpassword"));
            root.Close();
        }

        private void defaultButton_Click(object sender, EventArgs e)
        {
            RegistryKey root = Registry.LocalMachine;
            RegistryKey software = root.OpenSubKey("SOFTWARE", true);
            RegistryKey myresigtry = software.OpenSubKey("MYRESIGTRY", true);
            //MessageBox.Show(comboBox1.SelectedIndex.ToString());

            myresigtry.SetValue("fristserver", comboBox1.SelectedIndex.ToString());
            myresigtry.SetValue("ffristname", textBox1.Text);
            myresigtry.SetValue("ffristid", textBox2.Text);
            myresigtry.SetValue("ffristpassword", textBox3.Text);
            myresigtry.SetValue("fristserver", comboBox1.SelectedIndex.ToString());
            myresigtry.SetValue("tfristname", textBox4.Text);
            myresigtry.SetValue("tfristemail", textBox5.Text);
            myresigtry.SetValue("tfristserver", comboBox3.SelectedIndex.ToString());
            root.Close();
            MessageBox.Show("设置成功！重启生效");
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            RegistryKey root = Registry.LocalMachine;
            RegistryKey software = root.OpenSubKey("SOFTWARE", true);

            RegistryKey myresigtry = software.CreateSubKey("MYRESIGTRY");
            myresigtry.SetValue("fristserver", "0");
            myresigtry.SetValue("ffristname", "");
            myresigtry.SetValue("ffristid", "");
            myresigtry.SetValue("ffristpassword", "");
            myresigtry.SetValue("tfristname", "");
            myresigtry.SetValue("tfristemail", "");
            myresigtry.SetValue("tfristserver", "0");
            MessageBox.Show("设置成功！重启生效");
            root.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
