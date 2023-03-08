using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionFour.Models
{
    public class StateModel
    {
        public string Name { get; set; }
        public decimal Value { get; set; }
        public double Percentual { get; set; }

        public StateModel(string name, decimal value, double percentual = 0)
        {
            this.Name = name;
            this.Value = value;
            this.Percentual = percentual;
        }
    }
}
