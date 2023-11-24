using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace مشروع_البيع
{
    class DSset
    {
       public static SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-J9SIV02;Initial Catalog=DBsell;Integrated Security=True");


    }
}
