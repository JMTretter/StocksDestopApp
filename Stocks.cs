using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StocksDestopApp
{
    class Stocks
    {
        public static string apiKey = "WbskEzCfUAgcpmpJMApAxrJnsaQPRn9D";
        public static List<string> GetDailyOpenClose(string symbol, string date)
        {
            //Call to API 
            var client = new RestClient("https://api.polygon.io/v1/open-close/" + symbol +"/" + date + "?&apiKey=" + apiKey);

            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            string result = response.Content;

            //Deserialize json response into C# object
            var stock = JsonConvert.DeserializeObject<OpenCloseData.Root>(result);

            List<string> values = new List<string>();

            values.Add(stock.preMarket.ToString());
            values.Add(stock.open.ToString());
            values.Add(stock.close.ToString());
            values.Add(stock.afterHours.ToString());
            values.Add(stock.volume.ToString());

            return values;
        }

        public static IEnumerable<List<string>> GetTickerDetails(string symbol)
        {
            var client = new RestClient("https://api.polygon.io/v1/meta/symbols/" + symbol + "/company?&apiKey=" + apiKey);

            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            string result = response.Content;

            var detail = JsonConvert.DeserializeObject<TickerData.Root>(result);

            List<string> values = new List<string>();
            List<string> sValues = new List<string>();

            values.Add(detail.listdate);
            values.Add(detail.hq_country);
            values.Add(detail.industry);
            values.Add(detail.sector);
            values.Add(detail.ceo);
            values.Add(detail.exchange);
            values.Add(detail.description);

            foreach(var s in detail.similar)
            {
                sValues.Add(s.ToString());
            }

            return new List<List<string>> { values, sValues};
        }
    }
}
