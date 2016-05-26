using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Interview Program, \n Histogram:");
            Histo histo = new Histo(new List<int> { 99, 99, 50, 50, 1, 1 });
            List<int> histogram = histo.get_histo();
            foreach (int i in histogram)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Press any key to continue");
            Console.Read(); //Wait for user to type
        }
    }
}
