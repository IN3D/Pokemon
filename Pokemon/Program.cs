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
			Engine.ReadXML("..//..//xml//pokemon.xml", ref Model.pokemonMasterList);

			Program prog = new Program ();

            Console.WriteLine("pokemon.xml file read in successfully\n=====================================");

			prog.DEBUG_ShowPokemonBaseInfo ();

            // to keep the terminal open
            Console.Write(">: ");
            Console.ReadLine();
        }

		public void DEBUG_ShowPokemonBaseInfo()
		{
			foreach (Pokemon pkm in Model.pokemonMasterList)
			{
				pkm.debugBaseInfo ();
			}
		}
    }
}
