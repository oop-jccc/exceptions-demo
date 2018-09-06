using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH13_Exceptions_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Unhandeled();
            //Handeled();
            //TryParse();
            ThrowExample();
        }

        private static void Unhandeled()
        {
            Console.WriteLine("Enter and integer");
            var input = Console.ReadLine();
            var output = int.Parse(input);
            Console.WriteLine(output);
        }

        private static void Handeled()
        {
            try
            {
                Unhandeled();
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("Thank you");
            }
        }

        private static void TryParse()
        {
            Console.WriteLine("Enter and integer");
            var input = Console.ReadLine();
            bool success = int.TryParse(input, out var output);

            if (success)
            {
                Console.WriteLine(output);
            }
            else
            {
                Console.WriteLine("You did something wrong.");
            }

        }
        private static void ThrowExample()
        {
            Console.WriteLine("Enter and integer");
            var input = Console.ReadLine();
            var output = int.Parse(input);
            if(output <0) throw new NegativeNumberException();
        }

    }
}
