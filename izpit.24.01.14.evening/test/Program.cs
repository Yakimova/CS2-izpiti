using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder test = new StringBuilder();
            string word = "me";
            test.Append(word);
            test.Append(word);
            Console.WriteLine(test);
        }
    }
}
