using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeClock.DAL;

namespace TimeClock.Services
{
    static public class ManagerService
    {
        static public bool Login(string tz, string password)
        {
            string query = $"select * from Employees e inner join Passwords p on e.ID = p.EmployeeId and  p.IsActive = 1 where p.Password = CONVERT(VARBINARY, '{password}') and e.EmployeeNat = '{tz}'";
            var res = DbContext.MakeQuery(query);
            if (res.Rows.Count > 0)
            {
                return true;
            }
            else
            { 
                return false; 
            }
        }

        static public bool ChangePassword(string tz, string oldPassword, string newPassword) {
            string query = $"select * from Employees e inner join Passwords p on e.ID = p.EmployeeId where p.Password = CONVERT(VARBINARY, '{oldPassword}') and e.EmployeeNat = '{tz}'";
            var res = DbContext.MakeQuery(query);
            if (res.Rows.Count > 0)
            {
                DateTime now = DateTime.Now;
                now.AddDays(90); 
                string dateToString = $"{now.Year}-{now.Month}-{now.Day}";
                var empId = res.Rows[0]["Id"];
                string updateQuery = $"update Passwords set IsActive = 0 where EmployeeId = {empId}";
                string insertQuery = $"INSERT INTO Passwords (EmployeeId, Password, ExpiryDate, IsActive) VALUES ({empId}, CONVERT(VARBINARY, '{newPassword}'), '{dateToString}', 1)";
                var updateSuccess = DbContext.MakeQuery(updateQuery);
                var insertSuccess = DbContext.MakeQuery(insertQuery);
                return true;
            }
            else
            {
                return false;
            }
        }
        static public void newEnter() { }
        static public void newExit() { }
    }
}
