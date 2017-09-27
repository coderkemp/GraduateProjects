using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project3.Models;
using System.Net.Http;

namespace Project3.Services
{
    public class AboutService
    {
      
        
        public About getAboutDetails()
        {
           
            try
            {
                using (var client = new HttpClient())
                {
                    string uri = $"http://ist.rit.edu/~istdev/api/about/";
                    var response = client.GetAsync(uri).Result;
                    var content = response.Content.ReadAsStringAsync().Result;
                    dynamic item = Newtonsoft.Json.JsonConvert.DeserializeObject(content);

                    var retItem = item;

                    return new About()
                    {
                        title = retItem.title,
                        description = retItem.description,
                        quote = retItem.quote,
                        quoteAuthor = retItem.quoteAuthor
                       
                    };

                } 
                
            }

            catch (Exception)
            {
                throw;
            }
        
        } 
    }
}
