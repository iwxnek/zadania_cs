namespace ConsoleApp4;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj date urodzenia: yyyy-mm-dd");
        string input = Console.ReadLine();
        if (DateTime.TryParse(input, out DateTime date))
        {
            DateTime dzis = DateTime.Today;
            int age = dzis.Year - date.Year;
            if (date.Date > dzis.AddYears(-age))
            {
                age--;
            }
            Console.WriteLine("Twoj wiek to:" + age);
        }
        else
        {
           Console.WriteLine("Bledny format daty"); 
        }
    }
}