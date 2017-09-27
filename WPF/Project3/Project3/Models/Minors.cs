using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3.Models
{
   public class Minors : IEnumerable
    {
        public List<String> storeMinors = new List<string>();

        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable)storeMinors).GetEnumerator();
        }
    }
}
