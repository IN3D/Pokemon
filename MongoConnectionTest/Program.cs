using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using MongoDB.Driver.Builders;
using MongoDB.Bson;

namespace MongoConnectionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MongoClient client = new MongoClient("mongodb://Application:mm3LhteFxx8Q@ds063449.mongolab.com:63449/pokemon");
                var server = client.GetServer();
                var db = server.GetDatabase("pokemon");
                var collection = db.GetCollection<Type>("types");

                var query = Query.EQ("name", "Fire");

                //Type something = collection.FindOne(query);

                foreach (Type t in collection.FindAll())
                {
                    Console.WriteLine(t.name);
                    Console.WriteLine("================");

                    for (int i = 0; i < t.modifiers.Elements.Count(); i++)
                    {
                        Console.WriteLine(t.modifiers.Elements.ElementAt(i).Name + ": " + t.modifiers.Elements.ElementAt(i).Value);
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                }


                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("nope");
            }
        }
    }
}
