using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3.Models
{
    public class UnderGradDegrees
    {

        public string degreeName { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public List<string> concentrations { get; set; }

    }

    public class UnderGradRoot
    {
        public List<UnderGradDegrees> undergraduate { get; set; }
        public override string ToString()
        {
            return $"{undergraduate}";
        }
    }
}
