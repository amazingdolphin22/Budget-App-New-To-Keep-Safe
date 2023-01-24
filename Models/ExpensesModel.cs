using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp.Models
{
    public class ExpensesModel
    {
        public string Item { get; set; }
        public double Value { get; set; }

        //public double sumValue = 0.0;

        public ExpensesModel()
        {

        }

        public ExpensesModel(string i, double v)
        {
            Item = i;
            Value = v;
        }
    }
}
