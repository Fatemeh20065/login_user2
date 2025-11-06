using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                textBox1.PasswordChar = '\0';
            }
            else
            {
                textBox1.PasswordChar = '*';
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.PasswordChar = '*';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                MessageBox.Show("hello student", "welcom", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (radioButton2.Checked)
            {
                MessageBox.Show("hello teacher", "welcom", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (radioButton3.Checked)
            {
                MessageBox.Show("hello manager", "welcom", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
