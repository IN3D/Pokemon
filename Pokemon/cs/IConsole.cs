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
        #region colorMessages
        public static void WriteLnBlue(string s)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(s);
            Console.ResetColor();
        }


        public static void WriteLnGreen(string s)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(s);
            Console.ResetColor();
        }


        public static void WriteLnRed(string s)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(s);
            Console.ResetColor();
        }


        public static void WriteLnYellow(string s)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(s);
            Console.ResetColor();
        }
        #endregion


        #region loadMessages
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
        #endregion
    }
}
