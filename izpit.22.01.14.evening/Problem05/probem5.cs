using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem05
{
    class probem5
    {
        static void Main(string[] args)
        {
            string nm = Console.ReadLine();
            string[] separated = nm.Split(' ');
            int n = int.Parse(separated[0]);
            int m = int.Parse(separated[1]);

            string FxFy = Console.ReadLine();
            string[] separated2 = FxFy.Split(' ');
            int Fx = int.Parse(separated2[0]);
            int Fy = int.Parse(separated2[1]);

            bool[,] areEnemy = new bool[n, m];
            int k = int.Parse(Console.ReadLine());
            for (int i = 0; i < k; i++)
            {
                string line = Console.ReadLine();
                string[] separated3 = line.Split(' ');
                int row = int.Parse(separated3[0]);
                int col = int.Parse(separated3[1]);
                areEnemy[row, col] = true;
            }

            int counter = 0;
            List<char> yess = new List<char>();
            var result = FindNextStep(0,0, Fx, Fy, areEnemy, n, m, counter, yess);
            Console.WriteLine(result.Count);
        }
        static public List<char> FindNextStep(int startrow, int startcol, int Fx, int Fy,bool[,] areEnemy,int n, int m, int counter, List<char> yess)
        { 
            if (startrow == Fx && startcol == Fy)
            {
                yess.Add('y');
            }
            else
            {
                if (startrow < (n - 1) && areEnemy[startrow + 1, startcol] == false)
                {
                    FindNextStep(startrow + 1, startcol, Fx, Fy, areEnemy, n, m, counter, yess);
                }
                if (startcol < (m - 1) && areEnemy[startrow, startcol + 1] == false)
                {
                    FindNextStep(startrow, startcol + 1, Fx, Fy, areEnemy, n, m, counter, yess);
                }
            }
            return yess;
 
        }
    }
}
