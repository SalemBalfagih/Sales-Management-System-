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
using System.Data.SqlClient;

namespace مشروع_البيع
{
    public partial class frmbackup : DevExpress.XtraEditors.XtraForm
    {
        public frmbackup()
        {
            InitializeComponent();
        }

        private void frmbackup_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
           
        }

        private void frmbackup_Load_1(object sender, EventArgs e)
        {

        }

        private async void button3_Click (object sender, EventArgs e)
        {
            try
            {
                
                progressPanel1.Visible = true;       
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "Backup File (*.Bak) |*.bak";
                var rs = sf.ShowDialog();
                if (rs == DialogResult.OK)
                {


                    SqlCommand cmd;
                    cmd = new SqlCommand("Backup Database DBsell To Disk='" + sf.FileName + "'", classconn.cn);
                    classconn.cn.Open();
                    cmd.ExecuteNonQuery();
                    classconn.cn.Close();

                    {
                        MessageBox.Show("تم الحفط بنجاح", "النسخة", MessageBoxButtons.OK);
                        progressPanel1.Visible = false;
                    }
                }
                else
                {
                    progressPanel1.Visible = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("حدد مكان اخر لحفط النسخة الاحتياطية لا تحدد القرص C ");
                progressPanel1.Visible = false;
            }
        }
        public static SqlConnection cn1 = new SqlConnection(@"Data Source=DESKTOP-J9SIV02;Initial Catalog=;Integrated Security=True");

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {

            
            progressPanel2.Visible = true;
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "Backup File (*.Bak) |*.bak";
            var rs = sf.ShowDialog();
                if (rs == DialogResult.OK)

                {
                    SqlCommand cmd;
                    cmd = new SqlCommand("Restore Database DBsell From Disk='" + sf.FileName + "'", cn1);
                    cn1.Open();
                    cmd.ExecuteNonQuery();
                    cn1.Close();
                    {
                        MessageBox.Show("تم الاستعادة بنجاح", "النسخة", MessageBoxButtons.OK);
                        progressPanel2.Visible = false;
                    }
                }
                else
                {
                    progressPanel2.Visible = false;
                }  
            
            }
            catch
            {
                MessageBox.Show("خطاء في استعادة النسخة الاحتياطية   ");
                progressPanel2.Visible = false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}