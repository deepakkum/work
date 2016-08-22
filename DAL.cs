using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;




namespace mywork
{
    class DAL
    {
        private static string conStr = ConfigurationManager.ConnectionStrings["bookstr"].ConnectionString;
        private static SqlConnection con;
        public void connect()
        {
            try
            {
                con = new SqlConnection(conStr);
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    Console.Write("connected");

                }
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}
