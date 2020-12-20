using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StocksDestopApp
{
    class OpenCloseData
    {
        [JsonObject]
        public class Root : IEnumerable<Root>
        {
            List<Root> roots = new List<Root>();
            public string status { get; set; }
            public string from { get; set; }
            public string symbol { get; set; }
            public double open { get; set; }
            public double high { get; set; }
            public double low { get; set; }
            public double close { get; set; }
            public int volume { get; set; }
            public double afterHours { get; set; }
            public double preMarket { get; set; }

            public IEnumerator<Root> GetEnumerator()
            {
                return roots.GetEnumerator();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }
    }
}
