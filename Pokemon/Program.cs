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
            // !Core game data
            LinkedList<Pokemon> pokemonMasterList = new LinkedList<Pokemon>();


            Program main = new Program();
            Engine.ReadXML("..//..//xml//pokemon.xml", ref pokemonMasterList);

            Console.WriteLine("pokemon.xml file read in successfully\n=====================================");

            main.DEBUG_CheckPokemonList(ref pokemonMasterList);

            // to keep the terminal open
            Console.Write(">: ");
            Console.ReadLine();
        }

        public void DEBUG_CheckPokemonList(ref LinkedList<Pokemon> list)
        {
            foreach (Pokemon pkm in list)
            {
                pkm.debugBaseInfo();
            }
        }
    }
}
