using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project3.Models;
using System.Net.Http;

namespace Project3.Services
{
    class NewsService
    {
        public News getNewsDetails()
        {
            News newsList = new News();
            StringBuilder newsBuilder = new StringBuilder(); 
            using (var client = new HttpClient())
            {
                string uri = $"http://ist.rit.edu/api/news/";
                var response = client.GetAsync(uri).Result;
                var content = response.Content.ReadAsStringAsync().Result;
                dynamic item = Newtonsoft.Json.JsonConvert.DeserializeObject(content);
                //Console.WriteLine(item);

                var newsLength = item.year.Count;

                for(var i = 0; i<newsLength; i++)
                {
                    var date = item.year[i].date;
                    var title = item.year[i].title;
                    var description = item.year[i].description;

                    String newsResult = date + "\n" + title + "\n" + description + "\n" + "*************" + "\n\n";
                    newsList.storeNews.Add(newsResult);
                    Console.WriteLine(newsList);
                }

            }
            return newsList;
        }


    }
}
