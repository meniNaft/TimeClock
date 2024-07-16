using System.Data;
using System.Data.SqlClient;
using TimeClock.DAL;
using TimeClock.Models;

namespace TimeClock.Services
{
    static public class ManagerService
    {
        static int userId;
        static public DataTable Login(string tz, string password)
        {
            List<SqlParameter> sqlParams =
            [
                new SqlParameter("@tz", tz),
                new SqlParameter("@password", password)
            ];
            string selectQuery = $"select e.ID, p.ExpiryDate from Employees e inner join Passwords p on e.ID = p.EmployeeId and  p.IsActive = 1 where p.Password = CONVERT(VARBINARY, '@password') and e.EmployeeNat = '@tz' and p.IsActive = 1";
            var res =  DbContext.MakeQuery(selectQuery, sqlParams);
            if(res.Rows.Count > 0) {
                userId = (int)res.Rows[0]["Id"];
            }
            return res;
        }

        static public SqlResultOption ChangePassword(string tz, string oldPassword, string newPassword) 
        {
            string selectQuery = $"select * from Employees e inner join Passwords p on e.ID = p.EmployeeId where p.Password = CONVERT(VARBINARY, '@oldPassword') and e.EmployeeNat = '@tz'";
            List<SqlParameter> sqlParams =
          [
              new SqlParameter("@tz", tz),
                new SqlParameter("@oldPassword", oldPassword)
          ];
            var res = DbContext.MakeQuery(selectQuery, sqlParams);
            if (res.Rows.Count > 0)
            {
                var empId = res.Rows[0]["Id"];
                List<TransactionObject> transactionObjects = [
                new() {
                    Query = "update Passwords set IsActive = 0 where EmployeeId = @empId",
                    SqlParams = [new SqlParameter("@empId", empId)]
                },
                    new()
                    {
                        Query =$"INSERT INTO Passwords (EmployeeId, Password, ExpiryDate, IsActive) VALUES (@empId, CONVERT(VARBINARY, '@newPassword'), '{DateTime.Now.AddDays(90)}', 1)",
                        SqlParams =[
                            new SqlParameter("@empId", empId),
                            new SqlParameter("@newPassword", newPassword)
                            ]
                    }
                ];
                return DbContext.MakeTransactionQuery(transactionObjects) ? SqlResultOption.SUCCESS :SqlResultOption.SOMETHING_WENT_WRONG;
            }
            else
            {
                return SqlResultOption.NO_USER_FOUND;
            }
        }
        
        static public void NewEnter(DateTime now) {
            string insertQuery = $"INSERT INTO EmployeeAttendance(EmployeeId, EntryTime, ExitTime) values({userId}, '{now}', null)";
            DbContext.MakeQuery(insertQuery);
        }
        
        static public void NewExit(DateTime now) {
            string insertQuery = $"update EmployeeAttendance set ExitTime = '{now}' where ID = (select top 1 id from EmployeeAttendance order by id desc)";
            DbContext.MakeQuery (insertQuery);
        }
        
        static public DataRow? GetLastAttendance() { 
            string selectQuery  = $"select top 1 * from EmployeeAttendance ea inner join Employees e on e.Id = ea.EmployeeId where EmployeeId = {userId} order by ea.ID desc";
            DataTable res = DbContext.MakeQuery(selectQuery);
            return res.Rows.Count > 0 ? res.Rows[0] : null;
        }
    }
}
