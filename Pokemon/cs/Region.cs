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

