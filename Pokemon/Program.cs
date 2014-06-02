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
            LinkedList<Pokeball_Class> objects = new LinkedList<Pokeball_Class>();

            generic pokeball = new generic("Pokeball", "*A flash occurs as the Pokemon appears*", " is a device for catching wild Pokémon. It's thrown like a ball at a Pokémon, comfortably encapsulating its target.", 1);
            great greatball = new great("Greatball", "*A flash occurs as the Pokemon appears*", " is a good, high-performance Poké Ball that provides a higher Pokémon catch rate than a standard Poké Ball can.", 1.5);

            objects.AddLast(pokeball);
            objects.AddLast(greatball);

            foreach (var item in objects)
            {
                Console.WriteLine(item.use());
            }

            Console.ReadLine();
        }
    }
}
