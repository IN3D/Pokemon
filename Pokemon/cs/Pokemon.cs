/* Pokemon: Infinte: A recreation of classic Pokemon games in C#
 * 
 * 
 * == Created ==
 * on: 5/23/2014
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
    public class Pokemon
    {
		protected bool isGenderless { get; set; }
		protected int CatchRate { get; set; }
		protected int DexNumber { get; set; }
		protected int Gender { get; set; }
		protected int Level { get; set; }
		protected int XP { get; set; }
		protected int[] baseStats = new int[6];
		protected int[] EVs = new int[6];
		protected int[] IVs = new int[6];
		protected int[] stats = new int[6];
		protected string Name { get; set; }
		protected string[] types = new string[2]; // NOTE: This is temporary
        // TODO: create Abilities class
        // TODO: create Attacks class
        // TODO: create LevelGroup class
        // TODO: create Type class

        // Constructor: Base Data
		public Pokemon(string name, int catchRate, int dexNum, bool genderless, int[] baseStats, string[] types)
        {
            this.Name = name;
			this.CatchRate = catchRate;
            this.DexNumber = dexNum;
            this.isGenderless = genderless;

            for(int i = 0; i < 6; i++)
            {
                this.baseStats[i] = baseStats[i];
            }

            for(int i = 0; i < types.Length; i++)
            {
                this.types[i] = types[i];
            }
        }

        // Constructor: Wild Pokemon
        public Pokemon(Pokemon basePkm, int areaLow, int areaHigh)
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


        public void debugBaseInfo()
        {
            Console.WriteLine("Name: " + this.Name);
            string idFormat = this.DexNumber.ToString("D3");
            Console.WriteLine("\tDexNumber: " + idFormat);
            Console.WriteLine("\tCatch Rate: " + this.CatchRate);
            string noGender = this.isGenderless.ToString();
            Console.WriteLine("\tGenderless: " + noGender);

            Console.WriteLine("\tTypes: ");
            for (int i = 0; i < this.types.Length; i++)
            {
                if(this.types[i] != null)
                {
                    Console.WriteLine("\t\tType " + (i + 1) + ": " + this.types[i]);
                }
            }

            // ====
            Console.WriteLine("\tBase Stats: ");
            Console.WriteLine("\t\tHP: " + this.baseStats[0]);
            Console.WriteLine("\t\tAttack: " + this.baseStats[1]);
            Console.WriteLine("\t\tDefense: " + this.baseStats[2]);
            Console.WriteLine("\t\tSp.Attack: " + this.baseStats[3]);
            Console.WriteLine("\t\tSp.Defense: " + this.baseStats[4]);
            Console.WriteLine("\t\tSpeed: " + this.baseStats[5]);
            // ====

            Console.WriteLine();
        }
    }
}
