// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(CountBits(4));   
        Console.WriteLine(CountBits(10));  
        Console.WriteLine(CountBits(1));  
        Console.WriteLine(CountBits(32));  
    }

    static int CountBits(int num)
    {
        string binary = Convert.ToString(num, 2);

        int count = 0;
        
        foreach (char bit in binary)
        {
            if (bit == '1')
            {
                count++;
            }
        }
        return count;
    }
}
