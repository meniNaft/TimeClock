using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeClock.DAL
{
    static internal class DbContext
    {
        static  private readonly string connectionString = "Data Source=DESKTOP-DQ310PT;Initial Catalog=company1;User id=sa;Password=1234;";

        private static void GetConnectionStrings()
        {

        }
        static  public DataTable MakeQuery(string query) {
            string S = GetConnectionStrings();
            DataTable outPut = new DataTable();
            using (SqlConnection conn = new SqlConnection()) {
                using (SqlCommand cmd = new SqlCommand(query, conn)) {
                    try
                    {
                        conn.Open();
                        using(SqlDataAdapter adapter  = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(outPut);
                            Console.WriteLine();
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                }
            }
            return outPut;
        }
    }
}
