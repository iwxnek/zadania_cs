namespace Ex2;

class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("Podaj ilosc liczb:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Wybierz poczatek przedzialu:");
        int A = int.Parse(Console.ReadLine());
        Console.WriteLine("Wybierz koniec przedzialu:");
        int B = int.Parse(Console.ReadLine());
        if (n > (B - A))
        {
            Console.WriteLine("Przedzial zbyt maly");
            return;
        }

        int suma = 0;
        int[] wynik = new int[n];
        Random rnd = new Random();

        while (suma < n)
        {
            int liczba = rnd.Next(A, B + 1);
            bool exists = false;
            for (int i = 0; i < n; i++)
            {
                if (wynik[i] == liczba)
                {
                    exists = true;
                    break;
                }
            }

            if (exists == false)
            {
                wynik[suma] = liczba;
                suma++;
            }

            Console.WriteLine(string.Join(", ", wynik));

        }
    }
}