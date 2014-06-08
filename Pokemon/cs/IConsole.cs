/* IConsole (ie. Improved Console)
 * 
 * Created
 * on: 5/31/2014
 * by: Eric Hopkins
 * for: Pokemon: Infinite
 * 
 * IConsole was created to help improve the appearance of the console through color and
 * formatting, as well as cut down on potential errors.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public static class IConsole
    {

        // use for successful loads
        public static void affirmitive(string filename)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\"" + filename + "\" successfully parsed");
            Console.ResetColor();
        }

        public static void negative(string filename)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Error in parsing \"" + filename + "\"");
            Console.ResetColor();
        }
    }
}
