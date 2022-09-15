using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class CompanyDirectory : Employee
    {
    private List<Employee> employeeList = new List<Employee>();

    public void showEmployeeDetails()
    {
        foreach (Employee emp in employeeList)
        {
            emp.showEmployeeDetails();
        }
    }

    public void addEmployee(Employee emp)
    {
        employeeList.Add(emp);
    }

    public void removeEmployee(Employee emp)
    {
        employeeList.Remove(emp);
    }
}
}
