using Project3.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3.ViewModels
{
    class NewsViewModel
    {
        NewsService ns;

        List<String> item = new List<String>();

        public String newsData { get; set; }

        public NewsViewModel()
        {
            ns = new NewsService();

        }

        internal void getNewsData()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var i in ns.getNewsDetails())
            {
                Console.WriteLine(i);
                sb.Append(i);
                newsData = sb.ToString();
            }
        }

    }
}
