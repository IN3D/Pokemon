/* Pokemon: Infinte: A recreation of classic Pokemon games in C#
 * 
 * 
 * == Created ==
 * on: 5/27/2014
 * by: Eric Hopkins
 *
 * == Modified ==
 * on: 8/10/2014
 * by: Eric Hopkins
 * 
 * This file contains all of the games core data. this includes the lists of
 * pokemon, items, types, moves, etc. Model is public static and accessable from
 * everywhere in the program.
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace Pokemon
{
	public static class Model
	{
        public static Types[] Types = new Types[18];

        public static LinkedList<Pokemon> pokemonMasterList = new LinkedList<Pokemon>();
        public static LinkedList<ItemBase> objects = new LinkedList<ItemBase>();
		public static LinkedList<Region> gameWorld = new LinkedList<Region>();
        

		#region ExperienceGroups
		public static int[] Erratic = new int[100];
		public static int[] Fast = new int[100];
		public static int[] MediumFast = new int[100];
		public static int[] MediumSlow = new int[100];
		public static int[] Slow = new int[100];
		public static int[] Fluctuating = new int[100];
		#endregion

	}
}

