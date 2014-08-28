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

namespace Pokemon.Core
{
    class BasePokemon
    {
        public ObjectId id { get; set; }
        public string SpeciesName { get; set; }
        public int CatchRate { get; set; }
        public int DexNumber { get; set; }
        public double GenderRatio { get; set; }
        protected int[] BaseStats = new int[6];
        protected int[] Types = new int[2];
        protected ObjectId[] Abilities = new ObjectId[3];

        // TODO: Learn sets, natural, egg groups, move learners etc.
    }
}
