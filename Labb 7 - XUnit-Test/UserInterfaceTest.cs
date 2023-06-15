using Labb_7___XUnit_And_Acceptanstestning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Labb_7___XUnit_Test
{
    public class UserInterfaceTest
    {
        [Fact]
        public void UserPick_Should_Return_A_Int() // It's fine if it returns any int, if the int is not a valid pick then the application will give an error that would be tested in another test. (above)
        {
            //Arrange
            UserInterface user = new UserInterface();

            //Act
            var input = new StringReader("5");
            Console.SetIn(input);

            int pick = user.UserPick();
            int expected = 5;

            //Assert
            Assert.Equal(expected, pick);
        }

        [Theory]
        [InlineData("5", "2", 5, 2)]
        [InlineData("32", "7", 32, 7)]
        [InlineData("14", "6", 14, 6)]
        public void UserInput_Should_Return_A_Decimal_Array_Containing_Two_Decimals(string num1, string num2, decimal exp1, decimal exp2)
        {
            //Arrange
            UserInterface user = new UserInterface();

            //Act
            var input = new StringReader($"{num1}\n{num2}");
            Console.SetIn(input);

            decimal[] outPut = new decimal[] { };
            outPut = user.UserInput("multiply");

            decimal[] expected = new decimal[] { exp1, exp2};

            //Assert
            Assert.Equal(expected, outPut);
        }

        [Fact]
        public void UserInput_Should_Return_UnHandeldException_Error()
        {
            //Arrange
            UserInterface user = new UserInterface();

            //Act
            var input = new StringReader($"2\nhej");
            Console.SetIn(input);

            //Assert
            Assert.Throws<FormatException>(() => user.UserInput("multiply"));
        }

        [Fact]
        public void UserOutPut_Should_Write_A_Message_To_The_Console()
        {
            //Arrange
            UserInterface user = new UserInterface();

            //Act
            var consoleOutPut = new StringWriter();
            Console.SetOut(consoleOutPut);

            user.UserOutPut(2, 5, 7, "adderade");
            string expected = "\nYou adderade 2 and 5 and the result is 7!\r\n";

            //Assert
            Assert.Equal(expected, consoleOutPut.ToString());
        }
    }
}
