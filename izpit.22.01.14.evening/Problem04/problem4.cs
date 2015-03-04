using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04
{
    class problem4
    {
        static void Main(string[] args)
        {
            //input
            string input = Console.ReadLine();
            string[] temp = input.Split(' ');
            int[] integers = new int[temp.Length];
            for (int i = 0; i < temp.Length; i++)
            {
                integers[i] = int.Parse(temp[i]);
            }

            StringBuilder bigbitwise = new StringBuilder();
            foreach (int number in integers)
            {
                bigbitwise.Append(GettingBitwise8s(number));
            }

            //removing zeroes
            int countingzeroes = 0;
            int index = bigbitwise.Length - 1;
            while (bigbitwise[index] == '0')
            {
                countingzeroes++;
                index--;
            }
            bigbitwise.Remove(index + 1, countingzeroes);
            //Console.WriteLine(bigbitwise);
            
            //more input
            int l = int.Parse(Console.ReadLine());
            string[] inputLines = new string[l];
            Dictionary<char, int> symbols = new Dictionary<char, int>();
            for (int i = 0; i < l; i++)
            {
                var justdoit = new StringBuilder();
                inputLines[i] = Console.ReadLine();
                justdoit.Append(inputLines[i]);
                char key = inputLines[i][0];
                justdoit.Remove(0,1);
                symbols[key] = int.Parse(justdoit.ToString());
            }

            for (int i = 0; i < l; i++)
            {
                int maxvalue = 0;
                char maxkey = '.';
                foreach (KeyValuePair<char, int> kvp in symbols)
                {
                    if (kvp.Value > maxvalue)
                    {
                        maxvalue = kvp.Value;
                        maxkey = kvp.Key;
                    }
                }

                StringBuilder ones = new StringBuilder();
                for (int j = 0; j < maxvalue; j++)
                {
                    ones.Append('1');
                }

                bigbitwise.Replace(ones.ToString(), maxkey.ToString());

                //nulirane na we4e naj-golqmoto
                symbols[maxkey] = 0;
            }
            bigbitwise.Replace("0", "");
            Console.WriteLine(bigbitwise);

        }
        static private string GettingBitwise8s(int number)
        {
            var bitwise = new StringBuilder();
            while (number > 0) //number==0??
            {
                bitwise.Append(number % 2);
                number /= 2;
            }
             int remainder = 8 - bitwise.Length;
            for (int i=0; i<remainder; i++)
            {
                bitwise.Append('0');
            }
            var newbitwise = new StringBuilder();
            for (int i = bitwise.Length - 1; i >= 0; i--)
            {
                newbitwise.Append(bitwise[i]);
            }
            return newbitwise.ToString();
        }
    }
}
