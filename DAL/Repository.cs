using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeClock.Models;

namespace TimeClock.DAL
{
    internal class Repository
    {
        readonly DataContextMock data = new DataContextMock();
        public IEnumerable<Employee> Employees => data.employees;
    }
}
