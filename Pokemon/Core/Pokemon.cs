/*
 * == Created ==
 * on: 08/28/14
 * by: Eric Hopkins
 * 
 * This class defines specific (ie. unique) pokemon.
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace Pokemon.Core
{
    class Pokemon
    {
        public ObjectId id { get; set; }
        public ObjectId OriginalTrainerID { get; set; }
        public int Ability { get; set; }
        public int Gender { get; set; }
        public string Nickname { get; set; }
        public int Level { get; set; }
        public int XPToNextLevel { get; set; }
        public int XPCurrent { get; set; }
        public string BallType { get; set; }
        public bool isShiny { get; set; }
        public bool isSuperShiny { get; set; }
        // I might not want to keep this an int, but I'm
        // operating under the assumption that I'll use this
        // value as a key to a conditions array.
        public int Condition { get; set; }
        public int Friendship { get; set; }

        protected BasePokemon basePkm;
        protected int[] EVs = new int[6];
        protected int[] IVs = new int[6];
        protected int[] Stats = new int[6];
    }
}
