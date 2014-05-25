using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    abstract class ItemBase
    {
        protected string Name { get; set; }
        protected int ID { get; set; }

        public virtual string use()
        {
            return "Not Implemented";
        }
    }

    class potion : ItemBase
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

    class battleItem : ItemBase
    {
        public battleItem(string name, int id)
        {
            this.Name = name;
            this.ID = id;
        }

        public override string use()
        {
            return "Pokemon's attack raised by " + this.ID.ToString();
        }
    }
}
