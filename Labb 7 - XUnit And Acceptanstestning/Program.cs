using System.Linq.Expressions;

namespace Labb_7___XUnit_And_Acceptanstestning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StartProgram();
        }
        public static void StartProgram()
        {
            UserInterface start = new UserInterface();
            start.UserNavigation();
        }
    }
}