using Application;
using System.Text.RegularExpressions;

namespace QuestionOne
{
    class Operation
    {
        public static void Main(string[] args)
        {
            Console.Write("Insira o indice: ");
            string word = Regex.Replace(Console.ReadLine(), "[^0-9a-zA-Z]+", "");

            string result = App.Inverting(word);

            Console.WriteLine("Resultado: " + result);
        }
    }
}
