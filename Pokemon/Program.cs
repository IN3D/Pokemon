using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool types;
            bool pokemon;


			try
            {
                Engine.ReadTypeXML("..//..//xml//Types.xml");
                IConsole.affirmitive("Types.xml");
                types = true;
            }
            catch
            {
                IConsole.negative("Types.xml");
                types = false;
            }
            try
            {
                Engine.ReadPokemonXML("..//..//xml//pokemon.xml", ref Model.pokemonMasterList);
                IConsole.affirmitive("pokemon.xml");
                pokemon = true;
            }
            catch
            {
                IConsole.negative("pokemon.xml");
                pokemon = false;
            }





            /* this if statement is where the game actually occurs, to cut down on the compiler
             * blowing up, I've wrapped a lot of code in try catches and ensure that the game has
             * what it needs to start.
             */
            if (types && pokemon)
            {
                GameMath.gameLoadPopulate();
                Program prog = new Program();



                // to keep the terminal open
                //Console.Write(">: ");
                //Console.ReadLine();

                Console.WriteLine("Welcome to Pokemon: Infinite!");
                PopulateGameData.load();
                Console.WriteLine("Please wait...");
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("Ready to go!");
                string input = "default";

                while (input != "quit" || input != "exit")
                {
                    Console.Write(">: ");
                    input = Console.ReadLine();

                    Parser.read(input);
                }
                
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: a core file could not be loaded! \nThe game will now hault.");
                Console.ResetColor();

                Console.Write(">: ");
                string input = Console.ReadLine();

                Environment.Exit(0);
            }
        }





        // Program.cs Methods
		public void DEBUG_ShowPokemonBaseInfo()
		{
			foreach (Pokemon pkm in Model.pokemonMasterList)
			{
				pkm.debugBaseInfo ();
			}
		}
    }
}
