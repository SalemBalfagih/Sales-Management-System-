using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace مشروع_البيع
{
    class classconn
    {
       public static SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-J9SIV02;Initial Catalog=DBsell;Integrated Security=True");
        SqlCommand cmd;
        DataTable dtsetting = new DataTable();
        public bool repeatpro { get; set; }
        public bool speedsale { get; set; }
        public void loadsettin()
        {
            cmd = new SqlCommand();
            cmd.Connection = classconn.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "loadsetting";
            classconn.cn.Open();
            dtsetting.Load(cmd.ExecuteReader());
            repeatpro = Convert.ToBoolean(dtsetting.Rows[0][2]);
            speedsale = Convert.ToBoolean(dtsetting.Rows[1][2]);
            classconn.cn.Close();


        }
        public void updatestting(bool stateproperty, int id)
        {
            cmd = new SqlCommand();
            cmd.Connection = classconn.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "updatestting";
            cmd.Parameters.Add("@stateproperty", SqlDbType.Bit).Value = stateproperty;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            classconn.cn.Open();
            cmd.ExecuteNonQuery();
            classconn.cn.Close();


        }

    }
}
