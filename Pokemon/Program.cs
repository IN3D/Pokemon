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
            LinkedList<Pokemon> pokemonMasterList = new LinkedList<Pokemon>();

            // Test case: Eric 5/23/2014
            Engine.ReadXML("..//..//xml//pokemon.xml", ref pokemonMasterList);

            Console.WriteLine("pokemon.xml file read in successfully\n=====================================");

            foreach (Pokemon pkm in pokemonMasterList)
            {
                Console.WriteLine(pkm.Name);
            }

            Console.Write(">: ");
            Console.ReadLine();
        }
    }
}
