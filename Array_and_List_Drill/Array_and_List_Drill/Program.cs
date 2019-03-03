using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //// 1. Create an array of strings. Ask the user to select an index of the Array and then display the string at that index on the screen. 

        string[] stringArray = { "Wassup", "Hello", "Hi There", "Heya", "Hola", "Konnichiwa", "Hallo", "Aloha" };

        do
        {
            Console.WriteLine("What is your name?: ");
            string userName = Console.ReadLine();

            Console.WriteLine("Pick a number between 0-7");
            int arrayPosition = Convert.ToInt16(Console.ReadLine());

            if (arrayPosition < stringArray.Length)
            {
                Console.WriteLine(stringArray[arrayPosition] + ", " + userName);
                Console.WriteLine("Press q to go to the next drill or ENTER to try this drill again...  ");
            }
            else
            {
                Console.WriteLine("Whoops, index [" + arrayPosition + "] doesn't exist!");
                Console.WriteLine("Press ENTER to try again...");
            }

        }
        while (Console.ReadLine() != "q");

        Console.Clear();


        //// 2.Create an array of integers. Ask the user to select an index of the Array and then display the integer at that index on the screen.
        //// 3.Add in a message that displays when the user selects an index that doesn’t exist.
        //// ** A imperfect continue loop is also included...zm


        int[] intArray = { 22, 456, 85, 89, 3424, 80000, 79, 4567, 234, 65, 987654 };

        Console.WriteLine("An array has already been entered into memory...");
        do
        {
            Console.WriteLine("Select an index between 0 and 10 to see the value at that index.");
            int arrayPosition2 = Convert.ToInt32(Console.ReadLine());

            if (arrayPosition2 <= 10)
            {
                Console.WriteLine("The value at index [" + arrayPosition2 + "] is " + intArray[arrayPosition2] + ".");
                Console.WriteLine("Press q to go to the next drill or ENTER to try this drill again... ");
            }
            else
            {
                Console.WriteLine("Whoops, index [" + arrayPosition2 + "] doesn't exist!");
                Console.WriteLine("Press ENTER to try again...");
            }
        }
        while (Console.ReadLine() != "q");

        Console.Clear();

        // 4. Create a List of strings. Ask the user to select an index of the List and then display the content at that index on the screen.

        List<string> StringList = new List<string>();
        StringList.Add("How's it going, yo?");
        StringList.Add("Hello sir, how are you this fine day?");
        StringList.Add("What up, homie??");
        StringList.Add("G'Day!");
        StringList.Add("Oy!  Allo Mate!");
        StringList.Add("To whom it may concern...");
        StringList.Add("Mornin'...");


        Console.WriteLine("A list of common greetings is already in a list in memory...");

        do
        {
            Console.WriteLine("Enter a number (0-6) to see the greeting at that list index (position).");
            int arrayPosition3 = Convert.ToInt16(Console.ReadLine());

            if (arrayPosition3 <= StringList.Count - 1)
            {
                Console.WriteLine(StringList[arrayPosition3]);
                Console.WriteLine("Press q to quit the program or ENTER to try this drill again... ");
            }
            else
            {
                Console.WriteLine("Whoops, index [" + arrayPosition3 + "] doesn't exist!");
                Console.WriteLine("Press ENTER to try again...");
            }

        }
        while (Console.ReadLine() != "q");
        Console.Clear();
        Console.WriteLine("Goodbye!");
        Console.WriteLine("Press ENTER to close program.");
        Console.ReadLine();

    }
}
