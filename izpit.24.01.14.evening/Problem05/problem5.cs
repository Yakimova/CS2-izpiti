using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem05
{
    class problem5
    {
        static void Main(string[] args)
        {
            string nm = Console.ReadLine();
            string[] sep = nm.Split(' ');
            int n = int.Parse(sep[0]);
            int m = int.Parse(sep[1]);
            int[,] matrix = new int[n, m];
            int k = int.Parse(Console.ReadLine());
            for (int i = 0; i < k; i++)
            {
                string input = Console.ReadLine();
                string[] sepa = input.Split(' ');
                int x = int.Parse(sepa[0]);
                int y = int.Parse(sepa[1]);
                matrix[x, y]++;
            }

            /*for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
             */

            int startx = 0;
            int starty = 0;
            long sum = matrix[startx, starty];
            while (startx!=n-1 && starty!=m-1)
            {
                if (startx == n-1)
                {
                    starty++;
                }
                else if (starty==m-1)
                {
                    startx++;
                }
                else if (matrix[startx + 1, starty] >= matrix[startx, starty + 1])
                {
                    startx++;
                }
                else
                {
                    starty++;
                }
                sum += matrix[startx, starty];
            }

            Console.WriteLine(sum);
        }

    }
}
