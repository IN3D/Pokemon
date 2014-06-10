using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public class Grass
    {
        protected int[] wildPokemon;


        // Default Constructor
        public Grass(int count, params int[] pokeIndex)
        {
            wildPokemon = new int[count];

            for (int i = 0; i <= pokeIndex.Length; i++)
            {
                wildPokemon[i] = pokeIndex[i];
            }
        }


        public int getEncounter()
        {
            Random random = new Random();

            return random.Next((this.wildPokemon.Length + 1));
        }
    }
}
