using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01
{
    class Problem1
    {
        static void Main(string[] args)
        {
            ulong input = ulong.Parse(Console.ReadLine());//18000000000000000000;
            List<string> numbers = new List<string>();
            if (input == 0)
            {
                Console.WriteLine("LON+");
            }
            else
            {
                while (input > 0) // if input=0?
                {
                    int digit = (int)(input % 9);
                    switch (digit)
                    {
                        case 0: numbers.Add("LON+"); break;
                        case 1: numbers.Add("VK-"); break;
                        case 2: numbers.Add("*ACAD"); break;
                        case 3: numbers.Add("^MIM"); break;
                        case 4: numbers.Add("ERIK|"); break;
                        case 5: numbers.Add("SEY&"); break;
                        case 6: numbers.Add("EMY>>"); break;
                        case 7: numbers.Add("/TEL"); break;
                        case 8: numbers.Add("<<DON"); break;
                    }
                    input /= 9;
                }

                StringBuilder result = new StringBuilder();
                for (int i = numbers.Count - 1; i >= 0; i--)
                {
                    result.Append(numbers[i]);
                }
                Console.WriteLine(result);
            }
        }
    }
}
