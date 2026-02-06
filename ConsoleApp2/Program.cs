namespace ConsoleApp2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj numer wyrazu ciagu: (n)");
        
       if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
       {
           int wynik = Rekurencja(n);
           Console.WriteLine($"Wartosc n-tego wyrazu tego ciagu to: {wynik}");
       }
       else
       {
           Console.WriteLine("Bledna liczba");
       }
       
       
    }

    static int Rekurencja(int n)
    {
        if (n == 1)
        {
            return 2;
        }
        else if  (n % 2 == 0)
        {
            return Rekurencja(n - 1) * 2;
        }
        else
        {
            return Rekurencja(n - 1) + 2;
        }
    }
}