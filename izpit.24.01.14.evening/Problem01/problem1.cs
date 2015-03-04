using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01
{
    class problem1
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int possition =0;
            List<int> digits = new List<int>();
            while (possition < input.Length)
            {
                switch (input[possition])
                {
                    case 'f': digits.Add(0); possition++; break;
                    case 'b': digits.Add(1); possition+=3; break;
                    case 'o': digits.Add(2); possition += 5; break;
                    case 'm': digits.Add(3); possition += 7; break;
                    case 'l': digits.Add(4); possition += 6; break;
                    case 'p': digits.Add(5); possition += 4; break;
                    case 'h': digits.Add(6); possition += 2; break;
                }
            }

            long sum = 0;
            for (int i = 0; i < digits.Count; i++)
            {
                sum += (long)(digits[i] * (Math.Pow(7, digits.Count - 1 - i)));
            }
            Console.WriteLine(sum);
        }
    }
}
