namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    Random random = new Random();
            //    var suma = 0;
            //    var losowania = 0;
            //    Console.WriteLine("Rozpoczynam Losowanie");
            //    while (suma <= 100)
            //    {
            //        int wylosowana = random.Next(1, 20);
            //        losowania++;
            //        if (wylosowana % 5 == 0)
            //        {
            //            Console.WriteLine("Wylosowana liczba wynosi:" + wylosowana);
            //            suma += wylosowana;
            //        }
            //    }
            //    Console.WriteLine("Koniec");
            //    Console.WriteLine($"Suma liczb podzielnych przez 5 przekroczyla 100 i wynik wynosi: {suma}");
            //    Console.WriteLine($"Laczna liczba losowan: {losowan//    }
            //int n = 10;
            //int A = 1;
            //int B = 100;
            //if (n > (B - A))
            //{
            //    Console.WriteLine("Przedzial zbyt maly");
            //    return;
            //}
            //int suma = 0;
            //int[] wynik = new int[n];
            //Random rnd = new Random();

            //while (suma < n )
            //{
            //    int liczba = rnd.Next(A, B + 1);
            //    bool exists = false;
            //    for (int i = 0; i < n; i++)
            //    {
            //        if (wynik[i] == liczba)
            //        {
            //            exists = true;
            //            break;
            //        }
            //    }

            //        if (exists == false)
            //        {
            //            wynik[suma] = liczba;
            //            suma ++;    
            //        }

            //    Console.WriteLine(string.Join(", ", wynik));
            //Console.WriteLine("Podaj numer PESEL");
            //string pesel = Console.ReadLine();
            //int dlugosc = pesel.ToString().Length;
            //if (dlugosc != 11)
            //{
            //    Console.WriteLine("To nie numer pesel");
            //    return;
            //}
            //int[] wagi = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
            //int suma = 0;
            //for (int i = 0; i < 10; i++)
            //{
            //    suma += wagi[i] * int.Parse(pesel[i].ToString());
            //}
            //int wynikkontrolny = (10 - (suma % 10)) % 10;
            //int ostatnia= int.Parse(pesel[10].ToString());
            //if (ostatnia == wynikkontrolny)
            //{
            //    Console.WriteLine("Jest to numer Pesel");
            //}
            //else 
            //{
            //    Console.WriteLine("Niepoprawny numer PESEL");
            //}
            Console.WriteLine("Podaj liczbe losowan:");
            if (!int.TryParse(Console.ReadLine(), out int liczbaLosowan) || liczbaLosowan <= 0)
            {
                Console.WriteLine("Niepoprawna liczba losowan.");
                return;
            }
            Random rnd = new Random();
            int[] liczniki = new int[101];
            for (int i = 0; i < n; i++)
            {
                int liczba = rnd.Next(1, 101);
                liczniki[liczba]++;
            }
            int wystapienia = 0;
            for (int i = 0; i < liczniki.Length; i++)
            {
                if (liczniki[i] > wystapienia)
                {
                    wystapienia = liczniki[i];
                    
                }
                
            }
            if (wystapienia == 0) 
            {
                Console.WriteLine("Brak losowan.");
            }
            else
            {
                Console.WriteLine($"Liczby wylosowane najwiecej razy: {wystapienia}");
                List<int> najczestszeLiczby = new List<int>();
                for (int i = 0; i < liczniki.Length; i++)
                {
                    if (liczniki[i] == wystapienia)
                    {
                        najczestszeLiczby.Add(i);
                    }
                }
                Console.WriteLine("Liczby wylosowane najwiecej razy: " + string.Join(", ", najczestszeLiczby));
            } 



            









        }


    }

