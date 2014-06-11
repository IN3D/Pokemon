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
		public bool IsGenderless { get; set; }
		public int CatchRate { get; set; }
		public int DexNumber { get; set; }
		public int Gender { get; set; }
		public int Level { get; set; }
        public int TempType { get; set; }
		public int XP { get; set; }
		public int[] baseStats = new int[6];
		public int[] EVs = new int[6];
		public int[] IVs = new int[6];
		public int[] stats = new int[6];
		public string Name { get; set; }
		public int[] types = new int[2];
        // TODO: create Abilities class
        // TODO: create Attacks class
        // TODO: create LevelGroup class
        // TODO: create Type class

        // Constructor: Base Data
		public Pokemon(string name, int catchRate, int dexNum, bool genderless, int[] baseStats, int[] types)
        {
            this.Name = name;
			this.CatchRate = catchRate;
            this.DexNumber = dexNum;
            this.IsGenderless = genderless;
            this.TempType = -1;

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
            
            this.IsGenderless = basePkm.IsGenderless;
            this.CatchRate = basePkm.CatchRate;
            this.DexNumber = basePkm.DexNumber;
            this.Name = basePkm.Name;
            this.TempType = basePkm.TempType;

            for (int i = 0; i < basePkm.types.Length; i++)
            {
                this.types[i] = basePkm.types[i];

            }

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
            this.Level = rnd.Next(areaLow, areaHigh) + 1;

            this.Gender = rnd.Next(1, 2);
        }


        public void debugBaseInfo()
        {
            Console.WriteLine("Name: " + this.Name);
            string idFormat = this.DexNumber.ToString("D3");
            Console.WriteLine("\tDexNumber: " + idFormat);
            Console.WriteLine("\tCatch Rate: " + this.CatchRate);
            string noGender = this.IsGenderless.ToString();
            Console.WriteLine("\tGenderless: " + noGender);

            Console.WriteLine("\tTypes: ");
            for (int i = 0; i < this.types.Length; i++)
            {
                if(this.types[i] != -1)
                {
                    Console.WriteLine("\t\tType " + (i + 1) + ": " + Model.Types[this.types[i]].ToString());
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

        // toString Ovrride
        public override string ToString()
        {
            return this.Name + " lvl. " + this.Level;
        }
    }
}
