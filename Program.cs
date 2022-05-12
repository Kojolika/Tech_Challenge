using System;
using System.Collections.Generic;



public class Poem
{
    public static void Decode(int numTestCases, String[] TestCases)
    {
        //for each string
        for (int i = 0; i < numTestCases; i++)
        {
            int sqrLen = (int)Math.Sqrt(TestCases[i].Length);

            char[,] charArray = new char[sqrLen, sqrLen];

            int p = 0;

            //convert string to 2d array
            for (int j = 0; j < sqrLen; j++)
            {
                for (int k = 0; k < sqrLen; k++)
                {
                    charArray[j, k] = TestCases[i].ElementAt(p);
                    p++;    
                }
            }

            RotateAndPrint(charArray, sqrLen);
        }
    }
    public static void RotateAndPrint(char[,] cArray, int sqrt)
    {
        char[,] newArray = new char[sqrt, sqrt];

        for(int i = 0; i < sqrt; i++)
        {
            for (int j = 0; j < sqrt; j++)
            {
                   
                int LengthToEnd = sqrt - i - 1;
                newArray[i, j] = cArray[j,LengthToEnd];
                Console.Write(newArray[i, j]);
            }
        }
        Console.WriteLine();
    }

    public static void Main()
    {

        string val;
        Console.Write("Enter integer: ");
        val = Console.ReadLine();
        int numTestCases = int.Parse(val);

        String[] strArray = new string[numTestCases];

        for (int i = 0; i < numTestCases; i++)
        {
            Console.Write("Enter Codedmessage: ");
            strArray[i] = Console.ReadLine();
        }

        Decode(numTestCases, strArray);

    }
}
