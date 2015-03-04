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
            string searchword = Console.ReadLine();
            searchword = searchword.ToLower();
            int l = int.Parse(Console.ReadLine()); //l = number of paragraphs
            string[] result = new string[l];
            int[] counter = new int[l];
            for (int i = 0; i < l; i++)
            {
                string line = Console.ReadLine();
                line = line.ToLower();
                string[] words = line.Split(new char[] { ' ', ',', '.', '(', ')', ';', '-', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
                StringBuilder test = new StringBuilder();
                foreach (string word in words)
                {
                    if (word == searchword)
                    {
                        counter[i]++;
                        string upper = word.ToUpper();
                        test.Append(upper);
                        test.Append(' ');
                    }
                    else
                    {
                        test.Append(word);
                        test.Append(' ');
                    }
                }
                test.Remove(test.Length - 1, 1);
                result[i] = test.ToString();
            }

            for (int i = 0; i < l; i++)
            {
                int max = -1;
                int maxindex = -1;
                for (int j = 0; j < l; j++)
                {
                    if (counter[j] >= max)
                    {
                        max = counter[j];
                        maxindex = j;
                    }
                }
                Console.WriteLine(result[maxindex]);
                counter[maxindex] = -1;
            }
        }
    }
}
