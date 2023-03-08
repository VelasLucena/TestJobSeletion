using Application;

namespace QuestionTwo
{
    class Operation
    {
        public static void Main(string[] args)
        {
            Console.Write("Insira o valor do indice: ");
            int valueFibonacci = Convert.ToInt32(Console.ReadLine());

            bool result = App.CalculatingFibonacci(valueFibonacci);

            Console.WriteLine("Resultado: " + result);
        }
    }
}
