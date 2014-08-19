using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace Pokemon.Core
{
    class User
    {
        public ObjectId id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool Developer { get; set; }

        public User()
        {

        }
    }
}
