using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Diagnostics;

namespace Project3.Services
{
    class CoopTableService
    {
        public List<String> getCoopTableDetails()
        {
            List<String> coopTableList = new List<String>();   // to store the returning list
         
            StringBuilder coopBuilder = new StringBuilder();   // stringbuilder used to store values of strings
            StringBuilder employerBuilder = new StringBuilder();
            StringBuilder  degreeBuilder = new StringBuilder();
            StringBuilder cityBuilder = new StringBuilder();
            using (var client = new HttpClient())
            {
                string uri = $"http://ist.rit.edu/api/employment/coopTable";
                var response = client.GetAsync(uri).Result;
                var content = response.Content.ReadAsStringAsync().Result;
                dynamic item = Newtonsoft.Json.JsonConvert.DeserializeObject(content);
                Console.WriteLine(item);

                var title = item.coopTable.title;
                var coopInfoLength = item.coopTable.coopInformation.Count;

                for(var i = 0; i<coopInfoLength; i++)
                {
                    var employer = item.coopTable.coopInformation[i].employer;
                    Console.WriteLine(employer);
                    var degree = item.coopTable.coopInformation[i].degree;
                    var city = item.coopTable.coopInformation[i].city;
                    var term = item.coopTable.coopInformation[i].term;
                    employerBuilder.Append(employer);
                    degreeBuilder.Append(degree);
                    cityBuilder.Append(cityBuilder);

                }

                coopTableList.Add(employerBuilder.ToString());


                }

                return coopTableList;


            }

        }
    }
