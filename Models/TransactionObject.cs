using System.Data.SqlClient;

namespace TimeClock.Models
{
    internal class TransactionObject
    {
        public string Query { get; set; }
        public SqlParameter[]? SqlParams { get; set; }
    }
}
