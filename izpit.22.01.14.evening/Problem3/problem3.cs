using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    class problem3
    {
        static void Main(string[] args)
        {
            //input
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n]; // to4no na granicata sa
            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                string[] temp = line.Split(' ');
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = int.Parse(temp[j]);
                }
            }

            bool foundpattern = false;
            long maxsum = long.MinValue;
            for (int row = 0; row < n - 2; row++)
            {
                for (int col = 0; col < n - 4; col++)
                {
                    int startnumber = matrix[row, col];
                    int currentsum = startnumber;
                    if (matrix[row, col + 1] == (startnumber + 1) && matrix[row, col + 2] == (startnumber + 2) && matrix[row + 1, col + 2] == (startnumber + 3) && matrix[row + 2, col + 2] == (startnumber + 4) && matrix[row + 2, col + 3] == (startnumber + 5) && matrix[row + 2, col + 4] == (startnumber + 6))
                    {
                        foundpattern = true;
                        currentsum = (7 * startnumber + 1 + 2 + 3 + 4 + 5 + 6);
                    }
                    if (foundpattern == true && currentsum > maxsum)
                    {
                        maxsum = currentsum;
                    }
                }
            }

            if (foundpattern == true)
            {
                Console.WriteLine("YES " + maxsum);
            }
            else
            {
                Console.Write("NO ");
                long diagonal = 0;
                for (int i = 0; i < n; i++)
                {
                    diagonal += matrix[i, i];
                }
                Console.WriteLine(diagonal);
            }
        }
    }
}
