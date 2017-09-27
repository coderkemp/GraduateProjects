using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3.Models
{
    class News : IEnumerable
    {
        public List<String> storeNews = new List<string>();

        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable)storeNews).GetEnumerator();
        }
    
    }
}
