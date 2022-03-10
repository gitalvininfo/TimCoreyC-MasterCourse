using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMasterCourse
{
    public class RequestData
    {

        public static string GetAString(string message)
        {
            Console.Write(message);

            string output = Console.ReadLine();
            return output;
        }

        public static double GetADouble(string message)
        {
            bool isDouble = false;
            double output;
            do
            {
                Console.Write(message);
                string numberText = Console.ReadLine();

                isDouble = double.TryParse(numberText, out output);

                if (!isDouble)
                {
                    Console.WriteLine("That was not a valid number. Please try again.");
                }

            } while (!isDouble);

            return output;

        }
    }
}
