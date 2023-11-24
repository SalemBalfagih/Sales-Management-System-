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
    public partial class frmsetting : DevExpress.XtraEditors.XtraForm
    {
        public frmsetting()
        {
            InitializeComponent();
        }

        private void frmsetting_Load(object sender, EventArgs e)
        {

            classconn cls = new classconn();
            cls.loadsettin();
            chkrepeat.Checked = cls.repeatpro;
            chkspeed.Checked = cls.speedsale;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            classconn cls = new classconn();
            cls.updatestting(chkrepeat.Checked, 1);
            cls.updatestting(chkspeed.Checked, 2);
            MessageBox.Show("تـــــــــــم الحفظ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void chkrepeat_CheckedChanged(object sender, EventArgs e)
        {
            if(chkrepeat.Checked==true)
            {
                chkspeed.Checked = false;
            }
           
        }

        private void chkspeed_CheckedChanged(object sender, EventArgs e)
        {
            if(chkspeed.Checked==true)
            {
                chkrepeat.Checked = false ;

            }
        }
    }
}
      