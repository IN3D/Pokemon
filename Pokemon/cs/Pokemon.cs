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
        int[] stats = new int[6];
        string Name { get; set; }
        // TODO: create Attacks class
        // TODO: create LevelGroup class
        // TODO: create Type class
    }
}
