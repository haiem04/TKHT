using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TKHT.PControl;

namespace TKHT.PView
{
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(ControlAccount.login(textBox1.Text, textBox2.Text))
            {
                this.Hide();
                FAdmin f = new FAdmin();
                f.Show();
            }   
            else
            {
                MessageBox.Show("sai tai khoan hoac mat khau", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void button2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                if (ControlAccount.login(textBox1.Text, textBox2.Text))
                {
                    this.Hide();
                    FAdmin f = new FAdmin();
                    f.Show();
                }
                else
                {
                    MessageBox.Show("sai tai khoan hoac mat khau", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
