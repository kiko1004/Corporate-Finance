using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CorporateFinance
{
    public class AlphaVantageData
    {
        public DateTime Timestamp { get; set; }
        public decimal Open { get; set; }

        public decimal High { get; set; }
        public decimal Low { get; set; }

        public decimal Close { get; set; }
        public decimal Volume { get; set; }

        // retrieve monthly prices for Microsoft
        //string symbol = "MSFT";
        //string apiKey = "VHIWZSYMEX1PFIU4"; // retrieve your api key from VHIWZSYMEX1PFIU4
        //string monthlyPrices = $"https://www.alphavantage.co/query?function=TIME_SERIES_MONTHLY&symbol={symbol}&apikey={apiKey}&datatype=csv"
        //                .GetStringFromUrl().FromCsv<List<AlphaVantageData>>();

      
    }
}
