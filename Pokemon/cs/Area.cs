using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public class Area
    {
		public bool HasGrass { get; set; }
		public int AreaLow { get; set; }
        public int AreaHigh { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }

		public int[] neighbors;
        public Building[] buildingsInArea;
        public Person[] peopleInArea;

        public Grass grass;


		#region constructors
        // default constructor
        public Area(string name, string description, int neighborCount, int people, int building)
        {
            this.Description = description;            
			this.Name = name;
			
            buildingsInArea = new Building[building];
            peopleInArea = new Person[people];			
            neighbors = new int[neighborCount];

            // because this is for a standard area...
            HasGrass = false;
        }


        // route constructor
        public Area(string name, string description, int neighborCount, int people, int building, int low, int high, params int[] wildPokes)
        {
            this.AreaHigh = high;
            this.AreaLow = low;
			this.Description = description;
			this.Name = name;
			
            buildingsInArea = new Building[building];
            neighbors = new int[neighborCount];
            peopleInArea = new Person[people];

            HasGrass = true;
			
            grass = new Grass(wildPokes);
        }
		#endregion


		#region methods
        // Methods
        public void getEncounter()
        {
            if (HasGrass == true)
            {
                int index = this.grass.getPokemon();
                Pokemon tempPoke = new Pokemon(Model.pokemonMasterList.ElementAt(index), this.AreaLow, this.AreaHigh);
                string gender = "";

                // TODO: Eventually replace this, it's not optimal
				// eventually a pokemon should contain this in int's own constructor
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
                // NOTE: This is temporary replace once battles are implemented
                Console.WriteLine("\nSince you can't catch, and you don't have a Pokemon, you run away...");
                Console.Write("[Press Enter]");
                Console.ReadLine();
                Console.Clear();
                // END NOTE

            }
            else
            {
                Console.WriteLine("There is no grass in this area");
            }
        }
		#endregion
    }
}
