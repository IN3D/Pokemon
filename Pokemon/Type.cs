using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace Pokemon
{
    public class Type
    {
        
        
        private modifiers mods;

        public ObjectId _id { get; set; }
        public string name { get; set; }
        public int index { get; set; }
        //public double Normal { get; set; }
        //public double Fighting { get; set; }
        //public double Flying { get; set; }
        //public double Poison { get; set; }
        //public double Ground { get; set; }
        //public double Rock { get; set; }
        //public double Bug { get; set; }
        //public double Ghost { get; set; }
        //public double Steel { get; set; }
        //public double Fire { get; set; }
        //public double Water { get; set; }
        //public double Grass { get; set; }
        //public double Electric { get; set; }
        //public double Psychic { get; set; }
        //public double Ice { get; set; }
        //public double Dragon { get; set; }
        //public double Dark { get; set; }
        //public double Fairy { get; set; }

        public Type()
        {
            mods = new modifiers();

            BsonClassMap.RegisterClassMap<Type>(cm =>
            {
                cm.MapProperty(c => c.name);
                cm.MapProperty(c => c.index);
                cm.MapProperty(c => c.mods.Normal);
                cm.MapProperty(c => c.mods.Fighting);
                cm.MapProperty(c => c.mods.Flying);
                cm.MapProperty(c => c.mods.Poison);
                cm.MapProperty(c => c.mods.Ground);
                cm.MapProperty(c => c.mods.Rock);
                cm.MapProperty(c => c.mods.Bug);
                cm.MapProperty(c => c.mods.Ghost);
                cm.MapProperty(c => c.mods.Steel);
                cm.MapProperty(c => c.mods.Fire);
                cm.MapProperty(c => c.mods.Water);
                cm.MapProperty(c => c.mods.Grass);
                cm.MapProperty(c => c.mods.Electric);
                cm.MapProperty(c => c.mods.Psychic);
                cm.MapProperty(c => c.mods.Ice);
                cm.MapProperty(c => c.mods.Dragon);
                cm.MapProperty(c => c.mods.Dark);
                cm.MapProperty(c => c.mods.Fairy);
            });
        }

        //[BsonConstructor]
        //public Type(ObjectId _id, string name, int index, modifiers m)
        //{
        //    mods = new modifiers();

        //    this._id = _id;
        //    this.name = name;
        //    this.index = index;

        //    this.mods.Normal = m.Normal;
        //    this.mods.Fighting = m.Fighting;
        //    this.mods.Flying = m.Flying;
        //    this.mods.Poison = m.Poison;
        //    this.mods.Ground = m.Ground;
        //    this.mods.Rock = m.Rock;
        //    this.mods.Bug = m.Bug;
        //    this.mods.Ghost = m.Ghost;
        //    this.mods.Steel = m.Steel;
        //    this.mods.Fire = m.Fire;
        //    this.mods.Water = m.Water;
        //    this.mods.Grass = m.Grass;
        //    this.mods.Electric = m.Electric;
        //    this.mods.Psychic = m.Psychic;
        //    this.mods.Ice = m.Ice;
        //    this.mods.Dragon = m.Dragon;
        //    this.mods.Dark = m.Dark;
        //    this.mods.Fairy = m.Fairy;
        //}
    }
}
