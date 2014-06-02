using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    abstract class Pokeball_Class
    {
        protected string Name { get; set; }
        protected string Description {get; set; }
        protected string PokeballFlash { get; set; }
        protected double CatchRate { get; set; }

        public virtual string use()
        {
            return "Not Implemented";
        }
    }

    class generic : Pokeball_Class
    {
        public generic (string name, string flash, string description, double catchRate)
        {
            this.Name = name;
            this.PokeballFlash = flash;
            this.Description = description;
            this.CatchRate = catchRate;

        }

        public override string use()
        {
           return this.Name + this.Description +" Catch rate of: " + this.CatchRate + "x" + "\n" + this.PokeballFlash;
        }
    }

    class great : Pokeball_Class
    {
        public great (string name, string flash, string description, double catchRate)
        {
            this.Name = name;
            this.PokeballFlash = flash;
            this.Description = description;
            this.CatchRate = catchRate;
        }

        public override string use()
        {
            return this.Name + this.Description + " Catch rate of: " + this.CatchRate + "x" + "\n" + this.PokeballFlash;
        }
    }
}
