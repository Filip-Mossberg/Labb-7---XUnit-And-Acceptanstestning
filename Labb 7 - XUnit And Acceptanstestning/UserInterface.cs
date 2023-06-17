using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_7___XUnit_And_Acceptanstestning
{
    public class UserInterface : Calculator
    {
        public void UserNavigation() // Method not for testing
        {
            while (true)
            {
                switch (UserPick())
                {
                    case 1:
                        var ANumbers = UserInput("sum");
                        decimal AResult = Addition(ANumbers[0], ANumbers[1]);
                        UserOutPut(ANumbers[0], ANumbers[1], AResult, "combined");
                        SaveCalculation(ANumbers[0], ANumbers[1], AResult, "Combined");
                        break;
                    case 2:
                        var SNumbers = UserInput("subtract");
                        decimal SResult = Subtraktion(SNumbers[0], SNumbers[1]);
                        UserOutPut(SNumbers[0], SNumbers[1], SResult, "subtracted");
                        SaveCalculation(SNumbers[0], SNumbers[1], SResult, "Subtracted");
                        break;
                    case 3:
                        var DNumbers = UserInput("divide");
                        decimal DResult = Division(DNumbers[0], DNumbers[1]);
                        UserOutPut(DNumbers[0], DNumbers[1], DResult, "divided");
                        SaveCalculation(DNumbers[0], DNumbers[1], DResult, "Divided");
                        break;
                    case 4:
                        var MNumbers = UserInput("multiply");
                        decimal MResult = Multiplikation(MNumbers[0], MNumbers[1]);
                        UserOutPut(MNumbers[0], MNumbers[1], MResult, "multiplied");
                        SaveCalculation(MNumbers[0], MNumbers[1], MResult, "Multiplied");
                        break;
                    case 5:
                        Console.Clear();
                        GetCalculations();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid Pick!");
                        break;
                }
                Console.ReadLine();
                Console.Clear();
            }
        }

        public int UserPick()
        {
            bool validPick = false;
            int pick = 0;
            do
            {
                Console.WriteLine("1. Addition\n2. Subtract\n3. Division\n4. Multiplication\n5. GetCalculations");
                if(int.TryParse(Console.ReadLine(),out pick))
                {
                    validPick = true;
                }
            } while (false);
            return pick;
        }

        public decimal[] UserInput(string calType)
        {
            Console.WriteLine($"\nWhat numbers would you like to {calType}?");

            Console.WriteLine("\nFirst number:");
            decimal firstNumber = decimal.Parse(Console.ReadLine());

            Console.WriteLine("\nSecond number:");
            decimal secondNumber = decimal.Parse(Console.ReadLine());

            decimal[] collect = new decimal[] { firstNumber, secondNumber };
            return collect;
        }

        public void UserOutPut(decimal num1, decimal num2, decimal result, string calType)
        {
            Console.WriteLine($"\nYou {calType} {num1} and {num2} and the result is {result}!");
        }
    }
}
