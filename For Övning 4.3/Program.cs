using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv en textrad : ");
            string text = Console.ReadLine();
            for (int i = text.Length-1; i >=0; i--)
            {
                Console.WriteLine(text[i]);
            }
            
        }
    }
}
