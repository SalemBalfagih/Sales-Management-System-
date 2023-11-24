using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace مشروع_البيع
{
    class classprodact :classpublic

    {
        public SqlCommand cmd;
        //or SqlCommand cmd = new SqlCommand();
        public void insertpro_notimage (int id,string code, string name,double pricebuy, double pricesell,double priceearn, double storaged,int iditem)
        {

            cmd = new SqlCommand();
            cmd.Connection = classconn.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "insertproSP";
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@code", SqlDbType.VarChar,50).Value = code;
            cmd.Parameters.Add("@name", SqlDbType.VarChar,50).Value = name;
            cmd.Parameters.Add("@pricebuy", SqlDbType.Decimal).Value = pricebuy;
            cmd.Parameters.Add("@pricesell", SqlDbType.Decimal).Value = pricesell;
            cmd.Parameters.Add("@priceear", SqlDbType.Decimal).Value = priceearn;
            cmd.Parameters.Add("@storaged", SqlDbType.Decimal).Value = storaged;
            cmd.Parameters.Add("@iditem", SqlDbType.Int).Value = iditem;
            classconn.cn.Open();
            cmd.ExecuteNonQuery();
            classconn.cn.Close();
        }
        public void insertpro_image(int id, string code, string name, double pricebuy, double pricesell, double priceearn, double storaged, int iditem,byte[] imagepro)
        {

            cmd = new SqlCommand();
            cmd.Connection = classconn.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "insertprodactimageSP";
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@code", SqlDbType.VarChar, 50).Value = code;
            cmd.Parameters.Add("@name", SqlDbType.VarChar, 50).Value = name;
            cmd.Parameters.Add("@pricebuy", SqlDbType.Decimal).Value = pricebuy;
            cmd.Parameters.Add("@pricesell", SqlDbType.Decimal).Value = pricesell;
            cmd.Parameters.Add("@priceear", SqlDbType.Decimal).Value = priceearn;
            cmd.Parameters.Add("@pstoraged", SqlDbType.Decimal).Value = storaged;
            cmd.Parameters.Add("@iditem", SqlDbType.Int).Value = iditem;
            cmd.Parameters.Add("@img", SqlDbType.Image).Value = imagepro;
            classconn.cn.Open();
            cmd.ExecuteNonQuery();
            classconn.cn.Close();
        }

        public DataTable getimgpro(string code)
        { 

        DataTable dt = new DataTable();
            cmd = new SqlCommand();
            cmd.Connection = classconn.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "getimageproSP";
            cmd.Parameters.Add("@code", SqlDbType.VarChar, 50).Value = code;
            classconn.cn.Open();
            dt.Load(cmd.ExecuteReader());
            classconn.cn.Close();
            return dt;

        }


        public void updateprodact ( string name, double pricebuy, double pricesell, double priceearn, double storaged, int iditem,string code)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.Connection = classconn.cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "updateprodact";
                cmd.Parameters.Add("@name", SqlDbType.VarChar, 50).Value = name;
                cmd.Parameters.Add("@pricebuy", SqlDbType.Decimal).Value = pricebuy;
                cmd.Parameters.Add("@pricesell", SqlDbType.Decimal).Value = pricesell;
                cmd.Parameters.Add("@priceear", SqlDbType.Decimal).Value = priceearn;
                cmd.Parameters.Add("@pstoraged", SqlDbType.Decimal).Value = storaged;
                cmd.Parameters.Add("@iditem", SqlDbType.Int).Value = iditem;
                cmd.Parameters.Add("@code", SqlDbType.VarChar, 50).Value = code;

                classconn.cn.Open();
                cmd.ExecuteNonQuery();
                classconn.cn.Close();
            }
            catch
            {
                return;
            }
        }
        public void updateprodactImg(string name, double pricebuy, double pricesell, double priceearn, double storaged, int iditem, string code,byte[] img)
        {

            cmd = new SqlCommand();
            cmd.Connection = classconn.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "updateprodactImage";
            cmd.Parameters.Add("@name", SqlDbType.VarChar, 50).Value = name;
            cmd.Parameters.Add("@pricebuy", SqlDbType.Decimal).Value = pricebuy;
            cmd.Parameters.Add("@pricesell", SqlDbType.Decimal).Value = pricesell;
            cmd.Parameters.Add("@priceear", SqlDbType.Decimal).Value = priceearn;
            cmd.Parameters.Add("@pstoraged", SqlDbType.Decimal).Value = storaged;
            cmd.Parameters.Add("@iditem", SqlDbType.Int).Value = iditem;
            cmd.Parameters.Add("@code", SqlDbType.VarChar, 50).Value = code;
            cmd.Parameters.Add("@img", SqlDbType.Image).Value = img;


            classconn.cn.Open();
            cmd.ExecuteNonQuery();
            classconn.cn.Close();
        }
        public void deletepro(int id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = classconn.cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "deletepro";
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                classconn.cn.Open();
                cmd.ExecuteNonQuery();
                classconn.cn.Close();
            }
            catch
            {
                return;
            }


        }
        public void searchpro(string text)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = classconn.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "searchpro";
            cmd.Parameters.Add("@search", SqlDbType.VarChar, 50).Value = text;
            classconn.cn.Open();
            dtpublic.Load(cmd.ExecuteReader());
            classconn.cn.Close();
        }
           

        }
}
