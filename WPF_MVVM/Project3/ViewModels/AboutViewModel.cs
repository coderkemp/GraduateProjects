using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project3.Services;
using System.Diagnostics;

namespace Project3.ViewModels
{
   public class AboutViewModel
    {
        AboutService abs;

        public string aboutData { get; set; }

        public AboutViewModel()
        {
            abs = new AboutService();
        }

        internal void GetAboutdata()
        {
            var item = abs.getAboutDetails();
            aboutData = item.ToString();
            Debug.WriteLine(aboutData);
        }

    }
}
