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
    public partial class frmreport : DevExpress.XtraEditors.XtraForm
    {
        frmitem frm = new frmitem();
        frmprodact frm1 = new frmprodact();
        frmusers frm2 = new frmusers();
        frmcustmuer frm3 = new frmcustmuer();
        frmresource frm4 = new frmresource();
        frmordersales frm5 = new frmordersales();

        public frmreport()
        {
            InitializeComponent();
           
            labitem.Text = frm.textcountR.Text.ToString();
            labpro.Text = frm1.textcountRP.Text.ToString();
            labuser.Text = frm2.textcountRU.Text.ToString();
            labcust.Text = frm3.textcountRC.Text.ToString();
            labresou.Text = frm4.textcountRR.Text.ToString();
            laborderR.Text = frm5.textcountRO.Text.ToString();
            labtotalS.Text = frm1.texttotalRB.Text.ToString();


        }
           
        private void label1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void frmreport_Load(object sender, EventArgs e)
        {

        }
    }
}
