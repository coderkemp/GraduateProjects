using Project3.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3.ViewModels
{
    class PeopleViewModel
    {
        PeopleService ps;

        public string peopleData { get; set; }

       public List<People> pitem = new List<People>();

        public PeopleViewModel()
        {
            ps = new PeopleService();
        }

        internal void GetPeopledata()
        {
            pitem = ps.getPeopleDetails();
       

        }
    }
}
