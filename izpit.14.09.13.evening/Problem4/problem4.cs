using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    class problem4
    {
        static void Main(string[] args)
        {
            //input
            string message = Console.ReadLine();
            string cypher = Console.ReadLine();
            int lengthofCypher = cypher.Length;

            string afterEncrypting = Encrypt(message, cypher).ToString();
            var check = Encode(afterEncrypting+cypher);
            Console.WriteLine(check.ToString() + lengthofCypher);
        }
        private static int TakingCode(char a)
        {
            int code = (int)a - (int)'A';
            return code;
        }
        private static char BitwiseXOR(char a, char b)
        {
            int code1 = TakingCode(a);
            int code2 = TakingCode(b);
            char result = (char)((code1 ^ code2) + (int)'A');
            return result;
        }
        private static StringBuilder Encrypt(string message, string cypher)
        {
            var result = new StringBuilder();
            if (message.Length >= cypher.Length)
            {
                int cypherLength = cypher.Length;
                for (int i = 0; i < message.Length; i++)
                {
                    result.Append(BitwiseXOR(message[i], cypher[i % cypherLength]));
                }
            }

            else
            {
                var temp = new StringBuilder();
                temp.Append(message);
                for (int i = 0; i < cypher.Length; i++)
                {
                    char a = temp[i % message.Length];
                    int possition = i % message.Length;
                    temp.Remove(possition, 1);
                    temp.Insert(possition, BitwiseXOR(a, cypher[i]));
                }
                result.Append(temp);
            }
            return result;
        }
        private static StringBuilder Encode(string question)
        {
            StringBuilder newtext = new StringBuilder();
            for (int i = 0; i < question.Length; i++)
            {
                char currentchar = question[i];
                int possition = i;
                int counter = 1;
                while (possition+1 <question.Length && currentchar == question[possition + 1])
                {
                    counter++;
                    possition++;
                }
                
                int oldlength = counter;
                int newlength = 0;
                switch (counter / 10)
                {
                    case 0: newlength = 2; break;
                    case 1:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9: newlength = 3; break;
                    case 10: newlength = 4; break;
                    default: newlength = 4; break;
                }

                if (newlength < oldlength)
                {
                    newtext.Append(counter);
                    newtext.Append(currentchar);
                }
                else
                {
                    for (int j = 0; j < counter; j++)
                    {
                        newtext.Append(currentchar);
                    }
                }
                i = possition;
            }
            return newtext;
 
        }
    }
}
