using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project3.Services;
using System.Diagnostics;

namespace Project3.ViewModels
{
    public class GradDegreesViewModel
    {
        GradDegreesService ds;

        public string GradDegreesData { get; set; }

        public GradDegreesViewModel()
        {
            ds = new GradDegreesService();
        }

        internal void GetDegreesData()
        {
            //  item = ds.getUGDegreesDetails();
            StringBuilder sb = new StringBuilder();
            foreach (var i in ds.getGraduateDegreesDetails())
            {
                Console.WriteLine(i);
                sb.Append(i);
                GradDegreesData = sb.ToString();
            }
            //     Console.WriteLine(item.ToString());
            //    UGDegreesData = item.ToString();

        }

    }
}
