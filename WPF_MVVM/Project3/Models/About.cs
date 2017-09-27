using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3.Models
{
    public class About
    {
    
        public string title { get; set; }

        public string description { get; set; }

        public string quote { get; set; }

        public string quoteAuthor { get; set; }

        public override string ToString()
        {
            return $"{title}\n\n{description}\n\n{quote}\n\n{quoteAuthor}";
        }

    }
}
