/* Pokemon: Infinte: A recreation of classic Pokemon games in C#
 * 
 * 
 * == Created ==
 * on: 6/9/2014
 * by: Brad Mackey?
 *
 * == Modified ==
 * on: 8/10/2014
 * by: Eric Hopkins
 * 
 * 
 */
using System;
using System.Text;

namespace Pokemon
{
    abstract class PokeballBase
    {
        public double CatchRate { get; set; }
        public string Description {get; set; }
        public string Name { get; set; }
        public string PokeballFlash { get; set; }

        // TODO: formulate variables for the other types of balls (ex: Quick, Timer, Heavy, Friend, Love, etc.) that will have to take in data from game data for the character

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
