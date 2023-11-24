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
    public partial class frmresource : DevExpress.XtraEditors.XtraForm
    {
        int ADD = 0;
       
          
       
        public frmresource()
        {
            InitializeComponent();
              loadresource();
              dgv.Columns[0].HeaderText = "الرقم";
              dgv.Columns[1].HeaderText = "الاسم";
              dgv.Columns[2].HeaderText = "الهاتف";
              dgv.Columns[3].HeaderText = "العنوان";
           
        }
        void textclear()
        {
            textid.Clear();
            textadderss.Clear();
            textphone1.Clear();
            textname1.Clear();

        }
        void texton()
        {
            textadderss.Enabled = true;
            textphone1.Enabled = true;
            textname1.Enabled = true;
        }

        void textoff()
        {
            textadderss.Enabled = false;
            textphone1.Enabled = false;
            textname1.Enabled = false;
        }
        void loadresource()
        {
            classpublic cls = new classpublic();
            cls.loadpublic("loadresource");
            dgv.DataSource = cls.dtpublic;
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
           
            ADD = 1;
            texton();
            textclear();
            textname1.Select();
            textadderss.ReadOnly = false;
            loadresource();
            classresoures cls = new classresoures();
            int id = cls.MaxID() + 1;
            textid.Text = id.ToString();

        }

        private void frmresource_Load(object sender, EventArgs e)
        {
            btnadd.Select();
            dgv.Columns[0].Width = 45;
            dgv.Columns[3].Width = 75;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (textphone1.Text == "" || textadderss.Text == "" || textname1.Text == "")
            {
                MessageBox.Show("لايمكن حقظ قيم فارغة");
                return;

            }
            if (ADD == 0)
            {
                MessageBox.Show("قم بعملية الاضافة او التعديل اولا ");
                return;
            }
            else if (ADD == 1)
            {

                classresoures cls = new classresoures();
                cls.insertresource(Convert.ToInt32(textid.Text), textname1.Text,textphone1.Text, textadderss.Text);
                MessageBox.Show(" تم الاضافة بنجاح ");
            }
         else if (ADD == 2)
            {
                classresoures cls = new classresoures();
                cls.updateresource(Convert.ToInt32(textid.Text),textname1.Text, textphone1.Text, textadderss.Text);
                MessageBox.Show("تم التعديل بنجاح ");

            } 
                textclear();
                textoff();
                loadresource();
                // اذا ضغط مرتيين
                ADD = 0;
                btnadd.Select();
            }

        private void btndel_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult reslte = MessageBox.Show("هل تريد حذف العنصر المحدد", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                int id = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);
                if (reslte == DialogResult.Yes)
                {
                    classresoures cls = new classresoures();
                    cls.deleteresource(id);
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

            loadresource();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            try
            {  if (dgv.Rows.Count > 0)
                {
                    ADD = 2;
                    texton();
                    textid.Text = dgv.CurrentRow.Cells[0].Value.ToString();
                    textname1.Text = dgv.CurrentRow.Cells[1].Value.ToString();
                    textphone1.Text = dgv.CurrentRow.Cells[2].Value.ToString();
                    textadderss.Text = dgv.CurrentRow.Cells[3].Value.ToString();
                }
                else
                {
                    MessageBox.Show("حدد النعصر اولا");
                }
            }
            catch
            {
                return;
            }
        }

        private void textsearch_TextChanged(object sender, EventArgs e)
        {

            classresoures cls = new classresoures();
            cls.searchresource(textsearch.Text);
            dgv.DataSource = cls.dtresource;
        }

        private void textname1_Validating(object sender, CancelEventArgs e)
        {
            classresoures cls = new classresoures();
            DataTable dt = new DataTable();
            dt = cls.noloopname(textname1.Text);
            if (dt.Rows.Count > 0 && textname1.Text != "")
            {
                MessageBox.Show("الاسم موجود من قبل" + " " + textname1.Text);
                textname1.Clear();
                textname1.Focus();
            }
        }

        private void dgv_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int rwo = dgv.Rows.Count;
            textcountRR.Text = rwo.ToString();
        }
    }
    }
