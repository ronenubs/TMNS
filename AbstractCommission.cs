using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMNSEnubs
{
    public abstract class AbstractCommission
    {
        public double AnnualCommission(double annualSales)
        {
            return annualSales * 0.10;
        }

        public abstract double MonthlyCommission(string storeType, double sales);
    }
}
