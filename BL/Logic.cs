using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeClock.DAL;
using TimeClock.Models;

namespace TimeClock
{
    internal class Logic
    {
        Repository repository = new Repository();

        public IEnumerable<Employee> GetEmployees => repository.Employees;
        public IEnumerable<Employee> GetEmployeeById(int id) => repository.Employees.Where(e => e.Id == id);
    }
}
