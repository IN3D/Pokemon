/* Pokemon: Infinte: A recreation of classic Pokemon games in C#
 * 
 * 
 * == Created ==
 * on: -unknown-
 * by: Eric Hopkins
 *
 * == Modified ==
 * on: 8/10/2014
 * by: Eric Hopkins
 * 
 */

using System;
using System.Collections.Generic;

namespace Pokemon
{
	public class Region
	{
        public string Name { get; set; }

        public LinkedList<Area> areas = new LinkedList<Area>();


        #region constructors
        public Region (string name)
		{
            this.Name = name;
        }
        #endregion
    }
}

