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

namespace Pokemon
{
     public class Types
    {
        protected string Name { get; set;}
        public double[] modifiers = new double[18];


        public Types(string name, double[] mods)
        {
            this.Name = name;
            for (int i = 0; i < this.modifiers.Length; i++)
            {
                this.modifiers[i] = mods[i];
            }
        }

        // copy constructor
        public Types(Types copy)
        {
            this.Name = copy.Name;
            for (int i = 0; i < this.modifiers.Length; i++)
            {
                this.modifiers[i] = copy.modifiers[i];
            }
        }

        // toString Ovrride
        public override string ToString()
        {
            return this.Name;
        }
    }
}
