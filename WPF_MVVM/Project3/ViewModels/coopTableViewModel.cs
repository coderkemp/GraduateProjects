using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project3.Services;
using System.ComponentModel;
using System.Net.Http;
using System.Windows.Data;

namespace Project3.ViewModels
{
    public class coopTableViewModel
    {

        public ICollectionView coopTable { get; private set; }
        
        public coopTableViewModel()
        {

            using (var client = new HttpClient())
            {
                string uri = $"http://ist.rit.edu/api/employment/coopTable";
          

            }
        }
        

       
    }
}
