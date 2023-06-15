using Labb_7___XUnit_And_Acceptanstestning;

namespace Labb_7___XUnit_Test
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(5, 4, 9)]
        [InlineData(2, 8.3, 10.3)]
        [InlineData(8, 15, 23)]
        [InlineData(3.32, 4.423, 7.743)]
        public void Addition_Should_Return_Sum_Of_Two_Decimal_Values(decimal num1, decimal num2, decimal expected)
        {
            //Arrange
            UserInterface user = new UserInterface(); // Cant make a instace of Calculator since its an abstract class

            //Act
            var result = user.Addition(num1, num2);

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(10, 4, 6)]
        [InlineData(3, 8.3, -5.3)]
        [InlineData(8, 15, -7)]
        [InlineData(8.23, 4.423, 3.807)]
        public void Subtraktion_Should_Return_Result_Of_Two_Substracted_Values(decimal num1, decimal num2, decimal expected)
        {
            //Arrange
            UserInterface user = new UserInterface(); // Cant make a instace of Calculator since its an abstract class

            //Act
            var result = user.Subtraktion(num1, num2);

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(20, 4, 5)]
        [InlineData(17, 5, 3.400)]
        [InlineData(25, 8, 3.125)]
        [InlineData(3, 12, 0.25)]
        public void Subtraktion_Should_Return_Result_Of_Two_Divided_Values(decimal num1, decimal num2, decimal expected)
        {
            //Arrange
            UserInterface user = new UserInterface(); // Cant make a instace of Calculator since its an abstract class

            //Act
            var result = user.Division(num1, num2);

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(9, 10, 90)]
        [InlineData(2.5, 3.5, 8.75)]
        [InlineData(0.75, 6, 4.5)]
        [InlineData(12, 4, 48)]
        public void Multiplikation_Should_Return_Result_Of_Two_Multiplied_Values(decimal num1, decimal num2, decimal expected)
        {
            //Arrange
            UserInterface user = new UserInterface(); // Cant make a instace of Calculator since its an abstract class

            //Act
            var result = user.Multiplikation(num1, num2);

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(2, 8, 10, "Adderade")]
        [InlineData(2, 5, 10, "Multiplicerade")]
        public void SaveCalculation_Should_Save_Calculation_In_calList(decimal num1, decimal num2, decimal result, string calType)
        {
            //Arrange
            UserInterface user = new UserInterface(); // Cant make a instace of Calculator since its an abstract class

            //Act
            var lengthBefore = user.calList.Count();
            user.SaveCalculation(num1, num2, result, calType);
            var lengthAfter = user.calList.Count();

            //Assert
            Assert.True(lengthBefore < lengthAfter);
        }

        [Fact]
        public void GetCalculations_Should_Write_All_Old_Calculations_To_The_Console()
        {
            //Arrange
            UserInterface user = new UserInterface(); // Cant make a instace of Calculator since its an abstract class

            //Act
            var consoleOutPut = new StringWriter();
            Console.SetOut(consoleOutPut);
            user.SaveCalculation(5, 2, 7, "Adderade");
            user.GetCalculations();

            //Assert
            Assert.Equal("Adderade 5 and 2 with a result of 7\r\n", consoleOutPut.ToString());
        }
    }
}