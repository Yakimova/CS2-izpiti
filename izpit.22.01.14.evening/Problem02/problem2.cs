using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02
{
    class problem2
    {
        static void Main(string[] args)
        {
            //input
            List<int> bunniesincages = new List<int>();
            string input = Console.ReadLine();
            while (input != "END")
            {
                bunniesincages.Add(int.Parse(input));
                input = Console.ReadLine();
            }

            bool stop = false;
            int i = 1;
            while (stop == false)
            {
                long numberofcages = bunniesincages.Count;

                //1.
                if (i > numberofcages)
                {
                    stop = true;
                    break;
                }
                else
                {
                    //2.
                    int s = 0;
                    for (int j = 0; j < i; j++)
                    {
                        s += bunniesincages[j];
                    }

                    //3.
                    if (s + i > numberofcages) //s+i-1
                    {
                        stop = true;
                        break;
                    }
                    //4.
                    else
                    {
                        ulong nextsum = 0;
                        ulong nextproduct = 1;
                        for (int k = i; k < i + s; k++)
                        {
                            nextsum += (ulong)bunniesincages[k];
                            nextproduct *= (ulong)bunniesincages[k];
                        }

                        //5.
                        var next = new StringBuilder();
                        next.Append(nextsum);
                        next.Append(nextproduct);
                        for (int l = i + s; l < numberofcages; l++)
                        {
                            next.Append(bunniesincages[l]);
                        }
                        next.Replace("0", "");
                        next.Replace("1", "");
                        bunniesincages.Clear();
                        string newbunnies = next.ToString();
                        foreach (char bunny in newbunnies)
                        {
                            bunniesincages.Add(bunny - '0');
                        }
                    }
                }


                i++;
 
            }
            Console.WriteLine(String.Join(" ", bunniesincages));
        }
    }
}
