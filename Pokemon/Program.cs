using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<ItemBase> objects = new LinkedList<ItemBase>();

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

            foreach (var item in objects)
            {
                Console.WriteLine(item.use());
            }

            // the ReadLine should be outside of your for loop,
            // otherwise the terminal will request input after every
            // time it prints an item.
            Console.ReadLine();
        }
    }
}
