using System;

namespace Współbieżne
{
    public class Program
    {

        public static int multiplication(int x, int y)
        {
            return x * y;
        }

        static void Main(string[] args)
        {
           
            Console.WriteLine("Program mnozy dwie liczby");
            Console.WriteLine("Podaj pierwsza liczbe:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj druga liczbe:");
            int y = int.Parse(Console.ReadLine());


            Console.WriteLine("Wynik: " + multiplication(x, y));
        }
    }
}