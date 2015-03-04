using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03
{
    class problem3
    {
        static void Main(string[] args)
        {
            //input
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                string[] temp = line.Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = int.Parse(temp[j]);
                }
            }

            //check
            /*for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
             */

            int sum = 0;
            sum += CountingOnes(matrix, n);
            sum += (2*CountingTwos(matrix, n));
            sum += (3 * CountingThrees(matrix, n));
            sum += (4 * CountingFours(matrix, n));
            sum += (5 * CountingFives(matrix, n));
            sum += (6 * CountingSixs(matrix, n));
            sum += (7 * CountingSevens(matrix, n));
            sum += (8 * CountingEigths(matrix, n));
            sum += (9 * CountingNines(matrix, n));

            Console.WriteLine(sum);


        }
        static int CountingOnes(int[,] matrix, int n)
        {
            int br = 0;
            for (int i = 0; i < n - 4; i++)
            {
                for (int j = 2; j < n; j++)
                {
                    if (matrix[i, j] == 1 && 
                        matrix[i + 1, j - 1] == 1 && matrix[i + 1, j] == 1 && 
                        matrix[i + 2, j - 2] == 1 && matrix[i + 2, j] == 1 &&
                        matrix[i + 3, j] == 1 && 
                        matrix[i + 4, j] == 1)
                    {
                        br++;
                    }
                }
            }

            return br;
        }
        static int CountingTwos(int[,] matrix, int n)
        {
            int br = 0;
            int k = 2;
            for (int i = 0; i < n - 4; i++)
            {
                for (int j = 1; j < n-1; j++)
                {
                    if (matrix[i, j] == k && matrix[i + 1, j - 1] == k && matrix[i + 1, j + 1] == k && matrix[i + 2, j + 1] == k && matrix[i + 3, j] == k && matrix[i + 4, j - 1] == k && matrix[i + 4, j] == k && matrix[i + 4, j+1] == k)
                    {
                        br++;
                    }
                }
            }
            return br;
        }
        static int CountingThrees(int[,] matrix, int n)
        {
            int br = 0;
            int k = 3;
            for (int i = 0; i < n - 4; i++)
            {
                for (int j = 0; j < n - 2; j++)
                {
                    if (matrix[i, j] == k && matrix[i, j + 1] == k && matrix[i, j + 2] == k && matrix[i + 1, j + 2] == k && matrix[i + 2, j + 1] == k && matrix[i + 2, j + 2] == k && matrix[i + 3, j + 2] == k && matrix[i + 4, j] == k && matrix[i + 4, j+1] == k && matrix[i + 4, j+2] == k)
                    {
                        br++;
                    }
                }
            }
            return br;
        }
        static int CountingFours(int[,] matrix, int n)
        {
            int br = 0;
            int k = 4;
            for (int i = 0; i < n - 4; i++)
            {
                for (int j = 0; j < n - 2; j++)
                {
                    if (matrix[i, j] == k && matrix[i, j + 2] == k && matrix[i + 1, j] == k && matrix[i + 1, j + 2] == k && matrix[i + 2, j] == k && matrix[i + 2, j + 1] == k && matrix[i + 2, j + 2] == k && matrix[i + 3, j + 2] == k && matrix[i + 4, j+2] == k)
                    {
                        br++;
                    }
                }
            }
            return br;
        }
        static int CountingFives(int[,] matrix, int n)
        {
            int br = 0;
            int k = 5;
            for (int i = 0; i < n - 4; i++)
            {
                for (int j = 0; j < n - 2; j++)
                {
                    if (matrix[i, j] == k && matrix[i, j + 1] == k && matrix[i, j + 2] == k && matrix[i + 1, j] == k && matrix[i + 2, j] == k && matrix[i + 2, j + 1] == k && matrix[i + 2, j + 2] == k && matrix[i + 3, j + 2] == k && matrix[i + 4, j] == k && matrix[i + 4, j + 1] == k && matrix[i + 4, j + 2] == k)
                    {
                        br++;
                    }
                }
            }
            return br;
        }
        static int CountingSixs(int[,] matrix, int n)
        {
            int br = 0;
            int k = 6;
            for (int i = 0; i < n - 4; i++)
            {
                for (int j = 0; j < n - 2; j++)
                {
                    if (matrix[i, j] == k && matrix[i, j + 1] == k && matrix[i, j + 2] == k && matrix[i + 1, j] == k && matrix[i + 2, j] == k && matrix[i + 2, j + 1] == k && matrix[i + 2, j + 2] == k && matrix[i + 3, j] == k && matrix[i + 3, j + 2] == k && matrix[i + 4, j] == k && matrix[i + 4, j + 1] == k && matrix[i + 4, j + 2] == k)
                    {
                        br++;
                    }
                }
            }
            return br;
        }
        static int CountingSevens(int[,] matrix, int n)
        {
            int br = 0;
            int k = 7;
            for (int i = 0; i < n - 4; i++)
            {
                for (int j = 0; j < n - 2; j++)
                {
                    if (matrix[i, j] == k && matrix[i, j + 1] == k && matrix[i, j + 2] == k && matrix[i + 1, j + 2] == k && matrix[i + 2, j+1] == k && matrix[i + 3, j + 1] == k && matrix[i + 4, j+1] == k)
                    {
                        br++;
                    }
                }
            }
            return br;
        }
        static int CountingEigths(int[,] matrix, int n)
        {
            int br = 0;
            int k = 8;
            for (int i = 0; i < n - 4; i++)
            {
                for (int j = 0; j < n - 2; j++)
                {
                    if (matrix[i, j] == k && matrix[i, j + 1] == k && matrix[i, j + 2] == k &&
                        matrix[i + 1, j] == k && matrix[i + 1, j+2] == k && 
                        matrix[i + 2, j+1] == k && 
                        matrix[i + 3, j] == k && matrix[i + 3, j + 2] == k && 
                        matrix[i + 4, j] == k && matrix[i + 4, j + 1] == k && matrix[i + 4, j + 2] == k)
                    {
                        br++;
                    }
                }
            }
            return br;
        }
        static int CountingNines(int[,] matrix, int n)
        {
            int br = 0;
            int k = 9;
            for (int i = 0; i < n - 4; i++)
            {
                for (int j = 0; j < n - 2; j++)
                {
                    if (matrix[i, j] == k && matrix[i, j + 1] == k && matrix[i, j + 2] == k &&
                        matrix[i + 1, j] == k && matrix[i + 1, j + 2] == k &&
                        matrix[i + 2, j + 1] == k && matrix[i + 2, j + 2] == k &&
                        matrix[i + 3, j + 2] == k &&
                        matrix[i + 4, j] == k && matrix[i + 4, j + 1] == k && matrix[i + 4, j + 2] == k)
                    {
                        br++;
                    }
                }
            }
            return br;
        }
    }
}
