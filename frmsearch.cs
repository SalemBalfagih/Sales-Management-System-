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
    public partial class frmsearch : DevExpress.XtraEditors.XtraForm
    {
        public frmsearch()
        {
            InitializeComponent();

            frmprodact frm = new frmprodact();
            classprodact clsp = new classprodact();
            clsp.loadpublic("loadVprodactitem");
           frm.gcprodact.DataSource = clsp.dtpublic;
           dgvprosearch.DataSource = clsp.dtpublic;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
           
               if(this.Text=="مشتريات")
            {
                if (e.KeyCode == Keys.Enter)
                {
                    var frm = Application.OpenForms["frmbuys"] as frmbuys;
                    frm.textcode.Text = dgvprosearch.CurrentRow.Cells[1].Value.ToString();
                    SendKeys.Send("{ENTER }");
                    this.Close();
                }
                else
                {
                    if (e.KeyCode == Keys.Enter)
                    {
                        var frm = Application.OpenForms["frmsales"] as frmsales;
                        frm.textcode.Text = dgvprosearch.CurrentRow.Cells[1].Value.ToString();
                        SendKeys.Send("{ENTER }");
                        this.Close();
                    }
                }
      
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.Text == "مشتريات")
            {
                if (e.KeyCode == Keys.Enter)
                {
                    var frm = Application.OpenForms["frmbuys"] as frmbuys;
                    frm.textcode.Text = dgvprosearch.CurrentRow.Cells[1].Value.ToString();
                    SendKeys.Send("{ENTER }");
                    this.Close();
                }
                else
                {
                    if (e.KeyCode == Keys.Enter)
                    {
                        var frm = Application.OpenForms["frmsales"] as frmsales;
                        frm.textcode.Text = dgvprosearch.CurrentRow.Cells[1].Value.ToString();
                        SendKeys.Send("{ENTER }");
                        this.Close();
                    }
                }
            }
        }
        private void frmsearch_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            classprodact cls = new classprodact();
            cls.searchpro(textsearch.Text);
           dgvprosearch.DataSource = cls.dtpublic;
        }

        private void dgvprosearch_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void dgvprosearch_Click(object sender, EventArgs e)
        {
           
        }

        private void dgvprosearch_MouseDown(object sender, MouseEventArgs e)
        {
           
              
            
        }

        private void dgvprosearch_MouseDoubleClick(object sender, MouseEventArgs e)
        {


            if (this.Text == "مشتريات")
            {

                var frm1 = Application.OpenForms["frmbuys"] as frmbuys;
                frm1.textcode.Text = dgvprosearch.CurrentRow.Cells[1].Value.ToString();
                SendKeys.Send("{ENTER }");
                this.Close();

            }
            else
            {
                var frm = Application.OpenForms["frmsales"] as frmsales;
                frm.textcode.Text = dgvprosearch.CurrentRow.Cells[1].Value.ToString();
                SendKeys.Send("{ENTER }");
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
