using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    abstract class PokeballBase
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

    class GenericBall : PokeballBase
    {
        public GenericBall(string name, string flash, string description, double catchRate)
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

    class MasterBall : PokeballBase
    {
        public MasterBall(string name, string flash, string description, double catchRate)
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
