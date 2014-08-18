using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace MongoConnectionTest
{
    public class Type
    {
        public ObjectId id { get; set; }
        public string name { get; set; }
        public int index { get; set; }
        public BsonDocument modifiers { get; set; }
    }
}