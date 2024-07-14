using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeClock.Models;

namespace TimeClock.DAL
{
    internal class DataContextMock
    {
        internal readonly IEnumerable<Employee> employees;

        public DataContextMock()
        {
            employees = new List<Employee>
            {
                 new Employee { Id = 1,EmployeeNat = "1111", FirstName ="emp1", LastName= "lastName1" },
                 new Employee { Id = 2,EmployeeNat = "2222", FirstName ="emp2", LastName= "lastName2" },
                 new Employee { Id = 3,EmployeeNat = "3333", FirstName ="emp3", LastName= "lastName3" },
                 new Employee { Id = 4,EmployeeNat = "4444", FirstName ="emp4", LastName= "lastName4" }
            };
        }
    }
}
