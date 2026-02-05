namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj Slowo: ");
            string slowo = Console.ReadLine();

            if (string.IsNullOrEmpty(slowo))  return;

            char[] chars = slowo.ToCharArray();

            string wynik = "";

            if (chars.Length % 2 == 0)
            {
                for (int i = 0; i < chars.Length; i += 2)
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
        }// \Main   
    }
}
