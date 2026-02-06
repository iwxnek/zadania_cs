namespace Next;

class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("Podaj liczbe calkowita(n):");
      double wartosc = double.Parse(Console.ReadLine());
      int n = (int) wartosc;
      double wynik = wartosc;
      Console.WriteLine($"Liczba startowa: {wynik}, Liczba operacji: {n}");

      for (int i = 1; i <= n; i++)
      {
          if (i % 2 != 0)
          {
              wynik = Math.Pow(wynik, 2);
              Console.WriteLine($"Wynik {i}: {wynik}");
          }
          else
          {
              wynik = wynik/2;
              Console.WriteLine($"Wynik {i}: {wynik}");
          }
          Console.WriteLine($"Wynik ostateczny: {wynik}");
      }
    }

    
    
}