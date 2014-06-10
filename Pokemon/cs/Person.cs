using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public class Person
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string[] conversation;
        public int[] items;
        public Pokemon[] pokemon;

        // default constructor
        public Person(string name, string description, params string[] convo)
        {
            this.Name = name;
            this.Description = description;

            conversation = new string[convo.Length];

            for (int i = 0; i < Description.Length; i++)
            {
                this.conversation[i] = convo[i];
            }
        }
    }
}
