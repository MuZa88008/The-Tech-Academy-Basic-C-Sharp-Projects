using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            //===============================================================================================
            //===============================================================================================
            //1.Create a list of integers. Ask the user for a number to divide each number in the list by.
            //  Write a loop that takes each integer in the list, divides it by the number the user entered, 
            //  and displays the result to the screen.
            //===============================================================================================



            //List<int> integers = new List<int>() {10,20,30};
            //Console.WriteLine("Enter a number...: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //foreach (int integer in integers)
            //{
            //    float quotient = integer / number;
            //    Console.WriteLine(quotient);
            //}

            //Console.ReadLine();



            //===============================================================================================
            //===============================================================================================
            //2.Run that code, entering in non - zero numbers as the user.Look at the displayed results.
            //===============================================================================================

            // Results are numbers (float).


            //===============================================================================================
            //===============================================================================================
            //3.Run that code, entering in zero as the number to divide by.Note any error messages you get.
            //===============================================================================================

            // Exceptions are thrown. "System.DivideByZeroException: 'Attempted to divide by zero.


            //===============================================================================================
            //===============================================================================================
            //4.Run that code, entering in a string as the number to divide by.Note any error messages you get.
            //===============================================================================================


            // Exceptions are thrown. " System.FormatException: 'Input string was not in a correct format.'  "

            //===============================================================================================
            //===============================================================================================
            //5.Now put the loop in a try/catch block.
            //  Below and outside of the try/catch block, 
            //  make the program display a message to the display to let you know the program 
            //  has emerged from the try/catch block and continued on with program execution.
            //  In the catch block, display the error message to the screen.Then try various combinations of user input:
            //  valid numbers, zero and a string.Ensure the proper error messages display on the screen, 
            //  and that the code after the try/catch block gets executed.
            //===============================================================================================

            try
            {
                Console.WriteLine("This chunk of code is in a try/catch block.");
                Console.WriteLine("The numbers 10, 20, and 30 are already in memory.");
                List<int> integers = new List<int>() { 10, 20, 30 };
            Console.WriteLine("Enter a number to use...: ");
            int number = Convert.ToInt32(Console.ReadLine());
            
                foreach (int integer in integers)
                {
                    float quotient = integer / number;
                    Console.WriteLine(number + " goes into " + integer + ": " + quotient + " times.");
                }

                Console.ReadLine();
            }
            catch (DivideByZeroException zeroex)    
            {
                Console.WriteLine(zeroex.Message);
                Console.ReadLine();
            }
            catch (FormatException formatex)
            {
                Console.WriteLine(formatex.Message);
                Console.ReadLine();
            }
            catch (Exception generalex)
            {
                Console.WriteLine(generalex.Message);
                Console.ReadLine();
            }

            Console.WriteLine("The program has emerged from the try/catch block");
            Console.WriteLine("This is where the rest of the code would get executed.");
            Console.ReadLine();
        }
    }
}
