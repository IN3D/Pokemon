using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace Pokemon
{
    public class Type
    {
        private modifiers mods;

        public ObjectId _id { get; set; }
        public string name { get; set; }
        public int index { get; set; }

        public Type()
        {
            mods = new modifiers();
        }
    }
}
