using Application;
using QuestionFour.Models;

namespace QuestionFour
{
    class Operation
    {
        public static void Main(string[] args)
        {
            List<StateModel>  result = App.Calculing();

            foreach(var state in result)
            {
                Console.WriteLine("Resultado: " + state.Name +  "| " + "R$ "+ state.Value + " | " + state.Percentual + "%");

            }
        }
    }
}
