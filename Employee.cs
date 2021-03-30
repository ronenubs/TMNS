using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMNSEnubs
{
    public class Employee : Person, ISalary
    {
        private int employeeId;
        private string company;
        private string department;
        private double salary;
        private double employeeCommission;

        public Employee(string firstname, string lastname, int age, string address,
            int employeeId, string company, string department)
            :base(firstname, lastname, age, address)
        {
            this.employeeId = employeeId;
            this.company = company;
            this.department = department;
        }

        public virtual void EmployeeInfo()
        {
            Console.WriteLine($"{base.Firstname}, {base.Lastname}, {base.Age}");
            Console.WriteLine($"Address: {base.Address}");
            Console.WriteLine($"Employee ID: {employeeId}");
            Console.WriteLine($"Company: {company}");
            Console.WriteLine($"Department: {department}");
            Console.WriteLine($"Salary: {salary.ToString("{0.00}")}");
            Console.WriteLine($"Commission: {employeeCommission.ToString("{0.00}")}");
        }

        public void EmployeeSalary(double basicPay, params double[] deductions)
        {
            double tempDeductions = 0;
            for(int index = 0; index < deductions.Length; index++)
            {
                tempDeductions += deductions[index];
            }

            salary = basicPay - tempDeductions;
        }

        public int EmployeeId
        {
            get
            {
                return employeeId;
            }

            set
            {
                employeeId = value;
            }
        }

        public string Company
        {
            get
            {
                return company;
            }

            set
            {
                company = value;
            }
        }

        public string Department
        {
            get
            {
                return department;
            }

            set
            {
                department = value;
            }
        }

        public double Salary
        {
            get
            {
                return salary;
            }

            set
            {
                salary = value;
            }
        }

        public double EmployeeCommission
        {
            get
            {
                return employeeCommission;
            }

            set
            {
                employeeCommission = value;
            }
        }
    }
}
