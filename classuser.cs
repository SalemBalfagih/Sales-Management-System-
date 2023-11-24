using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace مشروع_البيع
{
    class classuser
    {
        public static string fullname;
        public static string admin;
        public DataTable dtuser = new DataTable();
        public void Login(string user, string pass)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = classconn.cn;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.CommandText = "loginSP";
                cmd.Parameters.Add("@user", SqlDbType.VarChar, 50).Value = user;
                cmd.Parameters.Add("@pass", SqlDbType.VarChar, 50).Value = pass;
                classconn.cn.Open();
                dtuser.Load(cmd.ExecuteReader());
                if ((dtuser.Rows.Count > 0))
                {
                    MessageBox.Show(" اهلا بكم تم التسجيل بنحاح ", "", MessageBoxButtons.OK) ;
                   



                        var frm = Application.OpenForms["form1"] as Form1;
                        fullname = dtuser.Rows[0][3].ToString();
                        admin = Convert.ToString(dtuser.Rows[0][5]);

                        frm.btnlogout.Enabled = true;
                        frm.storage.Enabled = true;
                        frm.sale.Enabled = true;
                        frm.buy.Enabled = true;
                        frm.source.Enabled = true;
                        frm.users.Enabled = true;
                        frm.custmer.Enabled = true;
                        frm.btnlogin.Enabled = false;
                        frm.btnstting.Enabled = true;
                }
                else
                {
                    MessageBox.Show("خطاء في التسجيل الدخول حاول مرة اخرى ", "تسجيل الدخول", MessageBoxButtons.OK, MessageBoxIcon.Hand);

                }

                classconn.cn.Close();
            }
            catch
            {
                MessageBox.Show("خطاء في الاتصال حاول مرة اخرى ", "تسجيل الدخول", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

        }
        public void insertusers(int id, string username, string password, string fullname, string phone, string admins)
        {

          SqlCommand  cmd = new SqlCommand();
            cmd.Connection = classconn.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "insertusers";
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@username", SqlDbType.VarChar, 50).Value =username ;
            cmd.Parameters.Add("@passwordd", SqlDbType.VarChar, 50).Value = password;
            cmd.Parameters.Add("@fullname", SqlDbType.VarChar, 50).Value = fullname;
            cmd.Parameters.Add("@phone", SqlDbType.VarChar, 50).Value = phone ;
            cmd.Parameters.Add("@admins", SqlDbType.VarChar, 50).Value = admins;
            classconn.cn.Open();
            cmd.ExecuteNonQuery();
            classconn.cn.Close();
        }
        public void updateusers(int id,string fullname, string name,string password, string phone, string admins)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = classconn.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "updateusers";
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@fullname", SqlDbType.VarChar).Value = fullname;
            cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = name;
            cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = password;
            cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = phone;
            cmd.Parameters.Add("@admins", SqlDbType.VarChar).Value = admins;
            classconn.cn.Open();
            cmd.ExecuteReader();
            classconn.cn.Close();
        }



        int id;
        public int MAXIDuser()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = classconn.cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "MAXIDuser";
                classconn.cn.Open();
                //ExecuteScalar يرجع قيمة اخر رقم
                id = Convert.ToInt32(cmd.ExecuteScalar());

            }
            catch
            {
                id = 0;
            }
            classconn.cn.Close();
            return id;
        }

        public void deleteuser(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = classconn.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "deleteuser";
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            classconn.cn.Open();
            cmd.ExecuteNonQuery();
            classconn.cn.Close();
        }

    }

    }

