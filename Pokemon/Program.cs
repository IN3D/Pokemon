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

            // Test case: Eric 5/23/2014
            Engine.ReadXML("..//..//xml//pokemon.xml");

            Console.WriteLine("If you see me, this didn't crash.");
            Console.ReadLine();
        }
    }
}
