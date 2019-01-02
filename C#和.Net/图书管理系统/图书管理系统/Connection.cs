using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace 图书管理系统
{
    public class Connection
    {
        SqlConnection con = new SqlConnection("Data Source=USER\\SQLEXPRESS;Initial Catalog=LmsDb;Integrated Security=True");
        public SqlConnection ActiveCon()
        {
            if(con.State==ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
    }
}
