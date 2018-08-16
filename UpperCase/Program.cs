using System;

namespace UpperCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a sentence");
            string sentence = Console.ReadLine();
            sentence = sentence.ToUpper();
            Console.WriteLine(sentence);
            Console.ReadLine();
        }
    }
}
