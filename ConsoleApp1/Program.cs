namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Podaj numer wyrazu ciagu Fibonacciego:");
        if (long.TryParse(Console.ReadLine(), out long n) && n >= 0)
        {
            int lastdigit = LastFibNumber(n);
            Console.WriteLine($"Ostatnia cyfra tego wyrazu to:" + lastdigit);
        }
        else
        {
            Console.WriteLine("Podaj poprawna liczbe calkowita nieujemna");
        }
    }

    static int LastFibNumber(long n)
    {
        int nlast = (int)(n % 60);
        if (nlast == 0) return 0;
        if (nlast == 1) return 1;

        int a = 0;
        int b = 1;
        int wynik = 0;
        for (int i = 2; i <= nlast; i++)
        {
            wynik = (a + b) % 10;
            a = b;
            b = wynik;
        }

        return nlast == 1 ? 1 : wynik;
    }

}