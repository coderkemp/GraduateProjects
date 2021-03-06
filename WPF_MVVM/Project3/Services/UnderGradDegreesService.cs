﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project3.Models;
using System.Net.Http;
using System.Diagnostics;


namespace Project3.Services
{
    public class UnderGradDegreesService
    {
        public List<String> getUGDegreesDetails()
        {
            List<String> storedegreeList = new List<String>();   // to store the returning list
          StringBuilder concentrationBuilder = new StringBuilder();   // stringbuilder used to store values of strings
               using (var client = new HttpClient())
                {
                    string uri = $"http://ist.rit.edu/~istdev/api/degrees";
                    var response = client.GetAsync(uri).Result;
                    var content = response.Content.ReadAsStringAsync().Result;
                    dynamic item = Newtonsoft.Json.JsonConvert.DeserializeObject(content);
                    //Console.WriteLine(item);


                    var undergradlength = item.undergraduate.Count;  // count is used to find the length of the json object
                   // Console.WriteLine(undergradlength);
          
                for (var i = 0; i < undergradlength; i++)  // accessing the indexes of the undergraduate array
                    {
                        var title = item.undergraduate[i].title;  
            
                        var description = item.undergraduate[i].description;
                  
                        var concentrationsLength = item.undergraduate[i].concentrations.Count;  //finding the length of the concentrations array
                    Console.WriteLine(concentrationsLength);
                       for(var j = 0; j<concentrationsLength; j++)     // inner for loop to find the concentration indexes within a undergrad array
                        {


                                    //    Console.WriteLine(item.undergraduate[i].concentrations[j]);
                                        concentrationBuilder.Append(item.undergraduate[i].concentrations[j]+"\n");
                                        

                          }
                       
               
                    String combined = "----"+ title + "----" + "\n" + description + "\n" + concentrationBuilder.ToString() + "\n" + "\n";
                 
          
                    storedegreeList.Add(combined);
                    concentrationBuilder.Clear();  // to clear the stringuilder in each iteration
             

                    }

                return storedegreeList;
              
             
                }

        }

    }
}
