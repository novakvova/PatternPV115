using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Conposit
{
    public class Company : Employee
    {
        private List<Employee> _employees = new List<Employee>();
        public override void ShowInfo()
        {
            foreach(Employee employee in _employees)
                employee.ShowInfo();
        }
        public void Add(Employee employee)
        {
            _employees.Add(employee);
        }
        public void Delete(Employee employee)
        {
            _employees.Remove(employee);
        }
    }
}
