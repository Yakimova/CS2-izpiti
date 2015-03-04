using System;
class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        char[] array = input.ToCharArray();
        string[] coded = new string[array.Length / 3];
        for (int i = 0; i < array.Length; i ++)
        {
            coded[i / 3] += array[i];
        }
        int[] notdecimalNumbers = new int[coded.Length];
        for (int i = 0; i < coded.Length; i++)
        {
            switch (coded[i])
            {
                case "CHU": notdecimalNumbers[i] = 0; break;
                case "TEL": notdecimalNumbers[i] = 1; break;
                case "OFT": notdecimalNumbers[i] = 2; break;
                case "IVA": notdecimalNumbers[i] = 3; break;
                case "EMY": notdecimalNumbers[i] = 4; break;
                case "VNB": notdecimalNumbers[i] = 5; break;
                case "POQ": notdecimalNumbers[i] = 6; break;
                case "ERI": notdecimalNumbers[i] = 7; break;
                case "CAD": notdecimalNumbers[i] = 8; break;
                case "K-A": notdecimalNumbers[i] = 9; break;
                case "IIA": notdecimalNumbers[i] = 10; break;
                case "YLO": notdecimalNumbers[i] = 11; break;
                case "PLA": notdecimalNumbers[i] = 12; break;
            }
        }
        long result = 0;
        for (int i = 0; i < coded.Length; i++)
        {
            long degree13 = 1;
            for (int j = 1; j <= i; j++)
            {
                degree13 *= 13;
            }
            result+=(degree13*notdecimalNumbers[coded.Length - 1 - i]);
        }
        Console.WriteLine(result);
    }
}