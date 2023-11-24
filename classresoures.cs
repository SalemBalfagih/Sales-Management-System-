using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace مشروع_البيع
{
    class classresoures
    {
        public DataTable dtresource = new DataTable();
        //public SqlDataReader drresoutce;
        //0000000000000000000
        //000000000000000000000
        //00000000000000000000000
        //00000000000000000000000000
       // public SqlDataReader drprodact;
        //00000000000000000000000000000
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }


        //عرض المنتجات المحددة في شاشة المبيعات
        public string Code { get; set; }
        public string ProName { get; set; }
        public int Price { get; set; }

        public void insertresource( int id,string name, string phone, string address)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = classconn.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "inserresource";
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
            cmd.Parameters.Add("@phone", SqlDbType.VarChar, 50).Value = phone;
            cmd.Parameters.Add("@addres", SqlDbType.VarChar, 50).Value = address;
            classconn.cn.Open();
            cmd.ExecuteNonQuery();
            classconn.cn.Close();
        }
        public void deleteresource(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = classconn.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "deleteresource";
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            classconn.cn.Open();
            cmd.ExecuteReader();
            classconn.cn.Close();
        }
        public void updateresource(int id,string name, string phone, string address)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = classconn.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "updateresource";
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
            cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = phone;
            cmd.Parameters.Add("@addres", SqlDbType.VarChar).Value = address;
            classconn.cn.Open();
            cmd.ExecuteReader();
            classconn.cn.Close();
        }
        
                public void searchresource(string txt)
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = classconn.cn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "searchresource";
                    cmd.Parameters.Add("@txt", SqlDbType.VarChar).Value = txt;
                    classconn.cn.Open();
                    dtresource.Load(cmd.ExecuteReader());
                    classconn.cn.Close();
                }

        


                public DataTable noloopname(string name)
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = classconn.cn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "noloopname";
                    cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
                    classconn.cn.Open();
                    dtresource.Load(cmd.ExecuteReader());
                    classconn.cn.Close();
                    return dtresource;
                }
        /*
                public void select_by_name(string name)
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = classconn.cn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "select_by_name";
                    cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
                    classconn.cn.Open();
                    drresoutce = cmd.ExecuteReader();
                    drresoutce.Read();
                    if (drresoutce.HasRows)
                    {
                        Phone = drresoutce[2].ToString();
                        Address = drresoutce[3].ToString();
                    }
                    else
                    {
                        Phone = "";
                        Address = "";
                    }
                    drresoutce.Close();
                    classconn.cn.Close();
                }
                //----------------------------------------------------------------
               /* public void selectcus_by_code_pro(string code)
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = classconn.cn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "selectcus_by_code_pro";
                    cmd.Parameters.Add("@code", SqlDbType.VarChar, 50).Value = code;
                    classconn.cn.Open();
                    drprodact = cmd.ExecuteReader();
                    drprodact.Read();
                    if (drprodact.HasRows)
                    {
                        Code = drprodact[1].ToString();
                        ProName = drprodact[2].ToString();
                        Price = Convert.ToInt32(drprodact[4]);


                    }
                    else
                    {
                        Code = "";
                        ProName = "";







                    }
                    drprodact.Close();
                    classconn.cn.Close();
                }*/

        // اضافة رقم لي اخر عنصر
        int id;
        public int MaxID()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = classconn.cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "MAXIDresourceSP";
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
       

    }
}
