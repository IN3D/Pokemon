using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace MongoConnectionTest
{
    class AltType
    {
        public ObjectId id { get; set; }
        public string name { get; set; }
        public int index { get; set; }
        public Modifiers modifiers {get; set;}

        public AltType()
        {
            modifiers = new Modifiers();
        }
    }

    class Modifiers
    {
        public double Normal { get; set; }
        public double Fighting { get; set; }
        public double Flying { get; set; }
        public double Poison { get; set; }
        public double Ground { get; set; }
        public double Rock { get; set; }
        public double Bug { get; set; }
        public double Ghost { get; set; }
        public double Steel { get; set; }
        public double Fire { get; set; }
        public double Water { get; set; }
        public double Grass { get; set; }
        public double Electric { get; set; }
        public double Psychic { get; set; }
        public double Ice { get; set; }
        public double Dragon { get; set; }
        public double Dark { get; set; }
        public double Fairy { get; set; }
    }
}
