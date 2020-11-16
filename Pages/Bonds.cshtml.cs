using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CorporateFinance
{
    public class BondsModel : PageModel
    {
        [BindProperty]
        public double ParValue { get; set; }

        [BindProperty]
        public double CouponRate { get; set; }
        
        [BindProperty]
        public double DiscountRate { get; set; }


        [BindProperty]
        public double YearsToMaturity { get; set; }

        public double AnuPV { get; set; }
        public double ParPV { get; set; }

        public double BondValue { get; set; }
        public void OnGet()
        {
            BondValue = 0;

        }

        public void OnPost()
        {
            double presentValue = ParValue / Math.Pow(1 + DiscountRate, YearsToMaturity);
            double couponPayment = ParValue * CouponRate;
            double annuityPresentValue = (couponPayment * (1 - 1 / Math.Pow(1 + DiscountRate, YearsToMaturity))) / DiscountRate;
            AnuPV = annuityPresentValue;
            ParPV = presentValue;
            BondValue = annuityPresentValue + presentValue;
            

        }
    }
}
