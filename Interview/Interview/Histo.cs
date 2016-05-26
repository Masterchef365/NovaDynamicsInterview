using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    public class Histo
    {
        List<int> data; //Stored histogram
        List<int> buckets;
        public Histo (List<int> data)
        {
            buckets = new List<int> { 0,0,0,0,0,0,0,0,0,0 };
            this.data = data;
            foreach (int i in data) {
                for (int age = 0; age < 10; age++)
                {
                    if (i >= age * 10 && i <= age * 10 + 9)
                    {
                        buckets[age] += 1;
                    }
                }
            }
        }

        public List<int> get_histo ()
        {
            return buckets;
        }

    }
}
