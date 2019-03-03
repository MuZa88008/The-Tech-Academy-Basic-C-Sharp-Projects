using System;
using System.Collections.Generic;

namespace Iteration_Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            //================================================================================================
            //================================================================================================
            //// 1.Create a one-dimensional Array of strings.
            //// Ask the user to input some text.
            //// Create a loop that goes through each string in the Array, adding the user’s text to the string.
            //// Then create a loop that prints off each string in the Array on a separate line.
            //================================================================================================
            //================================================================================================

            //string[] userInputs = new string[4];

            //List<string> userInputs = new List<string>();
            //int i = 0;

            //do
            //{
            //    Console.WriteLine("Please enter some text for our test array...:");
            //    userInputs.Add(Console.ReadLine());
            //    i++;
            //}
            //while (i <= 4);

            //string[] userinputs = userInputs.ToArray();

            //int j = 0;
            //do
            //{
            //    Console.WriteLine(userInputs[j]);
            //    j++;
            //}
            //while (j <= 4);
            //Console.ReadLine();




            //================================================================================================
            //================================================================================================
            // ALTERNATE SOLUTION using foreach...
            //// 1.Create a one-dimensional Array of strings.
            //// Ask the user to input some text.
            //// Create a loop that goes through each string in the Array, adding the user’s text to the string.
            //// Then create a loop that prints off each string in the Array on a separate line.
            //================================================================================================
            //================================================================================================

            //List<string> userInputs = new List<string>();
            //int i = 0;

            //do
            //{
            //    Console.WriteLine("Please enter some text for our test array...:");
            //    userInputs.Add(Console.ReadLine());
            //    i++;
            //}
            //while (i <= 4);

            //foreach (string userInput in userInputs)   
            //{
            //    Console.WriteLine(userInput);
            //}

            //Console.ReadLine();




            //================================================================================================
            //================================================================================================
            //// 2.Create an infinite loop.
            //================================================================================================
            //================================================================================================

            //int k = 0;
            //do
            //{
            //    Console.WriteLine("Infinite Loop!");
            //}
            //while (k <= 4);
            //Console.ReadLine();



            //================================================================================================
            //================================================================================================
            // 3.Fix the infinite loop so it will execute.
            //================================================================================================
            //================================================================================================

            //int l = 0;
            //do
            //{
            //    Console.WriteLine("Not an infinite loop!");
            //    l++;
            //}
            //while (l <= 4);
            //Console.ReadLine();



            //================================================================================================
            //================================================================================================
            // 4.Create a loop where the comparison used to determine whether to continue iterating the loop is a “<” operator.
            //================================================================================================
            //================================================================================================

            //int m = 0;
            //do
            //{
            //    Console.WriteLine(m + ".  Loop using \"<\" operator.");
            //    m++;
            //}
            //while (m < 20);
            //Console.ReadLine();




            //================================================================================================
            //================================================================================================
            // 5.Create a loop where the comparison used to determine whether to continue iterating the loop is a “<=” operator.
            //================================================================================================
            //================================================================================================

            //int n = 0;
            //do
            //{
            //    Console.WriteLine(n + ".  Loop using \"<=\" operator.");
            //    n++;
            //}
            //while (n <= 20);
            //Console.ReadLine();




            //================================================================================================
            //================================================================================================
            // 6.Create a List of strings where each item in the list is unique.
            // Ask the user to select text to search for in the List.
            // Create a loop that iterates through the list and then displays the index of the array that contains matching text on the screen.
            //================================================================================================
            //================================================================================================

            //List<string> names = new List<string>() { "create", "a", "list", "of", "strings", "where", "each", "item", "in", "the",  "is", "unique", "ask", "user", "to", "select", "text", "search", "for", "index", "array", "that", "contains", "matching", "on", "screen", "loop", "iterates", "through", "and", "then", "displays"};

            //Console.WriteLine("Search list for (enter text)...: ");
            //string searchText = Console.ReadLine();

            //foreach (string name in names)  
            //{
            //    if (name == searchText)
            //    {
            //        Console.WriteLine("The text you searched for is at index " + names.IndexOf(searchText) + " of the array.");
            //    }
            //    else
            //    {
                   
            //    }
            //}
            //Console.ReadLine();

            //================================================================================================
            //================================================================================================
            // 7.Add code to that above loop that tells a user if they put in text that isn’t in the List.
            //================================================================================================
            //================================================================================================

            List<string> names = new List<string>() { "create", "a", "list", "of", "strings", "where", "each", "item", "in", "the", "is", "unique", "ask", "user", "to", "select", "text", "search", "for", "index", "array", "that", "contains", "matching", "on", "screen", "loop", "iterates", "through", "and", "then", "displays" };

            Console.WriteLine("Search list for (enter text)...: ");
            string searchText = Console.ReadLine();

            foreach (string name in names)
            {
                if (name == searchText)
                {
                    Console.WriteLine("The text you searched for is at index " + names.IndexOf(searchText) + " of the array.");
                }
                else
                {

                }
            }
            Console.WriteLine("The text you entered isn't in the List.");
            Console.ReadLine();






            //================================================================================================
            //================================================================================================
            // 9.Create a List of strings that has at least two identical strings in the List. Ask the user to select text to search for in the List.
            // Create a loop that iterates through the list and then displays the indices of the array that contain matching text on the screen.
            //================================================================================================
            //================================================================================================





            //================================================================================================
            //================================================================================================
            // 10.Add code to that above loop that tells a user if they put in text that isn’t in the List.
            //================================================================================================
            //================================================================================================





            //================================================================================================
            //================================================================================================
            // 11.Create a List of strings that has at least two identical strings in the List. 
            // Create a foreach loop that evaluates each item in the list, 
            // and displays a message showing the string and whether or not it has already appeared in the list.
            //================================================================================================
            //================================================================================================

        }
    }
}
