using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public class Building
    {
        public string Description { get; set; }
		public string Name { get; set; }

        public Building[] rooms;
        public Person[] peopleInBuilding;


		#region constructors
        // default (assumes there are people in the building)
        public Building(string name, string description, params Person[] people)
        {
            this.Name = name;
            this.Description = description;

            peopleInBuilding = new Person[people.Length];

            for (int i = 0; i < this.peopleInBuilding.Length; i++)
            {
                this.peopleInBuilding[i] = people[i];
            }
        }

        // empty building constructor
        public Building(string name, string description)
        {
            this.Name = name;
            this.Description = description;
        }
		#endregion
    }
}
