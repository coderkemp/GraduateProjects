using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project3.Services;

namespace Project3.ViewModels
{
    class MinorsViewModel
    {
        MinorsService ms;
    
        List<String> item = new List<String>();
        public string MinorsData { get; set; }

        public MinorsViewModel()
        {
            ms = new MinorsService();
        }

        internal void GetMinorsData()
        {
            //  item = ds.getUGDegreesDetails();
            StringBuilder sb = new StringBuilder();
            foreach (var i in ms.getMinorDetails())
            {
                Console.WriteLine(i);
                sb.Append(i);
                MinorsData = sb.ToString();
            }
            //     Console.WriteLine(item.ToString());
            //    UGDegreesData = item.ToString();

        }
    }
}
