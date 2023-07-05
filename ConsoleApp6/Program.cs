using System;

namespace ConsoleApp6
{
    public class Program
    {
        static void Main(string[] args)
        {/*
            int i = 1;
            while (i <= 10)
            {
                if (i % 2 == 0)
                {
                    i++;
                    continue;
                }
                if (i == 9) break;
                Console.WriteLine(i);
                i++;
                
            }
         */
            /*
            Random rnd = new Random();
            int secretNumber = rnd.Next(1, 11);
            int numberGuessed = 0;
            Console.WriteLine("Random Num :", secretNumber);

            do
            {
                Console.WriteLine("Enter a number between 1 & 10 :");
                numberGuessed = Convert.ToInt32(Console.ReadLine());

            } while (secretNumber != numberGuessed);

            Console.WriteLine("You guessed it it was {0}", secretNumber);*/

            //------FUNCTIONS-----

            static double DoDivision( double x, double y )
            {
                if ( y == 0 )
                {
                    throw new System.DivideByZeroException();
                }
                return x / y;
            }

             //-------END OF FUNCTIONS ----------


            double num1 = 5; 
            double num2 = 0;

            try
            {
                Console.WriteLine("5 / 0 = {0}",
                    DoDivision(num1, num2));
            }

            catch (DivideByZeroException ex)
            {
                Console.WriteLine("You can't divide by zero");
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }

            catch (Exception ex)
            {
                Console.WriteLine("An error occured");
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }

            finally
            {
                Console.WriteLine("Cleaning Up");
            }
        }
    }
}