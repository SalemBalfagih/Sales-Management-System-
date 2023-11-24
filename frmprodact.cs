using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace مشروع_البيع
{
    public partial class frmprodact : DevExpress.XtraEditors.XtraForm
    {

        public void cleartext()
        {
            textid.Clear();
            textcode.Clear();
            textname.Clear();
            textsell.Clear();
            textbuy.Clear();
            textear.Clear();
            textear.BackColor = Color.White;
            textstore.Clear();
            pictureBox1.Image = null;

        }
        Boolean ADD;

        public void loadpro()
        {
            classprodact clsp = new classprodact();
            clsp.loadpublic("loadVprodactitem");
            gcprodact.DataSource = clsp.dtpublic;
            dgvpro.DataSource = clsp.dtpublic;
        }
        public frmprodact()
        {
            InitializeComponent();
            classitem cls = new classitem();
            cls.loaditem();
            cmitem.DataSource = cls.dtitem;
            cmitem.DisplayMember = "nameitem";
            cmitem.ValueMember = "id";
            loadpro();

            //total mobaa
            for (int i = 0; i < dgvpro.Rows.Count; ++i)
            {
                total += Convert.ToDouble(dgvpro.Rows[i].Cells[4].Value);
            }
            texttotalRB.Text = total.ToString();

            //total mshtra
            for (int i = 0; i < dgvpro.Rows.Count; ++i)
            {
                total += Convert.ToDouble(dgvpro.Rows[i].Cells[4].Value);
            }
            texttotalRB.Text = total.ToString();

            //total mksb
            for (int i = 0; i < dgvpro.Rows.Count; ++i)
            {
                total += Convert.ToDouble(dgvpro.Rows[i].Cells[4].Value);
            }
            texttotalRB.Text = total.ToString();



        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void frmprodact_Load(object sender, EventArgs e)
        {


        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            cleartext();
            textcode.ReadOnly = false;
            classprodact cls = new classprodact();
            int max = cls.Maxidpublic("MaxidprodactSP") + 1;
            textid.Text = max.ToString();

            ADD = true;
            btnsave.Enabled = true;
            gBox.Enabled = true;

        }

        private void gBox_Enter(object sender, EventArgs e)
        {

        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            ADD = false;
            btnsave.Enabled = true;
            gBox.Enabled = true;
            try
            {
                textcode.ReadOnly = true;

                textid.Text = dgvpro.CurrentRow.Cells[0].Value.ToString();
                textcode.Text = dgvpro.CurrentRow.Cells[1].Value.ToString();
                textname.Text = dgvpro.CurrentRow.Cells[2].Value.ToString();
                textbuy.Text = dgvpro.CurrentRow.Cells[3].Value.ToString();
                textsell.Text = dgvpro.CurrentRow.Cells[4].Value.ToString();
                textear.Text = dgvpro.CurrentRow.Cells[5].Value.ToString();
                textstore.Text = dgvpro.CurrentRow.Cells[6].Value.ToString();
                cmitem.Text = dgvpro.CurrentRow.Cells[7].Value.ToString();

                classprodact cls = new classprodact();
                byte[] img = (byte[])cls.getimgpro(dgvpro.CurrentRow.Cells[1].Value
                    .ToString()).Rows[0][0];
                MemoryStream ms = new MemoryStream(img);
                pictureBox1.Image = Image.FromStream(ms);

            }
            catch
            {
                pictureBox1.Image = null;
            }





        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (ADD == true)
            {
                //insert
                if (pictureBox1.Image == null)
                    try
                    {


                        //insert not image
                        classprodact cls = new classprodact();
                        cls.insertpro_notimage(Convert.ToInt32(textid.Text), (textcode.Text), (textname.Text), Convert.ToDouble(textbuy.Text),
                            Convert.ToInt32(textsell.Text), Convert.ToDouble(textear.Text),
                            Convert.ToDouble(textstore.Text), Convert.ToInt32(cmitem.SelectedValue));

                        MessageBox.Show("                      تمت الاضافة بنجاح بدون صورة          ", "اضافة منتجات");

                        loadpro();
                        cleartext();
                        btnsave.Enabled = false;
                        gBox.Enabled = false;

                    }

                    catch
                    {
                        MessageBox.Show("الرجاء إدخال قيم صحيحه لا تترك الحقول فارغة", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    }



                else
                {
                    //insert with image
                    try
                    {
                        MemoryStream ms = new MemoryStream();
                        pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                        byte[] img = ms.ToArray();


                        classprodact cls = new classprodact();
                        cls.insertpro_image(Convert.ToInt32(textid.Text), (textcode.Text), (textname.Text), Convert.ToDouble(textbuy.Text), Convert.ToDouble(textsell.Text), Convert.ToDouble(textear.Text), Convert.ToDouble(textstore.Text), Convert.ToInt32(cmitem.SelectedValue), img);
                        MessageBox.Show("                      تمت الاضافة بنجاح مع صورة          ", "اضافة منتجات");

                        loadpro();
                        cleartext();
                        btnsave.Enabled = false;
                        gBox.Enabled = false;

                    }
                    catch
                    {
                        MessageBox.Show("الرجاء إدخال قيم صحيحه لا تترك الحقول فارغة", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    }
                }
            }
            // end add-----------------------------------------------------
            else
            // begin update

            {
                if (pictureBox1.Image == null)
                {
                    classprodact cls = new classprodact();
                    cls.updateprodact((textname.Text), Convert.ToDouble(textbuy.Text),
                        Convert.ToDouble(textsell.Text), Convert.ToDouble(textear.Text),
                        Convert.ToDouble(textstore.Text), Convert.ToInt32(cmitem.SelectedValue), textcode.Text);
                    MessageBox.Show("                      تمت تعديل بنجاح بدون صورة          ", "اضافة منتجات");

                    loadpro();
                    cleartext();
                    btnsave.Enabled = false;
                    gBox.Enabled = false;
                }

                else
                {
                    //update with image

                    try
                    {
                        MemoryStream ms = new MemoryStream();
                        pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                        byte[] img = ms.ToArray();

                        classprodact cls = new classprodact();
                        cls.updateprodactImg((textname.Text), Convert.ToDouble(textbuy.Text),
                            Convert.ToDouble(textsell.Text), Convert.ToDouble(textear.Text),
                            Convert.ToDouble(textstore.Text), Convert.ToInt32(cmitem.SelectedValue), textcode.Text, img);
                        MessageBox.Show("                      تمت التعديل بنجاح مع اضافة صورة          ", "اضافة منتجات");

                        loadpro();
                        cleartext();
                        btnsave.Enabled = false;
                        gBox.Enabled = false;
                    }
                    catch
                    {
                        return;
                    }

                }


            }
            // --------------------------------------------------------------------



        }


        private void textbuy_TextChanged(object sender, EventArgs e)
        {

        }

        private void textear_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(textear.Text) <= 0)
                {
                    textear.BackColor = Color.Red;
                }
                else
                {
                    textear.BackColor = Color.YellowGreen;
                }

            }
            catch (Exception)
            {
                return;
            }
        }

        private void textid_TextChanged(object sender, EventArgs e)
        {

        }

        private void textsell_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textear.Text = (Convert.ToDouble(textsell.Text) - Convert.ToDouble(textbuy.Text)).ToString();

            }
            catch
            {
                return;
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnview_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image |*.jpeg;*.jpg;*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void textid_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                classprodact cls = new classprodact();
                byte[] img = (byte[])cls.getimgpro(dgvpro.CurrentRow.Cells[1].Value
                    .ToString()).Rows[0][0];
                MemoryStream ms = new MemoryStream(img);
                pictureBox3.Image = Image.FromStream(ms);
            }
            catch
            {
                pictureBox3.Image = null;
            }
        }

        private void textcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btndel_Click(object sender, EventArgs e)
        {
            try
            {
                classprodact cls = new classprodact();
                int id = Convert.ToInt32(dgvpro.CurrentRow.Cells[0].Value);
                if (MessageBox.Show("هل تريد حذف العنصر المحدد", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cls.deletepro(id);
                    MessageBox.Show("تم حذف العنصر المحدد بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("تم الغاء عملية الحذف", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                loadpro();
            }
            catch
            {
                return;
            }
        }

        private void cmitem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvpro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textname.Focus();
            }
        }

        private void textname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textbuy.Focus();
            }
        }

        private void textbuy_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textsell.Focus();
            }
        }

        private void textsell_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void textsell_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textstore.Focus();
            }
        }

        private void textear_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void gcprodact_Click(object sender, EventArgs e)
        {

        }
        double total = 0.0;
        private void dgvpro_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int rwo = dgvpro.Rows.Count;
            textcountRP.Text = rwo.ToString();



        }

        private void texttotalRB_Validating(object sender, CancelEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textcode_TextChanged_1(object sender, EventArgs e)
        {


        }

        private void textcode_Move(object sender, EventArgs e)
        {


        }

        private void btnsave_TabIndexChanged(object sender, EventArgs e)
        {
            
            }

        private void btnsave_MouseEnter(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvpro.Rows.Count;)
            {
                if (textcode.Text != Convert.ToString(dgvpro.Rows[i].Cells[1].Value))
                {
                    ++i;

                }

         else
                {
                    MessageBox.Show("الكود متكرر يرجى التغيير","",MessageBoxButtons.OK,MessageBoxIcon.Hand);
                    textcode.Clear();
                    break;
                }
            }
    }
    }
}