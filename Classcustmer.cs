using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace مشروع_البيع
{
    class Classcustmer:classpublic
    {   
       public DataTable dtcustmer = new DataTable();
        public SqlDataReader drcustmer ;
        public SqlDataReader drprodact;
        public string Name { get; set; }
       public string Phone { get; set; }
       public string Address { get; set; }


        //عرض المنتجات المحددة في شاشة المبيعات
        public string Code { get; set; }
        public string ProName { get; set; }
        public int Price { get; set; }
        


        public void Insercustmer(string name, string phone,string address)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = classconn.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "insertcustmer";
            cmd.Parameters.Add("@phone", SqlDbType.VarChar, 50).Value = phone;
            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
            cmd.Parameters.Add("@addres", SqlDbType.VarChar, 50).Value = address;
            classconn.cn.Open();
            cmd.ExecuteNonQuery();
            classconn.cn.Close();
        }
        public void searchcustmer(string txt)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = classconn.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "searchcustmer";
            cmd.Parameters.Add("@txt", SqlDbType.VarChar).Value = txt;
            classconn.cn.Open();
            dtcustmer.Load(cmd.ExecuteReader());
            classconn.cn.Close();
        }

        public void updatecustmer( string name , string phone, string address)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = classconn.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "updatecustmer";
            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
            cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = phone;
            cmd.Parameters.Add("@addres", SqlDbType.VarChar).Value = address;
            classconn.cn.Open();
            cmd.ExecuteReader();
            classconn.cn.Close();
        }
        public void deletecustmer(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = classconn.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "deletecustmer";
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            classconn.cn.Open();
            cmd.ExecuteReader();
            classconn.cn.Close();
        }
        public void deletecustmerall()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = classconn.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "deletecusall";
            classconn.cn.Open();
            cmd.ExecuteReader();
            classconn.cn.Close();
        }
        public void res()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = classconn.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "res";
            classconn.cn.Open();
            cmd.ExecuteReader();
            classconn.cn.Close();
        }
        // الاسم لايتكرر و ليس الرقم
        public DataTable noloopphone(string name)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = classconn.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "noloopphone";
            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
            classconn.cn.Open();
            dtcustmer.Load( cmd.ExecuteReader());
            classconn.cn.Close();
            return dtcustmer;
        }
        public void selectcus_by_name(string name)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = classconn.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "selectcus_by_name";
            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
            classconn.cn.Open();
            drcustmer = cmd.ExecuteReader();
            drcustmer.Read();
            if(drcustmer.HasRows)
                {
                Phone = drcustmer[2].ToString();
                Address = drcustmer[3].ToString();
                }
            else
            {
                Phone = "";
                Address = "";           
            }
            drcustmer.Close();
            classconn.cn.Close();
        }
        //----------------------------------------------------------------
        public void selectcus_by_code_pro(string code)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = classconn.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "selectcus_by_code_pro";
            cmd.Parameters.Add("@code", SqlDbType.VarChar,50).Value = code;
            classconn.cn.Open();
            drprodact = cmd.ExecuteReader();
            drprodact.Read();
            if (drprodact.HasRows)
            {
                Code = drprodact[1].ToString();
                ProName = drprodact[2].ToString();
                Price = Convert.ToInt32 ( drprodact[4]);
                

            }
            else
            {
             Code = "";
                ProName = "";
               
               

               
                
                
            
            }
            drprodact.Close();
            classconn.cn.Close();
        }
    }


}
