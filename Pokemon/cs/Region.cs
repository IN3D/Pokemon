using System;
using System.Collections.Generic;

namespace Pokemon
{
	public class Region
	{
        public string Name { get; set; }
        public LinkedList<Area> areas = new LinkedList<Area>();

		public Region (string name)
		{
            this.Name = name;
		}
	}
}

