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
        public Grass(params int[] pokeIndex)
        {
            wildPokemon = new int[pokeIndex.Length];

            for (int i = 0; i <= pokeIndex.Length; i++)
            {
                wildPokemon[i] = pokeIndex[i];
            }
        }


	    public int getPokemon()
        {   
            Random random = new Random();

            int rnd = random.Next((this.wildPokemon.Length));

            return this.wildPokemon[rnd];
        }
}
