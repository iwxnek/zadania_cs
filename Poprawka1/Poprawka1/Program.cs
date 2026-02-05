namespace Poprawka1
{
    internal class Program
    {
        static int Main(string[] args)
        {

            //ZADANIE4
            //Console.WriteLine("Podaj liczbe losowan:");
            //if (!int.TryParse(Console.ReadLine(), out int liczbaLosowan) || liczbaLosowan <= 0)
            //{
            //    Console.WriteLine("Niepoprawna liczba losowan.");
            //    return;
            //}
            //Random rnd = new Random();
            //int[] liczniki = new int[101];
            //for (int i = 0; i < liczbaLosowan; i++)
            //{
            //    int liczba = rnd.Next(1, 101);
            //    liczniki[liczba]++;
            //}
            //int wystapienia = 0;
            //for (int i = 0; i < liczniki.Length; i++)
            //{
            //    if (liczniki[i] > wystapienia)
            //    {
            //        wystapienia = liczniki[i];

            //    }

            //}
            //if (wystapienia == 0)
            //{
            //    Console.WriteLine("Brak losowan.");
            //}
            //else
            //{
            //    Console.WriteLine($"Liczby wylosowane najwiecej razy: {wystapienia}");
            //    List<int> najczestszeLiczby = new List<int>();
            //    for (int i = 0; i < liczniki.Length; i++)
            //    {
            //        if (liczniki[i] == wystapienia)
            //        {
            //            najczestszeLiczby.Add(i);
            //        }
            //    }
            //    Console.WriteLine("Liczby wylosowane najwiecej razy: " + string.Join(", ", najczestszeLiczby));
            //}
            // ZADANIE5

            //Console.WriteLine("Podaj liczbe losowan:");
            //Random rnd = new Random();
            //if (!int.TryParse(Console.ReadLine(), out int liczbaLosowan) || liczbaLosowan <= 0)
            //{
            //    Console.WriteLine("Podaj poprawna liczbe losowan");
            //    return;
            //}

            //int[] liczby = new int[liczbaLosowan];

            //for (int i = 0; i < liczbaLosowan; i++)
            //{
            //    liczby[i] = rnd.Next(1, 100);
            //}

            //Array.Sort(liczby);
            //Console.WriteLine("Wylosowane i posortowane liczby:");
            //Console.WriteLine(string.Join(",", liczby));

            //double mediana;
            //int srodek = liczbaLosowan / 2;

            //if (liczbaLosowan % 2 != 0)
            //{
            //    mediana = liczby[srodek];
            //}
            //else
            //{
            //    mediana = (liczby[srodek - 1] + liczby[srodek]) / 2.0;
            //}
            //Console.WriteLine($"Mediana wynosi:" + mediana);

            //ZADANIE6
            //Console.WriteLine("Podaj liczbe dziesietna:");
            //string input = Console.ReadLine());
            //if (double.TryParse(input.Replace('.', ','), out double liczba))

            //ZADANIE7
            //Console.Write("Podaj poczatek przedzialu: A:");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("Podaj koniec przedzialu: B:");
            //int b = int.Parse(Console.ReadLine());

            //int start = Math.Min(a, b);
            //int end = Math.Max(a, b);

            //int prime = 0;
            //int rest = 0;
            //for (int i = start; i <= end; i++)
            //{
            //    bool isPrime = true;
            //    if(i < 2)
            //    {
            //        isPrime = false;
            //    }
            //    else
            //    {
            //        for (int j = 2; j <= Math.Sqrt(i); j++)
            //        {
            //            if (i % j == 0)
            //            {
            //                isPrime = false;
            //                break;
            //            }
            //        }
            //    }
            //  if (isPrime)
            //    {
            //        prime += i;
            //    }
            //    else
            //    {
            //        rest += i;
            //    }
            //}
            //Console.WriteLine("Suma liczb pierwszych:" + prime);
            //Console.WriteLine("Suma pozostalych:" + rest);
            Console.Write("Podaj Slowo: ");
            string slowo = Console.ReadLine();

            if (string.IsNullOrEmpty(slowo));
            
            char[] chars = slowo.ToCharArray();
            
            string wynik = "";
            
            if (chars.Length % 2 == 0)
            {
                for(int i = 0; i < chars.Length; i += 2)
                {
                    char temp = chars[i];
                    chars[i] = chars[i + 1];
                    chars[i + 1] = temp;
                }
                wynik = new string(chars);
            }
            else
            {
                char ostatnia = chars[chars.Length - 1];
                char[] reszta = new char[chars.Length - 1];
                Array.Copy(chars, 0, reszta, 0, chars.Length - 1);
                for (int i = 0; i < reszta.Length; i += 2)
                {
                    char temp = reszta[i];
                    reszta[i] = reszta[i + 1];
                    reszta[i + 1] = temp;
                }
                wynik = ostatnia + new string(reszta);
            }
            Console.WriteLine("Wynik:" + wynik);
        }
    }
}
