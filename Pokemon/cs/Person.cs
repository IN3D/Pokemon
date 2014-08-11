/* Pokemon: Infinte: A recreation of classic Pokemon games in C#
 * 
 * 
 * == Created ==
 * on: - unknown -
 * by: Eric Hopkins
 * 
 * == Modified ==
 * on: 8/10/2014
 * by: Eric Hopkins
 */
using System;
using System.Text;

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
