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
            Dictionary<char, int> test = new Dictionary<char, int>();
            test['a'] = 5;
            test['f'] = 7;
            test['y'] = 1;
            test.OrderBy(test.Values);

        }
    }
}
