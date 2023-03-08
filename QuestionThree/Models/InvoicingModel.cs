using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionThree.Models
{
    public class InvoicingModel
    {
        public class InvoicingMonth
        {
            public InvoicingDay DaySmaller { get; set; }
            public InvoicingDay DayBigger { get; set; }
            public int DaysDailyBigger { get; set; }
        }

        public class InvoicingDay
        {
            public double DayValue { get; set; }

            public DateTime Day { get; set; }
        }
    }
}
