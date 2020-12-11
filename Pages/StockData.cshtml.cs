using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceStack;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace CorporateFinance
{
    public class StockDataModel : PageModel
    {
        [BindProperty]
        public string Ticker { get; set; }
        public List<AlphaVantageData> monthlyPrices = new List<AlphaVantageData> { new AlphaVantageData { High = 0, Low = 0, Close = 0, Open = 0, Timestamp = new DateTime(), Volume = 0 }
        };
        public IActionResult OnGet()
        {
            
            return Page();
        }

        
        public ActionResult DownloadReport()
        {
            
            var sb = new StringBuilder();
            foreach (var data in monthlyPrices)
            {
                sb.AppendLine(Convert.ToString(data.Timestamp) + ", " + data.Open + ", "+data.High+", "+data.Low+", "+data.Volume);
            }
            return File(new UTF8Encoding().GetBytes(sb.ToString()), "text/csv", "export.csv");
        }

        public void OnPost()
        {
            try
            {
                var symbol = Ticker;
                var apiKey = "VHIWZSYMEX1PFIU4";
                monthlyPrices = $"https://www.alphavantage.co/query?function=TIME_SERIES_MONTHLY&symbol={symbol}&apikey={apiKey}&datatype=csv"
                                .GetStringFromUrl().FromCsv<List<AlphaVantageData>>();

            }
            catch (Exception)
            {
                monthlyPrices = new List<AlphaVantageData> { new AlphaVantageData { High = 99999, Low = 99999, Close = 999999, Open = 99999, Timestamp = new DateTime(), Volume = 0 } };


            }
            
            

        }
    }
}
