using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;
using TimeClock.Models;

namespace TimeClock.DAL
{
    static internal class DbContext
    {
        static readonly string? connString;
        static DbContext()
        {
           IConfiguration builder = new ConfigurationBuilder()
          .AddJsonFile("secrets.json", optional: true)
          .Build();
          connString = builder["ConnectionString"];
        }
        static  public DataTable MakeQuery(string query, List<SqlParameter>? sqlParams = null) {
            DataTable outPut = new();
            using (SqlConnection conn = new(connString)) {
                try
                {
                    conn.Open();
                    using SqlCommand cmd = new(query, conn);
                    if (sqlParams != null) {
                        cmd.Parameters.AddRange([.. sqlParams]);
                    }
                    using SqlDataAdapter adapter = new(cmd);
                    adapter.Fill(outPut);
                    Console.WriteLine();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            return outPut;
        }

        static public bool MakeTransactionQuery(List<TransactionObject> transactionObjects)
        {
            using SqlConnection conn = new(connString);
            conn.Open();
            SqlTransaction transaction = conn.BeginTransaction();
            try
            {
                foreach (var obj in transactionObjects)
                {
                    SqlCommand cmd = new(obj.Query, conn, transaction);
                    if (obj.SqlParams != null)
                    {
                        cmd.Parameters.AddRange(obj.SqlParams);
                    }
                    if (cmd.ExecuteNonQuery() == 0)
                    {
                        transaction.Rollback();
                        return false;
                    }
                }
                transaction.Commit();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                transaction.Rollback();
                return false;
            }
            return true;
        }
    }
}
