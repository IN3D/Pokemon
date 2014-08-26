/* 
 * == Created ==
 * on: Eric Hopkins
 * by: 08/19/2014
 *
 * == Modified ==
 * on: Eric Hopkins
 * by: 08/22/2014
 *
 * This file contains information about, and
 * encapsulates the MongoDB client connection.
 *
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Driver.Communication;
using MongoDB.Driver.Linq;
using MongoDB.Bson;

namespace Pokemon.Model
{
    class Client
    {
        MongoClient client;
        MongoServer server;

        public Client()
        {
            client = new MongoClient("mongodb://Application:mm3LhteFxx8Q@ds063449.mongolab.com:63449/pokemon");
            server = client.GetServer();
        }

        public MongoCollection<T> getCollection<T> (string collectionName)
        {
            var db = server.GetDatabase("pokemon");
            MongoCollection<T> collection = db.GetCollection<T>(collectionName);
            return collection;
        }

        public MongoCollection genericCollection (string collectionName)
        {
            var db = server.GetDatabase("pokemon");
            MongoCollection collection = db.GetCollection(collectionName);
            return collection;
        }
        
    }
}
