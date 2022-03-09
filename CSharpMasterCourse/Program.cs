
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
            string name = "";
            try
            {
                DifferentMethod();

                //Console.Write("What is your name? ");
                //name = Console.ReadLine();
                //ComplexMethod(name);
                //SimpleMethod();
            }
            /* specific */
            catch(InvalidOperationException ex)
            {
                Console.WriteLine($"You should not be calling the SimpleMethod.");
            }

            catch(NotImplementedException)
            {
                Console.WriteLine("You forgot to finish your code!");
            }
            
            /* general */
            catch (Exception ex) when (name.ToLower() == "tim")
            {
                Console.WriteLine($"You used Tim's name, didn't you?");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex}");
                //Console.WriteLine($"{ex.Message}");
            }
            finally
            {
                Console.WriteLine("I always run");
            }


            Console.Beep();
            Console.ReadKey();
        }

        private static void ComplexMethod(string name)
        {

            if(name.ToLower() == "tim")
            {
                throw new InsufficientMemoryException("Tim is too tall for this method.");
            }   else
            {
                throw new ArgumentException("This person isn't Tim.");
            }
            //throw new NotImplementedException();
        }

        private static void SimpleMethod()
        {
            throw new InvalidOperationException("You should not be calling the SimpleMethod.");
        }

        private static void DifferentMethod()
        {
            Console.WriteLine("This is the different method working properly.");
            //throw new NotImplementedException();
        }


    }
}







