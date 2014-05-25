using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.cs
{
    abstract class itemBase
    {
        protected string Name { get; set; }
        protected int ID { get; set; }

        public virtual string use()
        {
            return "Not Implemented";
        }
    }

    class potion : itemBase
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

    class battleItem : itemBase
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

    class MainClass
    {
        public static void primary(string[] args)
        {
            LinkedList<itemBase> objects = new LinkedList<itemBase>();

            potion potion01 = new potion("Potion", 20);
            potion potion02 = new potion("Super Potion", 50);
            potion potion03 = new potion("Hyper Potion", 100);

            battleItem battleItem01 = new battleItem("xAttack", 2);
            battleItem battleItem02 = new battleItem("Mega xAttack", 4);

            objects.AddLast(potion01);
            objects.AddLast(potion02);
            objects.AddLast(potion03);
            objects.AddLast(battleItem01);
            objects.AddLast(battleItem02);

            foreach(var item in objects)
            {
                Console.WriteLine(item.use());
                Console.ReadLine();
            }
        }
    }
}
