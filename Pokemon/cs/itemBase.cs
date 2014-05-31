using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public abstract class ItemBase
    {
        protected string Name { get; set; }
        protected string TargetStat { get; set; } //Used for battle items/EV items
        protected string TargetMove { get; set; } //Used for pp moves
        protected int ID { get; set; }

        public virtual string use()
        {
            return "Not Implemented";
        }
    }


    public class potion : ItemBase
    {
        public potion(string name, int id)
        {
            this.Name = name;
            this.ID = id;
        }

        public override string use()
        {
            return "Pokemon healed by " + this.ID.ToString();
        }
    }


    public class ppItem : ItemBase
    {
        public ppItem(string name, string targetMove , int id)
        {
            this.Name = name;
            this.TargetMove = targetMove;
            this.ID = id;
        }

        public override string use()
        {
            return "Pokemon's " + this.TargetMove + " PP has been restored by " + this.ID.ToString();
        }
    }


    public class battleItem : ItemBase
    {
        public battleItem(string name, string targetStat, int id)
        {
            this.Name = name;
            this.TargetStat = targetStat;
            this.ID = id;
        }

        public override string use()
        {
            return "Pokemon's " + this.TargetStat + " raised by " + this.ID.ToString() + " level, for this battle";
        }
    }


    public class evItem : ItemBase
    {
      public evItem(string name, string targetStat, int id)
        {
            this.Name = name;
            this.TargetStat = targetStat;
            this.ID = id;
        }

      public override string use()
      {
          return "Pokemon's " + this.TargetStat + " raised by " + this.ID.ToString();
      }
    }
}
