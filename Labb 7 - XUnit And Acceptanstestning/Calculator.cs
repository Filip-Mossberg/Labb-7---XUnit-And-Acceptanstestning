using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_7___XUnit_And_Acceptanstestning
{
    public abstract class Calculator 
    {
        public List<Calculation> calList = new List<Calculation>();
        public decimal Addition(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        public decimal Subtraktion(decimal num1, decimal num2)
        {
            return num1 - num2;
        }

        public decimal Division(decimal num1, decimal num2)
        {
            return num1 / num2;
        }

        public decimal Multiplikation(decimal num1, decimal num2)
        {
            return num1 * num2;
        }

        public void SaveCalculation(decimal num1, decimal num2, decimal result, string calType)
        {
            Calculation cal = new Calculation(calType, num1, num2, result);
            calList.Add(cal);
        }

        public void GetCalculations()
        {
            foreach (var item in calList)
            {
                Console.WriteLine($"{item.CalType} {item.NumberOne} and {item.NumberTwo} with a result of {item.Result}");
            }
        }
    }
}
