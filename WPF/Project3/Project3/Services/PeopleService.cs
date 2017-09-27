using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Project3.Services
{
    class PeopleService
    {
        public List<People> getPeopleDetails()
        {

            try
            {
                using (var client = new HttpClient())
                {
                    string uri = $"http://ist.rit.edu/api/people/";
                    var response = client.GetAsync(uri).Result;
                    var content = response.Content.ReadAsStringAsync().Result;
                    dynamic peopleItem = Newtonsoft.Json.JsonConvert.DeserializeObject(content);

                    var faculty = peopleItem.faculty;
                    var facultyLength = peopleItem.faculty.Count;

                    List<People> peopleList = new List<People>();

                    for(var i = 0; i< facultyLength; i++)
                    {
                        People p = new People();
                        p.name = peopleItem.faculty[i].name;
                        p.title = peopleItem.faculty[i].title;
                        p.imagePath = peopleItem.faculty[i].imagePath;
                        peopleList.Add(p);
                    }

                    return peopleList;

                }

            }

            catch (Exception)
            {
                throw;
            }

        }


    }
}
