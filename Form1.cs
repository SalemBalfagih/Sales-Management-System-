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
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {

        }

        private void accordionControl1_Click(object sender,EventArgs e)
        {
            
        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement17_Click(object sender, EventArgs e)
        {
            frmcustmuer frm = new frmcustmuer();
            frm.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            login frm = new login();
            frm.ShowDialog();
        }

        private void btnitem_Click(object sender, EventArgs e)
        {
            frmitem frm = new frmitem();
            frm.ShowDialog();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
           
            storage.Expanded = false;
            sale.Expanded = false;
            buy.Expanded = false;
            source.Expanded = false;
            users.Expanded = false;
            custmer.Expanded = false;
            btnstting.Expanded = false;
          

            btnlogout.Enabled = false;
            storage.Enabled = false;
            sale.Enabled = false;
            buy.Enabled = false;
            source.Enabled = false;
            users.Enabled = false;
            custmer.Enabled = false;
            btnstting.Enabled = false;
            btnlogin.Enabled = true;

        }

        private void btnproudct_Click(object sender, EventArgs e)
        {
            frmprodact frm = new frmprodact();
            frm.ShowDialog();
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void label1_Click(object sender, EventArgs e)
        {
             }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            

        }

        private void sale_Click(object sender, EventArgs e)
        {

        }

        private void btnsale_Click(object sender, EventArgs e)
        {
            frmsales frm = new frmsales();
            frm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            

        }

        private void textdata_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }

        private void btnsaleorder_Click(object sender, EventArgs e)
        {
            frmordersales frm = new frmordersales();
            frm.ShowDialog();
        }

        private void source_Click(object sender, EventArgs e)
        {

        }

        private void btnsource_Click(object sender, EventArgs e)
        {
            frmresource frm = new frmresource();
            frm.ShowDialog();
        }

        private void accordionControlElement2_Click_1(object sender, EventArgs e)
        {
            frmbackup frm = new frmbackup();
            frm.ShowDialog();
        }

        private void btnuser_Click(object sender, EventArgs e)
        {
            frmusers frm = new frmusers();
            frm.ShowDialog();
        }

        private void storage_Click(object sender, EventArgs e)
        {

        }

        private void btnbuy_Click(object sender, EventArgs e)
        {
            frmbuys frm = new frmbuys();
            frm.ShowDialog();
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void btnbuyorder_Click(object sender, EventArgs e)
        {

        }

        private void btnreport_Click(object sender, EventArgs e)
        {
            frmreport frm = new frmreport();
            frm.ShowDialog();
        }
    }
}
