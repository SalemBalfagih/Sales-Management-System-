using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace مشروع_البيع
{
    public partial class frmitem : DevExpress.XtraEditors.XtraForm
       
    {
        int add = 0;
 
        public frmitem()
        {

            InitializeComponent();
            classitem item = new classitem();
            item.loaditem();
            dataGridView1.DataSource = item.dtitem;
            dataGridView1.Columns[0].HeaderText = "رقم الصنف ";
            dataGridView1.Columns[1].HeaderText = "  اسم الصنف ";
            if (classuser.admin=="مستخدم")
            {
                btndel.Enabled = false;
                btnedit.Enabled = false;
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmitem_Load(object sender, EventArgs e)
        {

        }

        private void textid_TextChanged(object sender, EventArgs e)
        {
                    }

        private void textid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                e.Handled = true;
                textname.Focus();
            }

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            add = 0;
            classitem item = new classitem();
            textname.Enabled = true;
            textname.Clear();
            textname.Select();
            int id = item.MaxID() + 1;
            textid.Text = id.ToString();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textid.Text)||string.IsNullOrEmpty(textname.Text))
            {
                MessageBox.Show("قم بالاضافة او التعديل قبل الحفظ");
                 }
            
           else if(add==0)
                {
            classitem item = new classitem();
            item.Insertitem(Convert.ToInt32(textid.Text),textname.Text);
            item.loaditem();
            dataGridView1.DataSource = item.dtitem;
            MessageBox.Show("تمت الاضافة بنجاح");
            textname.Clear();
            textid.Clear();
            textname.Enabled = false;
                }
                 
            else
            {
                classitem itemedit = new classitem();
                itemedit.updatetitem(Convert.ToInt32(textid.Text), textname.Text);
                itemedit.loaditem();
                dataGridView1.DataSource = itemedit.dtitem;
                MessageBox.Show("تمت التعديل بنجاح");
                textname.Clear();
                textid.Clear();
                textname.Enabled = false;
            }
           
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            add = 1;
            textid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textname.Enabled = true;
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            classitem item = new classitem();
            int id =Convert.ToInt32( dataGridView1.CurrentRow.Cells[0].Value);
            if (MessageBox.Show("هل تريد حذف العنصر المحدد", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                item.deleteitem(id);
                MessageBox.Show("تم حذف العنصر المحدد بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);   
            }
            else
            {
                MessageBox.Show("تم الغاء عملية الحذف", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            item.loaditem();
            dataGridView1.DataSource = item.dtitem;


        }

        private void textname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void count_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void count_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int rwo = dataGridView1.Rows.Count;
            textcountR.Text = rwo.ToString();
        }
    }
}
