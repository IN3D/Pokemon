using System;
using System.Text;

namespace Pokemon.World
{
    public class Grass
    {
        protected int[] wildPokemon;


        #region constructors
        // Default Constructor
        public Grass(params int[] pokeIndex)
        {
            wildPokemon = new int[pokeIndex.Length];

            for (int i = 0; i < pokeIndex.Length; i++)
            {
                wildPokemon[i] = pokeIndex[i];
            }
        }
        #endregion


        #region methods
        public int getPokemon()
        {
            Random random = new Random();

            int rnd = random.Next((this.wildPokemon.Length));

            return this.wildPokemon[rnd];
        }
        #endregion
    }
}
