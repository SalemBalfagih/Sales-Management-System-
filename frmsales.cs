using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace مشروع_البيع
{
    public partial class frmsales : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        int typecustmer = 1;
        DataTable dtsales = new DataTable();
        void cleartextpro()
        {
            textcode.Clear();
            textproname.Clear();
            textprice.Text = Convert.ToDouble(0).ToString();
            textqty.Text = Convert.ToDouble(1).ToString();
            textdescount.Text = Convert.ToDouble(0).ToString();
            texttotleamount.Text = Convert.ToDouble(0).ToString();



        }
        void calctotalvalueadd()
        {  try
            {
                double total = 0;
                double totaldescount = 0;
                for (int i = 0; i < dgvsales.Rows.Count; i++)
                {
                    total += Convert.ToDouble(dgvsales.Rows[i].Cells[5].Value);
                }
                texttotal.Text = total.ToString();


                for (int i = 0; i < dgvsales.Rows.Count; i++)
                {
                    totaldescount += Convert.ToDouble(dgvsales.Rows[i].Cells[4].Value);
                }
                text_to_desco.Text = totaldescount.ToString();

                double stay = 0;
                stay = Convert.ToDouble(texttotal.Text) - Convert.ToDouble(textpay.Text);
                textstay.Text = stay.ToString();

                //دفع كامل 
                if (checkBox1.Checked == true)
                {
                    textpay.Text = texttotal.Text;

                }
            }
            catch
            {
                return;
            }


        }
        void clactotle_descount()
        {
            try
            {


                double amount = Convert.ToDouble(textprice.Text) * Convert.ToDouble(textqty.Text);
                double totleamount = amount - Convert.ToDouble(textdescount.Text);
                texttotleamount.Text = totleamount.ToString();
            }
            catch
            {
                return;
            }


        }
        public frmsales()
        {
            InitializeComponent();
            textseller.Text = classuser.fullname;
            //عشان معاد يجيب اعلى رقم في التعديل
            if (this.Text== "تعديل على الفاتورة")
            {
                return;
            }

            classorder cls = new classorder();
            cls.Maxidpublic("maxidorder");
            int ID = cls.Maxidpublic("maxidorder") + 1;
            textid.Text = ID.ToString();



        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void frmsales_Load(object sender, EventArgs e)
        {
            
            Classcustmer cls = new Classcustmer();
            cls.selectcus_by_name(textname.Text);
            textphone.Text = cls.Phone;
            textaddress.Text = cls.Address;
            

            dtsales.Columns.Add("الباركود");
            dtsales.Columns.Add("اسم المنتج");
            dtsales.Columns.Add("السعر");
            dtsales.Columns.Add("الكمية");
            dtsales.Columns.Add("الخصم");
            dtsales.Columns.Add("الاجمالي");

            dgvsales.DataSource = dtsales;

            dgvsales.Columns[0].Width = 185;
            dgvsales.Columns[1].Width = 281;
            dgvsales.Columns[2].Width = 250;
            dgvsales.Columns[3].Width = 243;
            dgvsales.Columns[4].Width = 186;
            dgvsales.Columns[5].Width = 202;

            if (this.Text== "تعديل على الفاتورة")
            {
            classorder clss = new classorder();
                clss.loadorderdatails(Convert.ToInt32(textid.Text));
                dtsales = clss.dtorder.Copy();
                dgvsales.DataSource = dtsales;
                calctotalvalueadd();
            }



        }

        private void barButtonItem14_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem16_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem17_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem19_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void calcEdit1_EditValueChanged(object sender, EventArgs e)
        {
            clactotle_descount();



        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void barButtonItem18_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void calcEdit2_EditValueChanged(object sender, EventArgs e)
        {
            clactotle_descount();

        }

        private void fluentDesignFormContainer1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textdata.Text = DateTime.Now.ToString();
        }

        private void textseller_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbcash_CheckedChanged(object sender, EventArgs e)
        {
            if (rbcash.Checked == true)
            {
                typecustmer = 1;
                gbcustmer.Enabled = false;
                textname.Text = null;
                textphone.Text = null;
                textaddress.Text = null;
                checkBox1.Checked = true;
             
            }
        }

        private void rbstay_CheckedChanged(object sender, EventArgs e)
        {
            if (rbstay.Checked == true)
            {
                typecustmer = 2;
                gbcustmer.Enabled = true;
                checkBox1.Checked = false;
            }
        }

        private void textname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Classcustmer cls = new Classcustmer();
                cls.selectcus_by_name(textname.Text);
                textphone.Text = cls.Phone;
                textaddress.Text = cls.Address;



            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmcustmuer frm = new frmcustmuer();
            frm.ShowDialog();
        }

        private void textprice_ValueChanged(object sender, EventArgs e)
        {

            clactotle_descount();

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {


            if (textcode.Text == "")
            {
                btnprodact.Visible = true;
            }
            else
            {
                btnprodact.Visible = false;
            }


        }

        private void btnprodact_Click(object sender, EventArgs e)
        {
            textcode.Focus();
            frmsearch frm = new frmsearch();
            frm.ShowDialog();
        }

        private void dgvsales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textdescount_KeyDown(object sender, KeyEventArgs e)
        {
            for (int i = 0; i < dgvsales.Rows.Count; i++)
            {
                if (textcode.Text == dgvsales.Rows[i].Cells[0].Value.ToString())
                {
                    classconn cls = new classconn();
                    cls.loadsettin();
                    if (cls.repeatpro == true)
                    {
                        textdescount.ReadOnly = false;
                    }
                    else
                    {
                        textdescount.ReadOnly = false;


                    }
                }
            }

            if (e.KeyCode == Keys.Enter)
            {
                classconn cls = new classconn();
                cls.loadsettin();

                if (cls.repeatpro == false)
                {
                    for (int i = 0; i < dgvsales.Rows.Count; i++)
                    {
                        if (textcode.Text == dgvsales.Rows[i].Cells[0].Value.ToString())
                        {
                            dgvsales.Rows[i].Cells[3].Value = Convert.ToDouble(textqty.Text)
                                + Convert.ToDouble(dgvsales.Rows[i].Cells[3].Value);
                            //اضافة الى الخصم

                            dgvsales.Rows[i].Cells[4].Value = Convert.ToDouble(textdescount.Text)
                               + Convert.ToDouble(dgvsales.Rows[i].Cells[4].Value);


                            double amount = Convert.ToDouble(dgvsales.Rows[i].Cells[2].Value) * Convert.ToDouble(dgvsales.Rows[i].Cells[3].Value);

                            double totleamount = amount - Convert.ToDouble(dgvsales.Rows[i].Cells[4].Value);
                            dgvsales.Rows[i].Cells[5].Value = totleamount;

                            textcode.Focus();
                            cleartextpro();
                            calctotalvalueadd();
                            return;

                        }

                    }
                }

                texttotleamount.Select();
                DataRow row = dtsales.NewRow();
                row[0] = textcode.Text;
                row[1] = textproname.Text;
                row[2] = textprice.Text;
                row[3] = textqty.Text;
                row[4] = textdescount.Text;
                row[5] = texttotleamount.Text;
                dtsales.Rows.Add(row);
                cleartextpro();
                textcode.Focus();
                calctotalvalueadd();
            }


        }

        private void texttotleamount_TextChanged(object sender, EventArgs e)
        {

        }

        private void textdescount_EditValueChanged(object sender, EventArgs e)
        {
            clactotle_descount();

        }

        private void textname_TextChanged(object sender, EventArgs e)
        {

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
            if (e.KeyCode == Keys.Space)
            {
                DataRow row = dtsales.NewRow();
                row[0] = textcode.Text;
                row[1] = textproname.Text;
                row[2] = textprice.Text;
                row[3] = textqty.Text;
                row[4] = textdescount.Text;
                row[5] = texttotleamount.Text;
                dtsales.Rows.Add(row);
            }


        }

        private void textproname_TextChanged(object sender, EventArgs e)
        {
            if (textproname.Text == "")
            {
                texttotleamount.Enabled = true;
                texttotleamount.Clear();
                texttotleamount.ReadOnly = true;

            }
        }

        private void texttotleamount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataRow row = dtsales.NewRow();
                row[0] = textcode.Text;
                row[1] = textproname.Text;
                row[2] = textprice.Text;
                row[3] = textqty.Text;
                row[4] = textdescount.Text;
                row[5] = texttotleamount.Text;
                dtsales.Rows.Add(row);
                cleartextpro();
                textcode.Focus();
            }
        }

        private void textqty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textdescount.Focus();
            }
            if (e.KeyCode == Keys.Space)
            {
                DataRow row = dtsales.NewRow();
                row[0] = textcode.Text;
                row[1] = textproname.Text;
                row[2] = textprice.Text;
                row[3] = textqty.Text;
                row[4] = textdescount.Text;
                row[5] = texttotleamount.Text;
                dtsales.Rows.Add(row);
                cleartextpro();
                textcode.Focus();
            }

        }

        private void textproname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataRow row = dtsales.NewRow();
                row[0] = textcode.Text;
                row[1] = textproname.Text;
                row[2] = textprice.Text;
                row[3] = textqty.Text;
                row[4] = textdescount.Text;
                row[5] = texttotleamount.Text;
                dtsales.Rows.Add(row);
                cleartextpro();
            }
        }

        private void barButtonItem20_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmsetting frm = new frmsetting();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dtsales.Clear();
            calctotalvalueadd();
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            try
            {
                dgvsales.Rows.RemoveAt(dgvsales.CurrentRow.Index);
            }
            catch (Exception)
            {

                return;
            }
            calctotalvalueadd();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void textpay_TextChanged(object sender, EventArgs e)
        {
            if (textpay.Text == "")
            {
                textpay.Text = "0";
            }
            calctotalvalueadd();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textpay.Text = texttotal.Text;

            }
         
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                textcode.Text = dgvsales.CurrentRow.Cells[0].Value.ToString();
                textproname.Text = dgvsales.CurrentRow.Cells[1].Value.ToString();
                textprice.Text = dgvsales.CurrentRow.Cells[2].Value.ToString();
                textqty.Text = dgvsales.CurrentRow.Cells[3].Value.ToString();
                textdescount.Text = dgvsales.CurrentRow.Cells[4].Value.ToString();
                texttotleamount.Text = dgvsales.CurrentRow.Cells[5].Value.ToString();
                textqty.Focus();
                dgvsales.Rows.RemoveAt(dgvsales.CurrentRow.Index);

            }
            catch (Exception)
            {
                return;
                
            }

            calctotalvalueadd();
        }

        private void btnneworder_Click(object sender, EventArgs e)
        {
            textphone.Clear();
            textaddress.Clear();
            textname.Clear();
            // عشان ياخذ اخرى رقم للفاتورة و يزود 1
            classorder cls = new classorder();
            cls.Maxidpublic("maxidorder");
            int ID = cls.Maxidpublic("maxidorder") + 1;
            textid.Text = ID.ToString();
            textseller.Text = classuser.fullname;

            gbcustmer.Enabled = false;

            texttotal.Clear();
            text_to_desco.Clear();

            textpay.Text = "0";
            textstay.Text = "0";

            dtsales.Clear();
            calctotalvalueadd();


            if (rbcash.Checked == true)
            {
                typecustmer = 1;
                gbcustmer.Enabled = false;
            }

            if (rbstay.Checked == true)
            {
                typecustmer = 2;
                gbcustmer.Enabled = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvsales.Rows.Count <= 0)
            {
                return;
            }
            string typec = "0";
            if (rbcash.Checked == true)
            {
                typecustmer = 1;
                typec = "عملي نقدي";
            }

            if (rbstay.Checked == true)
            {
                typecustmer = 2;
                typec = textname.Text;
            }



            classorder cls = new classorder();
            classpublic clsp = new classpublic();
            int id = clsp.Maxidpublic("maxidorder") + 1;
            
            cls.insertordersale(id, Convert.ToDateTime(textdata.Text), Convert.ToDouble(texttotal.Text), Convert.ToDouble(textdescount.Text),
                        Convert.ToDouble(textpay.Text), Convert.ToDouble(textstay.Text), textseller.Text, typec, typecustmer);

            // حفظ تفاصيل الفاتورة

            for (int i = 0; i < dgvsales.Rows.Count; i++)
            {
                cls.insert_O_S_D(id, dgvsales.Rows[i].Cells[0].Value.ToString(),
                    dgvsales.Rows[i].Cells[1].Value.ToString(),
                    Convert.ToDouble(dgvsales.Rows[i].Cells[2].Value),
                    Convert.ToDouble(dgvsales.Rows[i].Cells[3].Value),
                    Convert.ToDouble(dgvsales.Rows[i].Cells[4].Value),
                    Convert.ToDouble(dgvsales.Rows[i].Cells[5].Value));

            }

            MessageBox.Show("تم الحفظ بنجاح ");
            btnneworder.PerformClick();


        }

        private void textid_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("تم طباعة بنجاح");
        }

        private void btnupdatesave_Click(object sender, EventArgs e)
        { 
            if (dgvsales.Rows.Count <= 0)
            {
                return;
            }
            string typec = "0";
            if (rbcash.Checked == true)
            {
                typecustmer = 1;
                typec = "عملي نقدي";
            }

            if (rbstay.Checked == true)
            {
                typecustmer = 2;
                typec = textname.Text;
            }



            classorder cls = new classorder();
            classpublic clsp = new classpublic();
            //update on ordersale
            cls.updateordersale(Convert.ToInt32(textid.Text), Convert.ToDateTime(textdata.Text), Convert.ToDouble(texttotal.Text), Convert.ToDouble(textdescount.Text),
            Convert.ToDouble(textpay.Text), Convert.ToDouble(textstay.Text), textseller.Text, typec, typecustmer);

            // قبل الحفظ احذف القديمة
            cls.deleteorderd(Convert.ToInt32(textid.Text));
            //================================
            // حفظ تفاصيل الفاتورة
            for (int i = 0; i < dgvsales.Rows.Count; i++)
            {
                cls.insert_O_S_D(Convert.ToInt32(textid.Text), dgvsales.Rows[i].Cells[0].Value.ToString(),
                    dgvsales.Rows[i].Cells[1].Value.ToString(),
                    Convert.ToDouble(dgvsales.Rows[i].Cells[2].Value),
                    Convert.ToDouble(dgvsales.Rows[i].Cells[3].Value),
                    Convert.ToDouble(dgvsales.Rows[i].Cells[4].Value),
                    Convert.ToDouble(dgvsales.Rows[i].Cells[5].Value));

            }

            MessageBox.Show("تم التعديل بنجاح ");


            btnneworder.PerformClick();

          
        }

        private void skinPaletteRibbonGalleryBarItem3_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            label19.Visible = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            label19.Visible = false;
        }
    }

}

