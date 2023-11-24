using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace مشروع_البيع
{
    class classpublic
    {
        public DataTable dtpublic = new DataTable();
        public void loadpublic(string SPtext)
        {
            try {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = classconn.cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = SPtext;
                classconn.cn.Open();
                dtpublic.Load(cmd.ExecuteReader());
                classconn.cn.Close();
            }
            catch
            {
                return;
            }
        }
        public int Maxidpublic(string SPtext)
            {
            int id;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = classconn.cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = SPtext;
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
