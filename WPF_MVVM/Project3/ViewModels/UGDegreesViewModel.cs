using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project3.Services;
using System.Diagnostics;

namespace Project3.ViewModels
{
    public class UGDegreesViewModel
    {
        UnderGradDegreesService ds;
        List<String> item = new List<String>();
        public string UGDegreesData { get; set; }

        public UGDegreesViewModel()
        {
            ds = new UnderGradDegreesService();
        }

        internal void GetDegreesData()
        {
            //  item = ds.getUGDegreesDetails();
            StringBuilder sb = new StringBuilder();
            foreach (var i in ds.getUGDegreesDetails())
            {
                Console.WriteLine(i);
                sb.Append(i);
                UGDegreesData = sb.ToString();
            }
       //     Console.WriteLine(item.ToString());
        //    UGDegreesData = item.ToString();
           
        }

    }
}
