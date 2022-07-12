using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class1
    {
        public void DivisionMethod()
        {
            double x;
            double y;
            double result=0;
            try
            {
                Console.Write("Enter first number : ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number : ");
            y = Convert.ToInt32(Console.ReadLine());
           
                result = x / y;
                Console.WriteLine("Output: " + result);
            }

            catch (DivideByZeroException e)
            {

                Console.WriteLine("You cannot divide by zero");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Enter numbers only");
            }

            catch (Exception e)
            {
                Console.WriteLine("Something went wrong");
            }
            finally
            {
                Console.WriteLine("End of the code");
            }
        }

        public void arrayOutOfBounds()
        {
            string[] names = { "Hari", "Eswara", "Kailash", "Avinash", "Iniyan" };
            for (int i = 0; i <= names.Length; i++)
            {
                string SomeName = names[i];
            }
        }
    }
}



