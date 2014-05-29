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
            LinkedList<ItemBase> objects = new LinkedList<ItemBase>();

            potion potion01 = new potion("Potion", 20);
            potion potion02 = new potion("Super Potion", 50);
            potion potion03 = new potion("Hyper Potion", 100);

            ppItem ppItem01 = new ppItem("Ether", "Flamethrower", 10); // flamethrower is a substitute for a selection in game

            

            battleItem battleItem01 = new battleItem("xAttack", "attack", 1);
            battleItem battleItem02 = new battleItem("xDefense", "defense", 1);
            battleItem battleItem03 = new battleItem("xSp. Attack", "sp. attack", 1);
            battleItem battleItem04 = new battleItem("xSp. Defense", "sp. defense", 1);
            battleItem battleItem05 = new battleItem("xSpeed", "speed", 1);
            battleItem battleItem06 = new battleItem("xAccuracy", "accuracy", 1);
            battleItem battleItem07 = new battleItem("Dire Hit", "critical hit ratio", 1);
            

            evItem evItem01 = new evItem("Protein", "attack", 10);
            evItem evItem02 = new evItem("HP Up", "HP", 10);
            evItem evItem03 = new evItem("Iron", "defense", 10);
            evItem evItem04 = new evItem("Zinc", "special defense", 10);
            evItem evItem05 = new evItem("Carbos", "speed", 10);
            

            objects.AddLast(potion01);
            objects.AddLast(potion02);
            objects.AddLast(potion03);
            objects.AddLast(ppItem01);
            objects.AddLast(battleItem01);
            objects.AddLast(battleItem02);
            objects.AddLast(battleItem03);
            objects.AddLast(battleItem04);
            objects.AddLast(battleItem05);
            objects.AddLast(battleItem06);
            objects.AddLast(battleItem07);
            objects.AddLast(evItem01);
            objects.AddLast(evItem02);
            objects.AddLast(evItem03);
            objects.AddLast(evItem04);
            objects.AddLast(evItem05);

            foreach (var item in objects)
            {
                Console.WriteLine(item.use());
            }

            // the ReadLine should be outside of your for loop,
            // otherwise the terminal will request input after every
            // time it prints an item.
			Engine.ReadXML("..//..//xml//pokemon.xml", ref Model.pokemonMasterList);
			GameMath.popErratic ();
			GameMath.popFast ();
			GameMath.popMediumFast ();
			GameMath.popMediumSlow ();
			GameMath.popSlow ();
			GameMath.popFluctuating ();

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
