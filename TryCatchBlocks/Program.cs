using System;

namespace TryCatchBlocks
{
    class Program
    {
        static void Main(string[] args)
        {
            string ageText = "";
            int age = 0;

            Console.Write("What is your age: ");
            ageText = Console.ReadLine();

            try
            {
                age = int.Parse(ageText);
            }
                catch (FormatException ex)
            {
                Console.WriteLine("You did not enter a valid number.");
                Console.WriteLine(ex.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected exception occurred.");
            }
            

            Console.WriteLine("Your age is {0}", age);

            Console.Read();
        }
    }
}
