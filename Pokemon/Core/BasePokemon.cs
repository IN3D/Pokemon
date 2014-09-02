/*
 * This file is based on the the original Pokemon.cs class file
 * that was created for the alpha build of the project. Which
 * was created on 05/23/2014 by Eric Hopkins
 * 
 * == Created ==
 * on: 08/28/14
 * by: Eric Hopkins
 * 
 * == Modified ==
 * on: 
 * by: 
 * 
 * This class is meant to define data that is true of all pokemon
 * that are of a particular breed.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver.Builders;

namespace Pokemon.Core
{
    class BasePokemon
    {
        public ObjectId id { get; set; }
        public string SpeciesName { get; set; }
        public int CatchRate { get; set; }
        public int HatchTimeMin { get; set; }
        public int HatchTimeMax { get; set; }
        public int DexNumber { get; set; }
        public double GenderRatio { get; set; }
        public int XPGroup { get; set; }

        [BsonElement("BaseStats")]
        private int[] _BaseStats = new int[6];
        [BsonElement("Types")]
        private int[] _Types = new int[2];
        [BsonElement("EVYield")]
        private int[] _EVYield = new int[6];
        // not ready to add this feature in
        //private ObjectId[] _Abilities = new ObjectId[3];


        public BasePokemon(string speciesName, int catchRate, int hatchTimeMin, int hatchTimeMax, int dexNumber, double genderRatio, int xpGroup,
            int[] baseStats, int[] types, int[] evYield)
        {
            // default constructor
            this.id = ObjectId.GenerateNewId();
            this.SpeciesName = speciesName;
            this.CatchRate = catchRate;
            this.HatchTimeMin = hatchTimeMin;
            this.HatchTimeMax = hatchTimeMax;
            this.DexNumber = dexNumber;
            this.GenderRatio = genderRatio;
            this.XPGroup = xpGroup;
            for (int i = 0; i < baseStats.Length; i++)
                this._BaseStats[i] = baseStats[i];
            for (int i = 0; i < types.Length; i++)
                this._Types[i] = types[i];
            for (int i = 0; i < evYield.Length; i++)
                this._EVYield[i] = evYield[i];
        }

        // TODO: Learn sets: natural, egg groups, move learners etc.
        // TODO: Egg Groups
    }
}
