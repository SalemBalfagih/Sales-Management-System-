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
    public partial class frmbuys : DevExpress.XtraEditors.XtraForm
    {
        DataTable dtbuys = new DataTable();
        public frmbuys()
        {
            InitializeComponent();
            classorder cls = new classorder();
            cls.Maxidpublic("maxidbuys");
            int ID = cls.Maxidpublic("maxidbuys") + 1;
            textidb.Text = ID.ToString();
        }

        private void fluentDesignFormContainer1_Click(object sender, EventArgs e)
        {

        }

        private void rbcashb_CheckedChanged(object sender, EventArgs e)
        {
            if(rbcashb.Checked==true)
            {
                gbresourse.Enabled = false;
                cbpay.Checked = true;
            }
            else
            {
                gbresourse.Enabled = true;
                cbpay.Checked = false;
            }
        }

        private void rbstayb_CheckedChanged(object sender, EventArgs e)
        {

            if (rbstayb.Checked == true)
            {
                gbresourse.Enabled = true;
                cbpay.Checked = false;
            }
            else
            {
                gbresourse.Enabled = false;
                cbpay.Checked = true;
            }
        }

        private void btnprodact_Click(object sender, EventArgs e)
        {
            textcode.Focus();
            frmsearch frm = new frmsearch();
            frm.Text = "مشتريات";
            frm.ShowDialog();
        }

        private void textcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textqty.Focus();
                Classcustmer cls = new Classcustmer();
                cls.selectcus_by_code_pro(textcode.Text);
                textcode.Text = cls.Code;
                textproname.Text = cls.ProName;
                textprice.Text = cls.Price.ToString();

            }
           
        }

        private void textcode_TextChanged(object sender, EventArgs e)
        {

        }
        void clactotle_total()
        {
            try
            {


                double amount = Convert.ToDouble(textprice.Text) * Convert.ToDouble(textqty.Text);

                texttotleamount.Text = amount.ToString();
            }
            catch
            {
                return;
            }
        }
        private void texttotleamount_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textqty_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void textqty_ValueChanged(object sender, EventArgs e)
        {
             clactotle_total();
        }

        private void textprice_EditValueChanged(object sender, EventArgs e)
        {
            clactotle_total();
        }
    }
}