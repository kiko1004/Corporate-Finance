using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorporateFinance
{
    public class perPeriod
    {
        public int index { get; set; }
        public double res { get; set; }

        public perPeriod(int i, double r)
        {
            index = i;
            res = r;
        }
    }
}
