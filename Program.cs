using System;
using System.Net;

class Program
{
    static void Main()
    {
        Random random = new Random();
        while (true)
        {
            Console.ReadLine();
            int randomNumber = random.Next(1, 100000);
            Console.WriteLine(randomNumber);
        }
    }
}