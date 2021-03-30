using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMNSEnubs
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeCommission employeeCommission = new EmployeeCommission();
            

            Employee employee = new Employee("Ron", "Enubs", 39, "Samal City", 1001, "Cavista", "Engineering");
            employee.EmployeeSalary(10000, 100, 500, 400);
            employee.EmployeeCommission = employeeCommission.MonthlyCommission("Type A", 1564578.78);
            employee.EmployeeInfo();

            Console.ReadLine();
        }
    }
}
