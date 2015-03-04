using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem3
{
    class proble3
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            string[] some = numbers.Split(' ');
            int x = int.Parse(some[0]);
            int y = int.Parse(some[1]);
            int z = int.Parse(some[2]);

            int rows = y + 1;
            int cols = 2 * (x + y);
            bool[, ] visited = new bool[rows, cols];


            int redRow = y / 2;
            int redCol = x / 2;
            int reddir = 0;

            int blueRow = y / 2;
            int blueCol = x / 2 + x + z;
            int bluedir = 2;

            int[] drows = {0,+1, 0, -1};
            int[] dcols = {+1,0, -1, 0};
            string redmoves = TransformsMoves(Console.ReadLine());
            string bluemoves = TransformsMoves(Console.ReadLine());

            int redMoveIndex =0;
            int blueMoveIndex =0;
            bool redHasCrashed = false;
            bool blueHasCrashed = false;

            while (!redHasCrashed && !blueHasCrashed)
            {
                char redmove = redmoves[redMoveIndex];
                while (redmove != 'M')
                {
                    reddir = ChangeDir(reddir, redmove);
                    redmove = redmoves[++redMoveIndex];
                }

                char bluemove = redmoves[blueMoveIndex];
                while (bluemove != 'M')
                {
                    bluedir = ChangeDir(bluedir, bluemove);
                    bluemove = bluemoves[++blueMoveIndex];
                }

                int nextRedRow = redRow + drows[reddir];
                int nextRedCol = redCol + dcols[reddir];
                nextRedCol = (nextRedCol + cols) % cols;

                int nextBlueRow = blueRow + drows[bluedir];
                int nextBlueCol = blueCol + dcols[bluedir];
                nextBlueCol = (nextBlueCol + cols) % cols;

                if (nextRedCol<0 || nextRedCol>=rows ||
                    visited[nextRedRow, nextRedCol] ||
                    (nextRedRow == nextBlueRow && nextRedCol == nextBlueCol))
                {
                    redHasCrashed = true;
                }

                if (nextBlueCol < 0 || nextBlueCol >= rows ||
                    visited[nextBlueRow, nextBlueCol] ||
                    (nextRedRow == nextBlueRow && nextRedCol==nextBlueCol))
                {
                    blueHasCrashed = true;
                }

                if (redHasCrashed || blueHasCrashed)
                    break;

                visited[nextRedRow, nextRedCol] = true;
                visited[nextBlueRow, nextBlueCol] = true;
                redRow = nextRedRow;
                redCol = nextRedCol;
                blueCol = nextBlueCol;
                blueRow = nextBlueRow;
                redMoveIndex++;
                blueMoveIndex++;
            }

            if (redHasCrashed && blueHasCrashed)
            {
                Console.WriteLine("DRAW");
            }
            else if (redHasCrashed)
            {
                Console.WriteLine("BLUE");
            }
            else
            {
                Console.WriteLine("RED");
            }
            int startRow = y / 2;
            int startCol = x / 2;
            int distance = Math.Abs(startRow - redRow) + Math.Abs(startCol - redCol);
            Console.WriteLine(distance);

        }

        private static int ChangeDir(int reddir, char redmove)
        {
            if (redmove == 'L')
            {
                --reddir;
            }
            else
            {
                ++reddir;
            }
            return (reddir+4) % 4;
        }

        private static string TransformsMoves(string moves)
        {
            var builder = new StringBuilder();
            List<char> digits =  new List<char>();           
            foreach (char move in moves)
            {
                if (char.IsDigit(move))
                {
                    digits.Add(move);
                }
                else
                {
                    if (digits.Count == 0)

                    {
                        digits.Add('1');
                    }
                    digits.Reverse();
                    int count = int.Parse(string.Join("", digits));
                    builder.Append(move, count);
                    digits.Clear();
                }
            }
            return builder.ToString();
        }
    }
}
