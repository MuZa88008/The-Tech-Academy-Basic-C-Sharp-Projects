using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Functions_Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            //Concatenate three strings.

            string string1 = "Hello, ";
            string string2 = "my name is ";
            string string3 = "Zach!";
            string phrase = string1 + string2 + string3;

            Console.WriteLine("String 1 = " + string1);
            Console.WriteLine("String 2 = " + string2);
            Console.WriteLine("String 3 = " + string3);
            Console.WriteLine("\nAfter concatenation...:  " + phrase);
            Console.WriteLine("Press ENTER to continue...");
            Console.ReadLine();


            //Convert a string to uppercase.

            Console.WriteLine("\n\nConverts above concatenated phrase to UPPER...:");
            //string1 = string1.ToUpper();
            //string2 = string2.ToUpper();
            //string3 = string3.ToUpper();
            //Console.WriteLine("String 1 = " + string1);
            //Console.WriteLine("String 2 = " + string2);
            //Console.WriteLine("String 3 = " + string3);
            //phrase = string1 + string2 + string3;
            phrase = phrase.ToUpper();
            Console.WriteLine(phrase);
            Console.WriteLine("Press ENTER to continue...");
            Console.ReadLine();


            //Create a Stringbuilder and build a paragraph of text, one sentence at a time.

            Console.WriteLine("Using stringbuilder, this block creates a paragraph from several user inputs and writes to console \nLoop count currently set to 5");
            Console.WriteLine("\nEnter your first sentence...");
            string input_1 = Console.ReadLine();
            StringBuilder zachsb = new StringBuilder();
            zachsb.Append(input_1);
            int count = 1;

            while (count < 5)
            {

                Console.WriteLine("Type another sentence...");
                zachsb.Append("\n" + Console.ReadLine());
                count++;
            }

            Console.WriteLine("\n\n\nHere's your paragraph...\n\n"+zachsb);
            Console.WriteLine("\n\nEND");
            Console.ReadLine();

        }
    }
}
