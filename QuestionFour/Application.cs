
using QuestionFour.Models;
namespace Application
{
    public class App
    {
        public static List<StateModel> Calculing()
        {
            List<StateModel> list = new List<StateModel>();

            list.Add(new StateModel("SP", Convert.ToDecimal(67836.43)));
            list.Add(new StateModel("RJ", Convert.ToDecimal(36678.66)));
            list.Add(new StateModel("MG", Convert.ToDecimal(29229.88)));
            list.Add(new StateModel("ES", Convert.ToDecimal(27165.48)));
            list.Add(new StateModel("Outros", Convert.ToDecimal(19849.53)));

            decimal maxValue = list.Sum(x => Convert.ToDecimal(x.Value));

            foreach (StateModel state in list)
            {
                state.Percentual = Math.Round(Convert.ToDouble(state.Value * 100 / maxValue), 2, MidpointRounding.AwayFromZero);
            }
            return list;
        }
    }
}
