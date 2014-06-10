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
        public static void read(string input)
        {
            int seperator = 0;
            seperator = input.IndexOf("-");
            string operandStr = input.Substring(seperator + 1);


            int operand = convertOperand(operandStr);
            string switchStr = input.Substring(0, findSpace(input)).Trim();

            switch (switchStr)
            {
                case "help":
                    Console.WriteLine();
                    Console.WriteLine("####### Printing Help #######\n");
                    Console.WriteLine("buildings");
                    Console.WriteLine("Lists all the buildings in the area, can also be used to list rooms in a building");
                    Console.WriteLine();
                    Console.WriteLine("clear");
                    Console.WriteLine("clears out the terminal");
                    Console.WriteLine();
                    Console.WriteLine("goin -#");
                    Console.WriteLine("goes into a building, requires an operand");
                    Console.WriteLine();
                    Console.WriteLine("goto -#"); // SORTA IMPLEMENTED
                    Console.WriteLine("moves the player to a neighboring area, requires an operand");
                    Console.WriteLine();
                    Console.WriteLine("help");
                    Console.WriteLine("Brings up this menu, takes no operands.");
                    Console.WriteLine();
                    Console.WriteLine("inspect -#"); // NOT IMPLEMENTED
                    Console.WriteLine("Gives you a description of the selected person, requires an operand");
                    Console.WriteLine();
                    Console.WriteLine("inspectbld -#"); // NOT IMPLEMETNED
                    Console.WriteLine("Gives you a description of the selected building, requires an operand");
                    Console.WriteLine();
                    Console.WriteLine("leave");
                    Console.WriteLine("Leaves a building if the player is currently in one.");
                    Console.WriteLine();
                    Console.WriteLine("neighbors"); // NOT IMPLEMENTED
                    Console.WriteLine("Lists all the neighbors of your current area");
                    Console.WriteLine();
                    Console.WriteLine("people"); // NOT IMPLEMENTED
                    Console.WriteLine("Lists all the people in the current area");
                    Console.WriteLine();
                    Console.WriteLine("quit");
                    Console.WriteLine("Quits the game");
                    Console.WriteLine();
                    Console.WriteLine("talkto -#"); // NOT IMPLEMENTED
                    Console.WriteLine("Starts a conversation with the selected person, requires an operand");
                    Console.WriteLine();
                    Console.WriteLine("whereami");
                    Console.WriteLine("Tells the player where they are.");
                    break;

                case "building":

                    if (Location.Building == -1)
                    {
                        if (Model.gameWorld.ElementAt(Location.Region).areas.ElementAt(Location.Area)
                            .buildingsInArea.Length != 0)
                        {
                            for (int i = 0; i < Model.gameWorld.ElementAt(Location.Region).areas.ElementAt(Location.Area)
                                .buildingsInArea.Length; i++)
                            {
                                Console.WriteLine(i.ToString() + ": " + Model.gameWorld.ElementAt(Location.Region).areas.ElementAt(Location.Area)
                                    .buildingsInArea[i].Name);
                            }
                        }
                        else
                        {
                            Console.WriteLine("There are no buildings in this area");
                        }
                    }
                    else
                    {
                        Console.WriteLine("You're already in a building, leave it first (rooms not yet implemented)");
                    }

                    break;

                case "clear":

                    Console.Clear();
                    break;

                case "goin":

                    if (Location.Building == -1)
                    {
                        if (operand != -1 && operand <= (Model.gameWorld.ElementAt(Location.Region).areas.ElementAt(Location.Area).buildingsInArea.Length - 1))
                        {
                            // set global data
                            Location.Building = operand;

                            // display some data to let player know where they are.
                            Console.WriteLine(Model.gameWorld.ElementAt(Location.Region).areas.ElementAt(Location.Area).buildingsInArea[Location.Building].Name + ":");
                            Console.WriteLine(Model.gameWorld.ElementAt(Location.Region).areas.ElementAt(Location.Area).buildingsInArea[Location.Building].Description + "\n");
                        }
                        else
                        {
                            if (operand == -1)
                            {
                                Console.WriteLine("You entered an invalid number! (index invalid)");
                            }
                            else
                            {
                                Console.WriteLine("There is no such building in the area! (index out of bounds)");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("You're already in a building!");
                    }
                    break;
                
                case "goto":

                    // TODO: put a lot more bug checking into this!!
                    if (operand != -1 && operand <= (Model.gameWorld.ElementAt(Location.Region).areas.ElementAt(Location.Area).neighbors.Length - 1))
                    {
                        if (Location.Building == -1 && Location.Room == -1)
                        {
                            Console.WriteLine("You leave " + Model.gameWorld.ElementAt(Location.Region).areas.ElementAt(Location.Area).Name +
                                " and walk into " + Model.gameWorld.ElementAt(Location.Region).areas.ElementAt(Model.gameWorld.ElementAt(Location.Region).areas.ElementAt(Location.Area).neighbors[operand]).Name);

                            Location.Area = Model.gameWorld.ElementAt(Location.Region).areas.ElementAt(Location.Area).neighbors[operand];
                        }
                        else
                        {
                            Console.WriteLine("You're in a building! Leave the building first");
                        }
                    }
                    else
                    {
                        if (operand == -1)
                        {
                            Console.WriteLine("You entered an invalid number! (index invalid)");
                        }
                        else
                        {
                            Console.WriteLine("There is no such area neighboring the current area! (index out of bounds)");
                        }
                    }
                    break;

                case "leave":

                    // ensure that the player is in a building
                    if (Location.Building != -1)
                    {
                        // leave the current building
                        Console.WriteLine("Now leaving " + Model.gameWorld.ElementAt(Location.Region).areas.ElementAt(Location.Area).buildingsInArea[Location.Building].Name);
                        Location.Building = -1;

                        // inform the player where they are
                        Console.WriteLine("You walk out the door into " + Model.gameWorld.ElementAt(Location.Region).areas.ElementAt(Location.Area).Name);
                    }
                    else
                    {
                        Console.WriteLine("You're not in a building!");
                    }

                    break;

                case "neighbors":

                    if (Location.Building == -1 && Location.Room == -1)
                    {
                        if (Model.gameWorld.ElementAt(Location.Region).areas.ElementAt(Location.Area).neighbors.Length != 0)
                        {
                            for (int i = 0; i < Model.gameWorld.ElementAt(Location.Region).areas.ElementAt(Location.Area).neighbors.Length; i++)
                            {
                                Console.WriteLine(i + ": " + Model.gameWorld.ElementAt(Location.Region).areas.ElementAt(Model.gameWorld.ElementAt(Location.Region).areas.ElementAt(Location.Area).neighbors[i]).Name);
                            }
                        }
                        else
                        {
                            Console.WriteLine("What have you done!? The area you are in has no neighbors!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("You're in a building, you need to leave first!");
                    }
                    break;

                case "quit":

                    Environment.Exit(0);
                    break;

                case "whereami":

                    // ensure that the player isn't in a room or buidling
                    if (Location.Room != -1)
                    {
                        Console.WriteLine("You are currently in the room " + Model.gameWorld.ElementAt(Location.Region).areas.ElementAt(Location.Area)
                            .buildingsInArea[Location.Building].rooms[Location.Room].Name + " of the building " + Model.gameWorld.ElementAt(Location.Region)
                            .areas.ElementAt(Location.Area).buildingsInArea[Location.Building].Name);
                    }
                    else if (Location.Building != -1)
                    {
                        Console.WriteLine("You are currently in the building " + Model.gameWorld.ElementAt(Location.Region).areas.ElementAt(Location.Area)
                            .buildingsInArea[Location.Building].Name);
                    }
                    // if it's not a building
                    else
                    {
                        Console.WriteLine("You are currently in " + Model.gameWorld.ElementAt(Location.Region).areas.ElementAt(Location.Area).Name +
                            " of the " + Model.gameWorld.ElementAt(Location.Region).Name + " region.");
                    }

                    break;

                default:

                    Console.WriteLine("Could not understand input");
                    break;
            }
        }


        // Private helper Methods
        private static int findSpace(string s)
        {
            int loc = 0;

            char space = s[loc];

            while (space != 32 && loc < s.Length)
            {
                space = s[loc];
                loc++;
            }

            return loc;
        }

        private static int convertOperand(string s)
        {
            int operand;
            Int32.TryParse(s, out operand);

            // this ensures that bad input isn't converted to
            // 0 like it would be by default. And that nulls aren't passed.
            if ((operand == 0 && s != "0") || operand == null)
            {
                operand = -1;
            }

            return operand;
        }
    }
}
