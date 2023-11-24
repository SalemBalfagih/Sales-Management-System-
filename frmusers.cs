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
using System.Data;
using System.Data.SqlClient;

namespace مشروع_البيع
{
    public partial class frmusers : DevExpress.XtraEditors.XtraForm
    {
        public frmusers()
        {
            InitializeComponent();
            loaduser();
            dgvusers.Columns[0].HeaderText = "الرقم";
            dgvusers.Columns[1].HeaderText = "اسم المستخدم";
            dgvusers.Columns[2].HeaderText = " كلمة المرور";
            dgvusers.Columns[3].HeaderText = "الاسم الكامل";
            dgvusers.Columns[4].HeaderText = "الهاتف";
            dgvusers.Columns[5].HeaderText = "الصلاحية";



        }
        void loaduser()
        {
            classpublic cls = new classpublic();
            cls.loadpublic("loaduser");
            dgvusers.DataSource = cls.dtpublic;
        }

        private void frmusers_Load(object sender, EventArgs e)
        {
            dgvusers.Columns[0].Width = 75;
            dgvusers.Columns[1].Width = 150;
            dgvusers.Columns[2].Width = 150;
            dgvusers.Columns[3].Width = 150;
            dgvusers.Columns[4].Width = 130;
            dgvusers.Columns[5].Width = 100;
        }
        void textclear()
        {
            textid.Clear();
            textusername.Clear();
            textfullname.Clear();
            textpasso.Clear();
            textphon.Clear();
            cmvalidty.Text = null;

        }
        void texton()
        {

            textusername.Enabled = true;
            textpasso.Enabled = true;
            textfullname.Enabled = true;
            textphon.Enabled = true;
            cmvalidty.Enabled = true;

        }

        void textoff()
        {

            textusername.Enabled = false;
            textpasso.Enabled = false;
            textfullname.Enabled = false;
            textphon.Enabled = false;
            cmvalidty.Enabled = false;
        }
        int ADD;
        private void btnadd_Click(object sender, EventArgs e)
        {
            ADD = 1;
            texton();
            textclear();
            textid.Select();
            classuser cls = new classuser();
            int id = cls.MAXIDuser() + 1;
            textid.Text = id.ToString();
        }

        private void btnsaveuse_Click(object sender, EventArgs e)
        {

            if (textusername.Text == "" || textpasso.Text == "" || textphon.Text == "" || textfullname.Text == "")
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

                classuser cls = new classuser();
                cls.insertusers(Convert.ToInt32(textid.Text), textusername.Text, textpasso.Text, textfullname.Text, textphon.Text, cmvalidty.Text);
                MessageBox.Show(" تم الاضافة بنجاح ");

            }
            else if (ADD == 2)
            {
                classuser cls1 = new classuser();
                cls1.updateusers(Convert.ToInt32(textid.Text), textfullname.Text, textusername.Text, textpasso.Text, textphon.Text, cmvalidty.Text);

                MessageBox.Show("تم التعديل بنجاح ");

            }
            textclear();
            textoff();
            loaduser();
            // اذا ضغط مرتيين
            ADD = 0;
            btnadduse.Select();

        }

        private void btnedituse_Click(object sender, EventArgs e)
        {
             try
            {
                ADD = 2;
                texton();
                textid.Text = dgvusers.CurrentRow.Cells[0].Value.ToString();
                textusername.Text = dgvusers.CurrentRow.Cells[1].Value.ToString();
                textpasso.Text = dgvusers.CurrentRow.Cells[2].Value.ToString();
                textphon.Text = dgvusers.CurrentRow.Cells[4].Value.ToString();
                textfullname.Text = dgvusers.CurrentRow.Cells[3].Value.ToString();
                cmvalidty.Text = dgvusers.CurrentRow.Cells[5].Value.ToString();


            }
            catch
            {
                  return;
            }
        }

        private void btndeluse_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult reslte = MessageBox.Show("هل تريد حذف العنصر المحدد", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                int id = Convert.ToInt32(dgvusers.CurrentRow.Cells[0].Value);
                if (reslte == DialogResult.Yes)
                {
                    classuser cls = new classuser();
                    cls.deleteuser(id);
                    MessageBox.Show("تمت عملية الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else

                {
                    MessageBox.Show("تم الغاء عملية الحذف ", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
           catch (Exception ex)

            {
                MessageBox.Show(ex.ToString());
            }

            loaduser();
        }

        private void dgvusers_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int rwo = dgvusers.Rows.Count;
            textcountRU.Text = rwo.ToString();
        }
    }
}