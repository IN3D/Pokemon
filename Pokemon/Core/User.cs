﻿/* 
 * == Created ==
 * on: 08/21/2014
 * by: Eric Hopkins
 * 
 * == Modified ==
 * on: 08/26/2014
 * by: Eric Hopkins
 * 
 * This file defines the class data structure for a user's login.
 * Including their unique ObjectId, UserName, Password, and anything
 * else that should be uniquely tied to a persons account.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace Pokemon.Core
{
    public class User
    {
        public ObjectId id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool Developer { get; set; }
        public bool StartedAdventure { get; set; }

        public User()
        {
            // default constructor
        }

        /// <summary>
        /// Used to perform a deep copy from one instance into the current instance.
        /// </summary>
        /// <param name="u">The instance of a user you would like copied into the current acting instance.</param>
        public void copyAssignment(User u)
        {
            this.id = u.id;
            this.UserName = u.UserName;
            this.Password = u.Password;
            this.Developer = u.Developer;
            this.StartedAdventure = u.StartedAdventure;
        }

        public override string ToString()
        {
            if (Developer)
            {
                // like on StackOverflow ;)
                return ("◆" + this.UserName);
            }
            else
            {
                return this.UserName;
            }
        }
    }
}
