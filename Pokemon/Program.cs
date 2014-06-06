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
            LinkedList<PokeballBase> objects = new LinkedList<PokeballBase>();

            GenericBall pokeball = new GenericBall("Poke ball", "*A flash occurs as the Pokemon appears*", " is a device for catching wild Pokémon. It's thrown like a ball at a Pokémon, comfortably encapsulating its target.", 1);
            GenericBall greatball = new GenericBall("Great ball", "*A flash occurs as the Pokemon appears*", " is a good, high-performance Poké Ball that provides a higher Pokémon catch rate than a standard Poké Ball can.", 1.5);
            GenericBall ultraball = new GenericBall("Ultra ball", "*A flash occurs as the Pokemon appears*", " is an ultra-high performance Poké Ball that provides a higher success rate for catching Pokémon than a Great Ball.", 2);
            GenericBall safariball = new GenericBall("Safari ball", "*A flash occurs as the Pokemon appears*", " is a special Poké Ball that is used only in the Great Marsh. It is decorated in a camouflage pattern.", 1.5);
            GenericBall premierball = new GenericBall("Premier ball", "*A flash occurs as the Pokemon appears*", " is a somewhat rare Poké Ball that was made as a commemorative item used to celebrate an event of some sort.", 1);
            GenericBall sportsball = new GenericBall("Sports ball", "*A flash occurs as the Pokemon appears*", " is a special Poké Ball for the Bug-Catching Contest.", 1.5);

            MasterBall masterball = new MasterBall("Master ball", "*A flash occurs as the Pokemon appears*", " is the best Poké Ball with the ultimate level of performance. With it, you will catch any wild Pokémon without fail.", 255);
            MasterBall parkball = new MasterBall("Park ball", "*A flash occurs as the Pokemon appears*", " is a special Poké Ball for the Pal Park.", 255);

            objects.AddLast(pokeball);
            objects.AddLast(greatball);
            objects.AddLast(ultraball);
            objects.AddLast(safariball);
            objects.AddLast(premierball);
            objects.AddLast(sportsball);
            objects.AddLast(parkball);
            objects.AddLast(masterball);

            foreach (var item in objects)
            {
                Console.WriteLine(item.use());
            }

            Console.ReadLine();
        }
    }
}
