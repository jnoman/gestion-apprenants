﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace apprenant
{
    class Connection
    {
        public static SqlConnection con = null;
        public void open_connection()
        {
            con = new SqlConnection(@"Data source=(localdb)\MSSQLLocalDB;Initial Catalog=apprenant;Integrated Security=true");
            con.Open();
        }
        public void close_connection()
        {
            con.Close();
        }
    }
}
