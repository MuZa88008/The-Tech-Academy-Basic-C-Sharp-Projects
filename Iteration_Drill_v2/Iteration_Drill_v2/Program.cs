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

            string[] stringArray = new string[4];

            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine("Enter some text strings for our array.:");
                string textEntry = Console.ReadLine();
                stringArray[i] = textEntry;
            }

            for (int j = 0; j < stringArray.Length; j++)
            {
                Console.WriteLine(stringArray[j]);
            }

            Console.ReadLine();

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

            //List<string> names = new List<string>() { "create", "a", "list", "of", "strings", "where", "each", "item", "in", "the", "is", "unique",
            //    "ask", "user", "to", "select", "text", "search", "for", "index", "array", "that", "contains", "matching", "on", "screen", "loop",
            //    "iterates", "through", "and", "then", "displays" };

            //Console.WriteLine("Search list for (enter text)...: ");
            //string searchText = Console.ReadLine();

            //foreach (string name in names)
            //{
            //    if (name == searchText)
            //    {
            //        Console.WriteLine("The text you searched for is at index [" + names.IndexOf(searchText) + "] of the List.");
            //    }

            //}
            //Console.ReadLine();

            //================================================================================================
            //================================================================================================
            // 7.Add code to that above loop that tells a user if they put in text that isn’t in the List.
            //================================================================================================
            //================================================================================================




            //List<string> names = new List<string>() { "create", "a", "list", "of", "strings", "where", "each", "item", "in", "the", "is", "unique",
            //    "ask", "user", "to", "select", "text", "search", "for", "index", "array", "that", "contains", "matching", "on", "screen", "loop",
            //    "iterates", "through", "and", "then", "displays" };

            //Console.WriteLine("Enter text...: ");
            //string searchText = Console.ReadLine();

            //foreach (string name in names)
            //{
            //    if (name == searchText)
            //    {
            //        Console.WriteLine("The text you searched for is at index [" + names.IndexOf(searchText) + "] of the List.");
            //    }

            //}

            //if (!names.Contains(searchText))
            //{
            //    Console.WriteLine("The text you entered is not in the List");
            //}

            //Console.ReadLine();


            //================================================================================================
            //================================================================================================
            // 9.Create a List of strings that has at least two identical strings in the List. Ask the user to select text to search for in the List.
            // Create a loop that iterates through the list and then displays the indices of the array that contain matching text on the screen.
            //================================================================================================
            //================================================================================================

            //List<string> names = new List<string>() { "create","create", "a", "list", "of", "strings", "where", "each", "item", "in", "the", "is", "unique",
            //    "ask", "user", "to","create", "select", "text", "search", "for", "index", "array","create", "that", "contains", "matching", "on", "screen", "loop",
            //    "iterates", "through", "and", "then", "displays" };

            //Console.WriteLine("Enter text...: ");
            //string searchText = Console.ReadLine();

            //int z = 0;
            //do
            //{
            //    if (names[z] == searchText)
            //    {
            //        Console.WriteLine("Index [" + z + "]");
            //    }
            //    z++;


            //}
            //while (z < names.Count);

            //Console.ReadLine();






            //================================================================================================
            //================================================================================================
            // 10.Add code to that above loop that tells a user if they put in text that isn’t in the List.
            //================================================================================================
            //================================================================================================

            //List<string> names = new List<string>() { "create","create", "a", "list", "of", "strings", "where", "each", "item", "in", "the", "is", "unique",
            //    "ask", "user", "to","create", "select", "text", "search", "for", "index", "array","create", "that", "contains", "matching", "on", "screen", "loop",
            //    "iterates", "through", "and", "then", "displays" };

            //Console.WriteLine("Enter text...: ");
            //string searchText = Console.ReadLine();

            //int z = 0;
            //do
            //{
            //    if (names[z] == searchText)
            //    {
            //        Console.WriteLine("Index [" + z + "]");
            //    }
            //    z++;
            //}
            //while (z < names.Count);

            //if (!names.Contains(searchText))
            //{
            //    Console.WriteLine("The text you entered is not in the List");
            //}

            //Console.ReadLine();

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
