using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Problem02
{
    class problem2
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] spliting = input.Split(' ');
            BigInteger[] cells = new BigInteger[spliting.Length];
            for (int i = 0; i < cells.Length; i++)
            {
                cells[i] = BigInteger.Parse(spliting[i]);
            }
            int n = cells.Length;

            bool MolyEmpty = false;
            bool DolyEmpty = false;
            int MolyStartCell = 0;
            int DolyStartCell = (n - 1);
            BigInteger MolyFlowers = 0;
            BigInteger DolyFlowers = 0;

            while (MolyEmpty == false && DolyEmpty == false)
            {
                //when ends?
                if (cells[MolyStartCell] == 0 && cells[DolyStartCell] ==0)
                {
                    MolyEmpty = true;
                    DolyEmpty = true;
                    break;
                }
                else if (cells[MolyStartCell] == 0)
                {
                    DolyFlowers += cells[DolyStartCell];
                    BigInteger f2 = cells[DolyStartCell];
                    cells[DolyStartCell] = 0;
                    BigInteger temp = DolyStartCell - f2;
                    temp %= n;
                    DolyStartCell = (int)temp;
                    if (DolyStartCell < 0)
                    {
                        DolyStartCell = n + DolyStartCell;
                    }

                    MolyEmpty = true;
                    break;
                }
                else if (cells[DolyStartCell] == 0) 
                {
                    MolyFlowers += cells[MolyStartCell];
                    BigInteger f1 = cells[MolyStartCell];
                    cells[MolyStartCell] = 0;
                    BigInteger temp2 = MolyStartCell + f1;
                    temp2 %= n;
                    MolyStartCell = (int)temp2;

                    DolyEmpty = true;
                    break;
                }

                else
                {
                    if (MolyStartCell == DolyStartCell)
                    {
                        BigInteger f = cells[MolyStartCell];
                        MolyFlowers += (cells[MolyStartCell] / 2);
                        DolyFlowers += (cells[MolyStartCell] / 2);
                        if (cells[MolyStartCell] % 2 == 0)
                        {
                            cells[MolyStartCell] = 0;
                        }
                        else
                        {
                            cells[MolyStartCell] = 1;
                        }

                        BigInteger temp2 = MolyStartCell + f;
                        temp2 %= n;
                        MolyStartCell = (int)temp2;
                        BigInteger temp = DolyStartCell - f;
                        temp %= n;
                        DolyStartCell = (int)temp;
                        if (DolyStartCell < 0)
                        {
                            DolyStartCell = n + DolyStartCell;
                        }
                    }
                    else
                    {
                        MolyFlowers += cells[MolyStartCell];
                        BigInteger f1 = cells[MolyStartCell];
                        cells[MolyStartCell] = 0;
                        BigInteger temp2 = MolyStartCell + f1;
                        temp2 %= n;
                        MolyStartCell = (int)temp2;

                        DolyFlowers += cells[DolyStartCell];
                        BigInteger f2 = cells[DolyStartCell];
                        cells[DolyStartCell] = 0;
                        BigInteger temp = DolyStartCell - f2;
                        temp %= n;
                        DolyStartCell = (int)temp;
                        if (DolyStartCell < 0)
                        {
                            DolyStartCell = n + DolyStartCell;
                        }
                    }
                }
 
            }

            //output
            if (MolyEmpty == true && DolyEmpty == true)
            {
                Console.WriteLine("Draw");
            }
            else if (MolyEmpty == true)
            {
                Console.WriteLine("Dolly");
            }
            else
            {
                Console.WriteLine("Molly");
            }

            Console.WriteLine(MolyFlowers + " " + DolyFlowers);

        }
    }
}
