using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            // Concatenate three strings
            string str_1 = "This is the first string. ";
            string str_2 = "This is the second string. ";
            string str_3 = "This is the third string.";
            string str_joined = str_1 + str_2 + str_3;
            Console.WriteLine(str_joined);
            // Convert string to upper case
            Console.WriteLine(str_joined.ToUpper());
            // Create a Stringbuilder and build a paragraph of text, one sentence at a time.
            string[] str = new String[3];
            str[0] = "This is the first string. ";
            str[1] = "This is the second string. ";
            str[2] = "This is the third string.";
            int counter = 0;
            StringBuilder paragraph = new StringBuilder();
            while (counter < str.Length)
            {
                paragraph.Append( str[ counter ] );
                counter++;
            }
            Console.WriteLine(paragraph);
        }
    }
}
