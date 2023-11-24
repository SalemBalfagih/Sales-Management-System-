using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace مشروع_البيع
{
    class classorder : classpublic
    {
        SqlCommand cmd;
        public DataTable dtorder = new DataTable();
        public void insertordersale(int id, DateTime orderdate,double total,double totaldscount,double pay,double stay,string sales,string custmer,int typecustmer)

        {

            cmd = new SqlCommand();
            cmd.Connection = classconn.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "insertordersale";
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@orderdate", SqlDbType.DateTime, 50).Value = orderdate;
            cmd.Parameters.Add("@total", SqlDbType.Decimal).Value = total;
            cmd.Parameters.Add("@totaldscount", SqlDbType.Decimal).Value = totaldscount;
            cmd.Parameters.Add("@pay", SqlDbType.Decimal).Value = pay;
            cmd.Parameters.Add("@stay", SqlDbType.Decimal).Value = stay;
            cmd.Parameters.Add("@sales", SqlDbType.VarChar,50).Value = sales;
            cmd.Parameters.Add("@custmer", SqlDbType.VarChar,50).Value = custmer;
            cmd.Parameters.Add("@typecustmer", SqlDbType.Int).Value = typecustmer;
            classconn.cn.Open();
            cmd.ExecuteNonQuery();
            classconn.cn.Close();
        }

        public void insert_O_S_D(int idorder, string code, string prodactname, double price, double qty, double descount,double total)

        {

            cmd = new SqlCommand();
            cmd.Connection = classconn.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "insert_O_S_D";
            cmd.Parameters.Add("@idorder", SqlDbType.Int).Value = idorder;
            cmd.Parameters.Add("@code", SqlDbType.VarChar, 50).Value = code;
            cmd.Parameters.Add("@prodactname", SqlDbType.VarChar, 50).Value = prodactname;
            cmd.Parameters.Add("@price", SqlDbType.Decimal).Value = price;
            cmd.Parameters.Add("@qty", SqlDbType.Decimal).Value = qty;
            cmd.Parameters.Add("@descount", SqlDbType.Decimal).Value = descount;
            cmd.Parameters.Add("@total", SqlDbType.Decimal).Value = total;
            classconn.cn.Open();
            cmd.ExecuteNonQuery();
            classconn.cn.Close();
        }
        public void loadtypecustmer()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = classconn.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "loadtypecustmer";
            classconn.cn.Open();
            dtorder.Load(cmd.ExecuteReader());
            classconn.cn.Close();


        }
        public void loadordersale_by_typec(string typecustmor)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = classconn.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "loadordersale_by_typec";
            cmd.Parameters.Add("@typecustomer", SqlDbType.VarChar, 50).Value =typecustmor;
            classconn.cn.Open();
            dtorder.Load(cmd.ExecuteReader());
            classconn.cn.Close();


        }
        public void loadorderdatails(int ID)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = classconn.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "loadorderdatails";
            cmd.Parameters.Add("@id", SqlDbType.VarChar, 50).Value = ID;
            classconn.cn.Open();
            dtorder.Load(cmd.ExecuteReader());
            classconn.cn.Close();


        }

        public void updateordersale(int id, DateTime orderdate, double total, double totaldscount, double pay, double stay, string sales, string custmer, int typecustmer)

        {

            cmd = new SqlCommand();
            cmd.Connection = classconn.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "updateordersale";
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@orderdate", SqlDbType.DateTime, 50).Value = orderdate;
            cmd.Parameters.Add("@total", SqlDbType.Decimal).Value = total;
            cmd.Parameters.Add("@totaldscount", SqlDbType.Decimal).Value = totaldscount;
            cmd.Parameters.Add("@pay", SqlDbType.Decimal).Value = pay;
            cmd.Parameters.Add("@stay", SqlDbType.Decimal).Value = stay;
            cmd.Parameters.Add("@sales", SqlDbType.VarChar, 50).Value = sales;
            cmd.Parameters.Add("@custmer", SqlDbType.VarChar, 50).Value = custmer;
            cmd.Parameters.Add("@typecustmer", SqlDbType.Int).Value = typecustmer;
            classconn.cn.Open();
            cmd.ExecuteNonQuery();
            classconn.cn.Close();
        }
        //حذف الفاتورة قبل حفط التعديل لمنع التكرار
        public void deleteorderd(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = classconn.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "deleteorderd";
            cmd.Parameters.Add("@idorder", SqlDbType.Int).Value = id;
            classconn.cn.Open();
            dtorder.Load(cmd.ExecuteReader());
            classconn.cn.Close();


        }

        public void deleteordersales(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = classconn.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "deleteordersales";
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            classconn.cn.Open();
            dtorder.Load(cmd.ExecuteReader());
            classconn.cn.Close();
        }
        public void deleteallordersale()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = classconn.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "deleteallordersales";
            classconn.cn.Open();
            dtorder.Load(cmd.ExecuteReader());
            classconn.cn.Close();
        }
        public string getcustomerorder(string name1)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = classconn.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "getcustomerorder";
            cmd.Parameters.Add("@custmer", SqlDbType.VarChar, 50).Value = name1;
            classconn.cn.Open();
            string name = cmd.ExecuteScalar().ToString();
            classconn.cn.Close();
            return name;

        }

        public void ordersinfo()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = classconn.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ordersinfo";
            classconn.cn.Open();
            dtorder.Load(cmd.ExecuteReader());
            classconn.cn.Close();


        }








    }
}
