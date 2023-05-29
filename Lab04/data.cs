using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    internal class data
    {
        public class userData
        {
            public int id { get; set; }
            public string email { get; set; }
            public string first_name { get; set; }
            public string last_name { get; set; }
            public string avatar { get; set; }
        }

        public class pageInfo
        {
            public int page { get; set; }
            public int per_page { get; set; }
            public int total { get; set; }
            public int total_pages { get; set; }
            public List<userData> data { get; set; }
            public supportInfo support { get; set; }
        }

        public class supportInfo
        {
            public string url { get; set; }
            public string text { get; set; }
        }
    }
}
