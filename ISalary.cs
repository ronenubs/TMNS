using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMNSEnubs
{
    interface ISalary
    {
        void EmployeeSalary(double basicPay, params double[] deductions);
    }
}
