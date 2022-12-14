using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CompositePattern
{
    class Manager : Employee
    {
    private String name;
    private long empId;
    private String position;

    public Manager(long empId, String name, String position)
    {
        this.empId = empId;
        this.name = name;
        this.position = position;
    }

    public void showEmployeeDetails()
    {
        Console.WriteLine(empId + " " + name + " " + position);
    }
}
}
