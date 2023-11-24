using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace مشروع_البيع
{
    public partial class login : DevExpress.XtraEditors.XtraForm
    {
        public login()
        {
            InitializeComponent();
            textnamelog.Select();
            
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void btnout_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            classuser use = new classuser();
            use.Login(textnamelog.Text, textpasslog.Text);
            Close();
            
           
            if (textnamelog.Text == "sam.m2020" && textpasslog.Text == "77313")

            {
                MessageBox.Show(" اهلا بكم تم التسجيل بنحاح ");

                var frm = Application.OpenForms["form1"] as Form1;
               

                frm.btnlogout.Enabled = true;
                frm.storage.Enabled = true;
                frm.sale.Enabled = true;
                frm.buy.Enabled = true;
                frm.source.Enabled = true;
                frm.users.Enabled = true;
                frm.custmer.Enabled = true;
                frm.btnlogin.Enabled = false;
                frm.btnstting.Enabled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                e.Handled = true;
                textpasslog.Focus();
            }
        }

        private void login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textpasslog.Focus();
            }
            else if  ( e.KeyCode.Equals(Keys.Up))
            
                    {
                e.Handled = true;
                textnamelog.Focus();
            }



        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                e.Handled = true;
                btnlogin.PerformClick();
            }
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            textpasslog.UseSystemPasswordChar = false;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            textpasslog.UseSystemPasswordChar = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
