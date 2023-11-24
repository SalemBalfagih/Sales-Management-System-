using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace مشروع_البيع
{
    class classitem
    {
        public DataTable dtitem = new DataTable();
        public void loaditem()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = classconn.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "loaditemSP";
            classconn.cn.Open();
            dtitem.Load(cmd.ExecuteReader());
            classconn.cn.Close();


        }
        // اضافة رقم لي اخر عنصر
        int id;
        public int MaxID()
        {
            try {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = classconn.cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "MAXIDitemSP";
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
        public void Insertitem(int id, string name)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = classconn.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "InsertitemSP";
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@name", SqlDbType.VarChar,50).Value = name;
            classconn.cn.Open();
            cmd.ExecuteNonQuery();
            classconn.cn.Close();
        }

        public void updatetitem(int id, string name)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = classconn.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "updateitemSP";
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@name", SqlDbType.VarChar, 50).Value = name;
            classconn.cn.Open();
            cmd.ExecuteNonQuery();
            classconn.cn.Close();
        }

        public void deleteitem(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = classconn.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "deleteitemSP";
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            classconn.cn.Open();
            cmd.ExecuteNonQuery();
            classconn.cn.Close();
        }
        
    }

}
