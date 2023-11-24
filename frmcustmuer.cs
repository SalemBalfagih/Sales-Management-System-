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
    public partial class frmcustmuer : DevExpress.XtraEditors.XtraForm
    {
        int ADD = 0;
        public frmcustmuer()
        {
            InitializeComponent();
            loadcustmer();
            dgv.Columns[0].HeaderText = "الرقم";
            dgv.Columns[1].HeaderText = "الاسم";
            dgv.Columns[2].HeaderText = "الهاتف";
            dgv.Columns[3].HeaderText = "العنوان";


        }

        void loadcustmer()
        { 
            //   : في الكلاس وراثة
            Classcustmer cls = new Classcustmer();
            cls.loadpublic("loadcustmer");
            dgv.DataSource = cls.dtpublic;
        }

        void textclear()
        {
            textadderss.Clear();
            textphone.Clear();
            textname.Clear();
           
        }
        void texton()
        {
            textadderss.Enabled = true;
            textphone.Enabled = true;
            textname.Enabled = true;
        }

        void textoff()
        {
            textadderss.Enabled = false;
            textphone.Enabled = false;
            textname.Enabled = false;
        }



    
        private void textear_TextChanged(object sender, EventArgs e)
        {

        }

        private void custmuer_Load(object sender, EventArgs e)
        {
            btnadd.Select();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            ADD = 1;
            texton();
            textclear();
            textname.Select();
            textadderss.ReadOnly = false;
            loadcustmer();
            if(dgv.Rows.Count <1)
            {
                Classcustmer cls = new Classcustmer();
               
                cls.res();
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            try
            {
                ADD = 2;
                texton();
                textname.Text = dgv.CurrentRow.Cells[1].Value.ToString();
                textphone.Text = dgv.CurrentRow.Cells[2].Value.ToString();
                textadderss.Text = dgv.CurrentRow.Cells[3].Value.ToString();
                textadderss.ReadOnly = true;
            }
            catch
            {
                return;
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if(textphone.Text== ""||textadderss.Text==""||textname.Text=="")
            {
                MessageBox.Show("لايمكن حقظ قيم فارغة");
                return;
          
            }
            if(ADD==0)
            {
                MessageBox.Show("قم بعملية الاضافة او التعديل اولا ");
                return;
            }
            else if (ADD==1)
            {

                Classcustmer cls = new Classcustmer();
                cls.Insercustmer(textname.Text, textphone.Text, textadderss.Text);
                MessageBox.Show( " تم الاضافة بنجاح ");

            }
            else if (ADD==2)
            {
                Classcustmer cls = new Classcustmer();
                cls.updatecustmer(textname.Text, textphone.Text, textadderss.Text);
                MessageBox.Show("تم التعديل بنجاح ");

            }
            textclear();
            textoff();
            loadcustmer();
            // اذا ضغط مرتيين
            ADD = 0;
            textadderss.ReadOnly = false;
            btnadd.Select();



        }

        private void textphone_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                textadderss.Select();
            }
        }

        private void textname_TextChanged(object sender, EventArgs e)
        {

        }

        private void textname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textphone.Select();
            }
        }

        private void textadderss_TextChanged(object sender, EventArgs e)
        {

        }

        private void textadderss_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnsave.PerformClick();
            }
        }

        private void textsearch_TextChanged(object sender, EventArgs e)
        {
            
            Classcustmer cls = new Classcustmer();
            cls.searchcustmer(textsearch.Text);
            dgv.DataSource = cls.dtcustmer;
           
                
        }

        private void btndel_Click(object sender, EventArgs e)
        {
        }

        private void btndel_Click_1(object sender, EventArgs e)
        {   try
            {
                DialogResult reslte = MessageBox.Show("هل تريد حذف العنصر المحدد", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                int id = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);
                if (reslte == DialogResult.Yes)
                {
                    Classcustmer cls = new Classcustmer();
                    cls.deletecustmer(id);
                    MessageBox.Show("تمت عملية الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else

                {
                    MessageBox.Show("تم الغاء عملية الحذف ", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
            catch
            {
                return;
            }

            loadcustmer();
            }

        private void btndeleteall_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult reslte = MessageBox.Show("تحذير سوف يتم حذف كل العملاء " , "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (reslte == DialogResult.Yes)
                {
                    Classcustmer cls = new Classcustmer();
                    cls.deletecustmerall();
                    MessageBox.Show("تمت عملية الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cls.res();
                }
                else

                {
                    MessageBox.Show("تم الغاء عملية الحذف ", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
            catch
            {
                return;
            }

            loadcustmer();
        }

        private void textsearch_KeyDown(object sender, KeyEventArgs e)
        {
         
        }

        private void textsearch_MouseEnter(object sender, EventArgs e)
        {
          
            
        }

        private void textphone_Validating(object sender, CancelEventArgs e)
        {
            
        }
        private void textphone_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label(object sender, EventArgs e)
        {
           
        }

        private void textname_Validating(object sender, CancelEventArgs e)
        {
            Classcustmer cls = new Classcustmer();
            DataTable dt = new DataTable();
            dt = cls.noloopphone(textname.Text);
            if (dt.Rows.Count > 0 && textname.Text != "")
            {
                MessageBox.Show("الاسم موجود من قبل" + " " + textname.Text);
                textname.Clear();
                textname.Focus();
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgv_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int rwo = dgv.Rows.Count;
            textcountRC.Text = rwo.ToString();
        }
    }
    }

