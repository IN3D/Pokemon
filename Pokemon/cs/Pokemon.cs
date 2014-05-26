/* Pokemon: Infinte: A recreation of classic Pokemon games in C#
 * 
 * 
 * == Created ==
 * on: 5/23/2014
 * by: Eric Hopkins
 * 
 * == Last Modified ==
 * on: 25/23/2014
 * by: Eric Hopkins
 * 
 * This is the class file that is used in all instances of a pokemon.
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    class Pokemon
    {
        protected
        bool isGenderless { get; set; }
        int CatchRate { get; set; }
        int DexNumber { get; set; }
        int Gender { get; set; }
        int Level { get; set; }
        int XP { get; set; }
        int[] baseStats = new int[6];
        int[] EVs = new int[6];
        int[] IVs = new int[6];
        int[] stats = new int[6];
        string Name { get; set; }
        // TODO: create Abilities class
        // TODO: create Attacks class
        // TODO: create LevelGroup class
        // TODO: create Type class

        // Constructor: Wild Pokemon
        Pokemon(Pokemon basePkm, int areaLow, int areaHigh)
        {
            Random rnd = new Random();
            
            this.isGenderless = basePkm.isGenderless;
            this.CatchRate = basePkm.CatchRate;
            this.DexNumber = basePkm.DexNumber;
            this.Name = basePkm.Name;
            for(int i = 0; i < 6; i++)
            {
                this.baseStats[i] = basePkm.baseStats[i];
            }

            // Create generated data
            for (int i = 0; i < 6; i++)
            {
                // NOTE: I don't consider this a final product, I think the
                // IV's should have more to them than just pure random numbers

                this.IVs[i] = rnd.Next(31);
            }

            // TODO: When XP is properly implemented, this should be changed.
            this.Level = rnd.Next(areaLow, areaHigh);

            this.Gender = rnd.Next(1, 2);
        }
    }
}
