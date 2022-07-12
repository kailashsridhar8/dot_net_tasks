using System;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var demo = new Class1();
            try
            {
                demo.DivisionMethod();
                demo.arrayOutOfBounds();
            }
         
            catch (Exception ex)
            {
                string err = ex.Message.ToString();
                Console.Error.WriteLine(err);
            }
        }
    }
}