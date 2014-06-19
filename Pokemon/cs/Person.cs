using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public class Person
    {
        public string Description { get; set; }        
        public string Name { get; set; }

        public int[] items;
        public string[] conversation;
        public Pokemon[] pokemon;


        #region constructors
        // default constructor
        public Person(string name, string description, params string[] convo)
        {
            this.Description = description;
            this.Name = name;

            conversation = new string[convo.Length];

            for (int i = 0; i < conversation.Length; i++)
            {
                this.conversation[i] = convo[i];
            }
        }
        #endregion
    }
}
