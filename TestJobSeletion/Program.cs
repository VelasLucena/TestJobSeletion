using Application;

namespace QuestionOne 
{
    class Operation
    {
        public static void Main(string[] args)
        {
            Console.Write("Insira o indice: ");
            int indice = Convert.ToInt32(Console.ReadLine());

            int result = App.Calculing(indice);

            Console.WriteLine("Resultado: " + result);
        }
    }
}
