using static QuestionThree.Models.InvoicingModel;

namespace Application
{
    public class App
    {
        public static InvoicingMonth Invoicing()
        {
            List<InvoicingDay> list = new List<InvoicingDay>();
            InvoicingMonth result = new InvoicingMonth();

            Random rnd = new Random();

            DateTime firstDay = new DateTime(Convert.ToInt32(DateTime.Now.Year), Convert.ToInt32(DateTime.Now.Month), 1);

            for (int i = 0; i < 30; i++)
            {
                list.Add(new InvoicingDay()
                {
                    DayValue = Math.Round((rnd.Next(10000) + rnd.NextDouble()), 2),
                    Day = firstDay.AddDays(i)
                });
            }

            double media = 0;

            for(int i = 0; i < list.Count; i++)
            {
                media +=list[i].DayValue;
            }

            media = media / list.Count;

            double valueMin= double.MaxValue;
            double valueMax = 1;
            int daysMedia = 0;
            DateTime dayMin =  DateTime.Now;
            DateTime dayMax =  DateTime.Now;

            foreach (var item in list)
            {
                if(item.DayValue <= valueMin)
                {
                    valueMin = item.DayValue;
                    dayMin = item.Day;
                }

                if (item.DayValue >= valueMax)
                {
                    valueMax = item.DayValue;
                    dayMax = item.Day;
                }

                if (item.DayValue > media)
                    daysMedia++;
            }

            result.DaySmaller = new InvoicingDay { Day = dayMin, DayValue = valueMin};

            result.DayBigger = new InvoicingDay { Day = dayMax, DayValue = valueMax};

            result.DaysDailyBigger = daysMedia;

            return result;

        }
    }
}
