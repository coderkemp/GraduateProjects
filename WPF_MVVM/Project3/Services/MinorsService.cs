using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project3.Models;
using System.Net.Http;
using System.Diagnostics;

namespace Project3.Services
{
    class MinorsService
    {
        public Minors getMinorDetails()
        {
            Minors storingList = new Minors();   //creating the instance object of the model class
            StringBuilder coursesBuilder = new StringBuilder();
            using (var client = new HttpClient())
            {
                string uri = $"http://ist.rit.edu/api/minors/";
                var response = client.GetAsync(uri).Result;
                var content = response.Content.ReadAsStringAsync().Result;
                dynamic item = Newtonsoft.Json.JsonConvert.DeserializeObject(content);
                //Console.WriteLine(item);

                var minorLength = item.UgMinors.Count;
                //Console.WriteLine(minorLength);

                for(var i = 0; i < minorLength; i++)
                {
                    var name = item.UgMinors[i].name;
                    var title = item.UgMinors[i].title;
                    var description = item.UgMinors[i].description;
                    var note = item.UgMinors[i].note;

                    var coursesLength = item.UgMinors[i].courses.Count;
                    for(var j = 0; j<coursesLength; j++)
                    {
                        coursesBuilder.Append(item.UgMinors[i].courses[j] + "\n");
                      //var courses = item.UgMinors[i].courses[j];
                    }
                    String combined = name + "\n" + title + "\n" + description + "\n" + coursesBuilder.ToString() + "\n" + note + "\n";
                    Console.WriteLine(combined);

                    storingList.storeMinors.Add(combined);  //storing the result in the model class and calling storeMinors using MVVM
                    coursesBuilder.Clear();


                }

            }
            return storingList;

      
        }
    }
}
