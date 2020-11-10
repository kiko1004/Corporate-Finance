using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Corporate_Finance.Pages
{
    public class DetailedCompoundingModel : PageModel
    {
        public List<perPeriod> ca = new List<perPeriod> {
            new perPeriod(0, 0)
            };

        [BindProperty]
        public double C { get; set; }
        [BindProperty]
        public double R { get; set; }
        [BindProperty]
        public double N { get; set; }
        [BindProperty]
        public int payments { get; set; }

        public string rett { get; set; }
        public string EAR { get; set; }


        public void OnGet(double R, double N, double C, int payments)
        {
            if (C == 0 || R == 0 || C == 0)
            {
                rett = "FV result will be desplayed here";
                EAR = "EAR will be desplayed here";
            }
            else
            {
                double realInterest = R / payments;
                double realPeriods = payments * N;
                double r = R / 100;
                CalcInflow calcInflow = new CalcInflow(C, r, N, payments);
                rett = calcInflow.res;
                EAR = Convert.ToString(calcInflow.EAR);
                for (int i = 1; i <= realPeriods; i++)
                {


                }

            }
            
            
            
        }

        public void OnPost(double R, double N, double C, double payments)
        {         


        }
    }
}
