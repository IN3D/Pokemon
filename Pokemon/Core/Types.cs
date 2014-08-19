/* Pokemon: Infinte: A recreation of classic Pokemon games in C#
 * 
 * 
 * == Created ==
 * on: 5/28/2014
 * by: Bradley Mackey
 *
 * == Modified ==
 * on: 8/10/2014
 * by: Eric Hopkins
 * 
 * This is the multipliers for damage output based on type versus type.
 * 
 */
using System;
using System.Text;

namespace Pokemon.Core
{
     public class Types
    {
        public string Name { get; set;}
        public int Index { get; set; }
        protected double[] modifiers = new double[18];


        public Types(string name, int index, double[] mods)
        {
            this.Name = name;
            this.Index = index;

            for (int i = 0; i < this.modifiers.Length; i++)
            {
                this.modifiers[i] = mods[i];
            }
        }

        // copy constructor
        public Types(Types copy)
        {
            this.Name = copy.Name;
            this.Index = copy.Index;

            for (int i = 0; i < this.modifiers.Length; i++)
            {
                this.modifiers[i] = copy.modifiers[i];
            }
        }

        // get a particular index of the modifiers array
         public double getModifier(int index)
         {
             if (!(index > modifiers.Length))
                 return this.modifiers[index];
             else
                 // this should never happen...
                 return 0.0;
         }

        // toString Ovrride
        public override string ToString()
        {
            return this.Name;
        }
    }
}
