using Application;
using static QuestionThree.Models.InvoicingModel;

namespace QuestionThree
{
    class Operation
    {
        public static void Main(string[] args)
        {
            InvoicingMonth result = App.Invoicing();

            Console.WriteLine("Dia com menor faturamento : " + result.DaySmaller.Day.ToString("dd/MM/yyyy") + " | " + result.DaySmaller.DayValue);
            Console.WriteLine("Dia com maior faturamento : " + result.DayBigger.Day.ToString("dd/MM/yyyy") + " | " + result.DayBigger.DayValue);
            Console.WriteLine("Quantidade de dias acima da média : " + result.DaysDailyBigger);
            Console.ReadLine();
        }
    }
}
