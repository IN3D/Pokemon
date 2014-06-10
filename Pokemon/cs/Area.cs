using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public class Area
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int[] neighbors;
        public Person[] peopleInArea;
        public Building[] buildingsInArea;

        // default constructor
        public Area(string name, string description, int neighborCount, int people, int building)
        {
            this.Name = name;
            this.Description = description;
            neighbors = new int[neighborCount];
            peopleInArea = new Person[people];
            buildingsInArea = new Building[building];
        }
        
    }
}
