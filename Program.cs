using System.Text.RegularExpressions;

namespace Regexs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] isim = { "jo", "Joke", "As12" };
            for (int i = 0; i < isim.Length; i++)
            {
                if (RegexName(isim[i]))
                {
                    Console.WriteLine("Tugri");
                }
                else
                {
                    Console.WriteLine("Xato");
                }
            }
        }
        static bool RegexName(string name)
        {
            string input = @"^[A-Z]{1}[a-z]*$";

            return Regex.IsMatch(name, input);

        }
    }
    
}