
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMasterCourse
{
    class Program
    {

        static void Main(string[] args)
        {

            string firstName = RequestData.GetAString("What is your firstname? ");
            
            UserMessages.ApplicationStartMessage(firstName);

            double x = RequestData.GetADouble("Please enter your enter first number: ");
            double y = RequestData.GetADouble("Please enter your enter second number: ");


            double result = CalculateData.Add(x, y);

            UserMessages.PrintResultMessage($"The sum of {x} and {y} is {result}");

            Console.Beep();
            Console.ReadKey();
        }

    }
}







