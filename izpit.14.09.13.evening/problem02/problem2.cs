using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem02
{
    class problem2
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            //step 1-OK
            string[] words = input.Split(' ');
            int maxWordLength = 0;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > maxWordLength)
                    maxWordLength = words[i].Length;
            }

            //step 2-OK
            StringBuilder takingLeters = new StringBuilder();
            for (int i = 0; i < maxWordLength; i++)
            {
                for (int j = 0; j < words.Length; j++)
                {
                    if (words[j].Length - 1 - i>=0)
                    takingLeters.Append(words[j][words[j].Length-1-i]);
                }
            }

            for (int i = 0; i < takingLeters.Length; i++)
            {
                takingLeters = Moving(i, takingLeters);
            }
            Console.WriteLine(takingLeters);
        }

        static StringBuilder Moving(int possition, StringBuilder lettersToMove)
        {
            char symbol = lettersToMove[possition];
            int length = lettersToMove.Length;
            lettersToMove.Remove(possition, 1);
            int numberofMoves = 0;
            string alphabet = "0abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            for (int i=1; i<53; i++)
            {
                if (symbol==alphabet[i])
                    numberofMoves=i%26;
            }
            int newpossition = (possition + numberofMoves) % length;
                lettersToMove.Insert(newpossition, symbol);
            return lettersToMove;
 
        }
        
    }
}
