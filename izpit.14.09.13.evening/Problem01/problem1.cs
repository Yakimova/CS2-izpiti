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
            string[] mesage = new string[input.Length / 4];
            for (int i = 0; i < input.Length; i++)
            {
                mesage[i / 4] += input[i];
            }

            int[] numbers = new int[input.Length / 4];
            long result = 0;
            for (int i = 0; i < mesage.Length; i++)
            {
                switch (mesage[i])
                {
                    case "Rawr": numbers[i] = 0; break;
                    case "Rrrr": numbers[i] = 1; break;
                    case "Hsst": numbers[i] = 2; break;
                    case "Ssst": numbers[i] = 3; break;
                    case "Grrr": numbers[i] = 4; break;
                    case "Rarr": numbers[i] = 5; break;
                    case "Mrrr": numbers[i] = 6; break;
                    case "Psst": numbers[i] = 7; break;
                    case "Uaah": numbers[i] = 8; break;
                    case "Uaha": numbers[i] = 9; break;
                    case "Zzzz": numbers[i] = 10; break;
                    case "Bauu": numbers[i] = 11; break;
                    case "Djav": numbers[i] = 12; break;
                    case "Myau": numbers[i] = 13; break;
                    case "Gruh": numbers[i] = 14; break;
                }
                long temp = numbers[i] * (long)(Math.Pow(15, mesage.Length - 1-i));
                result += temp;
            }

            Console.WriteLine(result);
        }
    }
}
