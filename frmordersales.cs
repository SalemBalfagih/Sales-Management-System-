using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace مشروع_البيع
{
    public partial class frmordersales : DevExpress.XtraEditors.XtraForm
    {
        int Id = 0;
        public frmordersales()
        {
            InitializeComponent();
            loadordersales();
        }
        void loadordersales()
        {
            classpublic cls = new classpublic();
            cls.loadpublic("loadordersaleAll");
            dgvordersale.DataSource = cls.dtpublic;
        }

        private void frmordersales_Load(object sender, EventArgs e)
        {

        }

        private void chordersale_CheckedChanged(object sender, EventArgs e)
        {
            if(chordersale.Checked==true)
            {
                classpublic cls = new classpublic();
                cls.loadpublic("loadordersaleAll");
                dgvordersale.DataSource = cls.dtpublic;
                cmordersale.Text = " ";
                cmordersale.Enabled = false;

            }
            else
            {
                cmordersale.Enabled = true;
                classorder clso = new classorder();
                clso.loadtypecustmer();
                cmordersale.DataSource = clso.dtorder;
                cmordersale.ValueMember = "id";
                cmordersale.DisplayMember = "typecustmer";

                

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cmordersale_SelectedIndexChanged(object sender, EventArgs e)
        {
            classorder clso = new classorder();
            clso.loadordersale_by_typec(cmordersale.Text);
            dgvordersale.DataSource = clso.dtorder;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Id = Convert.ToInt32(dgvordersale.CurrentRow.Cells[0].Value);
            classorder cls = new classorder();
            cls.loadorderdatails(Id);
            frmorderdatails frm = new frmorderdatails();
            frm.dgvorderdatails.DataSource = cls.dtorder;
            frm.lbnum.Text += Id.ToString();
            frm.ShowDialog();


        }

        private void btnupdateorder_Click(object sender, EventArgs e)
        {
            frmsales frm = new frmsales();
            frm.Text = "تعديل على الفاتورة";
            frm.textid.Text = dgvordersale.CurrentRow.Cells[0].Value.ToString();
            frm.textseller.Text = dgvordersale.CurrentRow.Cells[6].Value.ToString();
            //frm.btnneworder.Visible = false;
            frm.btnsaveorder .Visible = false;
            frm.btnprintlast.Visible = false;
            frm.btnupdatesave.Visible = true;
            
            classorder cls = new classorder();
            string nam = cls.getcustomerorder( dgvordersale.CurrentRow.Cells[7].Value.ToString());
            frm.textname.Text = nam;
            if (frm.textname.Text== "عملي نقدي")
            {
               frm.rbcash.Checked = true;
                frm.textname.Text = null;
            }
            else 
            {
                 frm.rbstay.Checked = true;

            }
           frm.Show();
        }

        private void dgvordersale_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            classpublic cls1 = new classpublic();
            cls1.loadpublic("loadordersaleAll");
            dgvordersale.DataSource = cls1.dtpublic;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try {
                classorder cls = new classorder();
                int x = Convert.ToInt32(dgvordersale.CurrentRow.Cells[0].Value);
                if (MessageBox.Show("هل تريد حذف الفاتورة المحددة", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cls.deleteordersales(x);
                    MessageBox.Show("تم الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadordersales();

                }
                else
                {
                    MessageBox.Show("تم الغاء عملية الحذف", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch
            {
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                classorder cls = new classorder();
              
                if (MessageBox.Show("هل تريد حذف كل الفواتيرة ", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cls.deleteallordersale();
                    MessageBox.Show("تم الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   

                }
                else
                {
                    MessageBox.Show("تم الغاء عملية الحذف", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch
            {
                return;
            }
        }

        private void btnorderall_Click(object sender, EventArgs e)
        {
            crprintorder cr = new crprintorder();
            classorder cls = new classorder();
            frmprint frm = new frmprint();
            cls.ordersinfo();
            cr.SetDataSource(cls.dtorder);
            frm.crystalReportViewer1.ReportSource = cr;
            frm.ShowDialog();

        }

        private void dgvordersale_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int rwo = dgvordersale.Rows.Count;
            textcountRO.Text = rwo.ToString();
        }
    }
}