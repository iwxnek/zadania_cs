namespace ConsoleApp3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj zdanie");
        string input = Console.ReadLine();
        
        Dictionary<char, int> litery = new Dictionary<char, int>();
        foreach (char litera in input.ToLower())
        {
            if ((char.IsLetter(litera)))
            {
                if (litery.ContainsKey(litera))
                {
                    litery[litera]++;
                }
                else
                {
                    litery[litera] = 1;
                }
            }
        }
        Console.WriteLine("Wystepowanie liter:");
        foreach (KeyValuePair<char, int> item in litery)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
    }
}