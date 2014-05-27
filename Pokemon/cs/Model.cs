/* Pokemon: Infinte: A recreation of classic Pokemon games in C#
 * 
 * 
 * == Created ==
 * on: 5/27/2014
 * by: Eric Hopkins
 * 
 * This file contains all fo the games core data. this includes the lists of
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
		public static LinkedList<Pokemon> pokemonMasterList = new LinkedList<Pokemon>();
	}
}

