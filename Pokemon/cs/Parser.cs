/* Pokemon: Infinte: A recreation of classic Pokemon games in C#
 * 
 * 
 * == Created ==
 * on: 6/9/2014
 * by: Eric Hopkins
 * 
 * Parser contains all the methods necessary to parse user input.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public static class Parser
    {
        public void read(string input)
        {
            int operand = 0;
            operand = input.IndexOf("-");

            switch (input)
            {
                case "help":
                    Console.WriteLine("buildings");
                    Console.WriteLine("Lists all the buildings in the area, can also be used to list rooms in a building");
                    Console.WriteLine();
                    Console.WriteLine("goin -#");
                    Console.WriteLine("goes into a building, requires an operand");
                    Console.WriteLine();
                    Console.WriteLine("goto -#");
                    Console.WriteLine("moves the player to a neighboring area, requires an operand");
                    Console.WriteLine();
                    Console.WriteLine("help");
                    Console.WriteLine("Brings up this menu, takes no operands.");
                    Console.WriteLine();
                    Console.WriteLine("inspect -#");
                    Console.WriteLine("Gives you a description of the selected person, requires an operand");
                    Console.WriteLine();
                    Console.WriteLine("inspectbld -#");
                    Console.WriteLine("Gives you a description of the selected building, requires an operand");
                    Console.WriteLine();
                    Console.WriteLine("leave");
                    Console.WriteLine("Leaves a building if the player is currently in one.");
                    Console.WriteLine();
                    Console.WriteLine("neighbors");
                    Console.WriteLine("Lists all the neighbors of your current area");
                    Console.WriteLine();
                    Console.WriteLine("people");
                    Console.WriteLine("Lists all the people in the current area");
                    Console.WriteLine();
                    Console.WriteLine("talkto -#");
                    Console.WriteLine("Starts a conversation with the selected person, requires an operand");
                    break;
                
                case "goto":

                    if (LocationGlobals.CurrentBuilding == -1)
                    {
                        // TODO: Write code for going to the next area
                    }
                    else
                    {
                        Console.WriteLine("You're in a building! Leave the building first");
                    }
                    break;
            }
        }
    }
}
