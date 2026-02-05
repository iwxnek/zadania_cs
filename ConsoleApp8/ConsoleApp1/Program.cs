using System.ComponentModel.Design;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj Slowo: ");
            string slowo = Console.ReadLine();
            if (string.IsNullOrEmpty(slowo))
            {
                Console.WriteLine("Podano puste słowo. Program zakończy działanie.");
                return;
            }
            else
            {
                int poczatek = (slowo.Length - 1) / 2;
                int dlugosc = (slowo.Length % 2 == 0) ? 2 : 1;
                slowo.Substring(poczatek, dlugosc);
            }
        }
    }
}
