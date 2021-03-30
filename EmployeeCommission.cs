using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMNSEnubs
{
    public class EmployeeCommission : AbstractCommission
    {
        public override double MonthlyCommission(string storeType, double sales)
        {
            if(storeType.Equals("Type A"))
            {
                if(sales >= 1000000 && sales <= 2000000)
                {
                    return sales * 0.05;
                }
                else if(sales >= 500000 && sales < 1000000)
                {
                    return sales * 0.03;
                }
            }
            else if(storeType.Equals("Type B"))
            {
                if(sales >= 250000 && sales <= 500000)
                {
                    return sales * 0.02;
                }
                else if(sales >= 100000 && sales < 250000)
                {
                    return sales * 0.01;
                }
            }

            return 0;
        }
    }
}
