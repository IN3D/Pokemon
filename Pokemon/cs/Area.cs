using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public class Area
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int[] neighbors;
        public Person[] peopleInArea;
        public Building[] buildingsInArea;

        // default constructor
        public Area(string name, string description, int neighborCount, int people, int building)
        {
            this.Name = name;
            this.Description = description;
            neighbors = new int[neighborCount];
            peopleInArea = new Person[people];
            buildingsInArea = new Building[building];
        }

        // Methods
        public void getEncounter()
        {
            // a "just in case" error check, to ensure that this isn't called on area with no grass
            if (HasGrass == true)
            {
                int index = this.grass.getPokemon();
                Pokemon tempPoke = new Pokemon(Model.pokemonMasterList.ElementAt(index), this.AreaLow, this.AreaHigh);
                string gender = "";

                // TODO: Eventually replace this, it's not optimal
                if (tempPoke.Gender == 1)
                {
                    gender = "♂";
                }
                else
                {
                    gender = "♀";
                }

                Console.WriteLine("A Wild " + tempPoke.Name + " appeared!");
                System.Threading.Thread.Sleep(750);
                Console.Clear();
                Console.WriteLine(tempPoke.Name + " " + gender + "   lvl." + tempPoke.Level.ToString());
                Console.WriteLine("Here's some debug info about it's IVs: ");
                for (int i = 0; i < tempPoke.IVs.Length; i++)
                {
                    Console.Write(tempPoke.IVs[i].ToString() + "\t");
                }

                System.Threading.Thread.Sleep(1500);
                Console.WriteLine("\nSince you can't catch, and you don't have a Pokemon, you run away...");
                Console.Write("[Press Enter]");
                Console.ReadLine();
                Console.Clear();

            }
            else
            {
                Console.WriteLine("There is no grass in this area");
            }
        
    }
}
