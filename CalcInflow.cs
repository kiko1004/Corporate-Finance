using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Corporate_Finance
{
    public class CalcInflow
    {
        public double C { get; set; }
        public double R { get; set; }
        public double N { get; set; }
        public double Payments { get; set; }
        public string res { get; set; }
        public double EAR { get; set; }









        public string Calculation (double C, double R, double N, double Payments)
        {
            double realInterest = R / Payments;
            double realPeriods = Payments * N;
            double y = C*Math.Pow((1+realInterest),realPeriods);
            
            return Convert.ToString(y);
            
            

        }

        public CalcInflow(double C, double R, double N, double payments)
        {
            this.C = Convert.ToDouble(C);
            this.R = Convert.ToDouble(R);
            this.N = Convert.ToDouble(N);
            this.Payments = Convert.ToDouble(payments);
            res = Calculation(C, R, N, Payments);
            EAR = (Math.Pow(1 + (R / Payments), Payments)) - 1;



        }
    }
}
