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
        
        // Functions
        public string Mode { get; set; }
        public void OnGetSimple()
        {
            Mode = "SBPV";
            

        }

        public void OnGetETD()
        {
            Mode = "ETD";
            
        }


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


        // SECOND SET

        [BindProperty]
        public double currentBondPrice { get; set; }
        [BindProperty]
        public double BFV { get; set; }
        [BindProperty]
        public int YtM { get; set; }
        [BindProperty]
        public double ACR { get; set; }
        [BindProperty]
        public int numberOfPaymentsPerYear { get; set; }

        public double YTM { get; set; }
        public double YTM_2 { get; set; }
        public void OnGet()
        {
            BondValue = 0;

        }

        public void OnPost()
        {
            


        }

        public void OnPostSimpleDone()
        {
            double presentValue = ParValue / Math.Pow(1 + DiscountRate, YearsToMaturity);
            double couponPayment = ParValue * CouponRate;
            double annuityPresentValue = (couponPayment * (1 - 1 / Math.Pow(1 + DiscountRate, YearsToMaturity))) / DiscountRate;
            AnuPV = annuityPresentValue;
            ParPV = presentValue;
            BondValue = annuityPresentValue + presentValue;
            Mode = "SBPV";

        }

        public void OnPostYTDDone()
        {
            CalcInflow calcInflow = new CalcInflow(0, ACR, 0, numberOfPaymentsPerYear);
            double realRate = calcInflow.EAR;
            double cuponPayment = realRate * BFV;
            double cuponPayment_2 = ACR * BFV;
            YTM = (cuponPayment + ((BFV - currentBondPrice) / YtM)) / ((BFV + currentBondPrice) / 2);
            YTM = Math.Round(YTM * 100, 4);
            YTM_2 = (cuponPayment_2 + ((BFV - currentBondPrice) / YtM)) / ((BFV + currentBondPrice) / 2);
            YTM_2 = Math.Round(YTM_2 * 100, 4);
            Mode = "ETD";
        }
    }
}
