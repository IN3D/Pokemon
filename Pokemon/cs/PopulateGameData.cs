/* Pokemon: Infinte: A recreation of classic Pokemon games in C#
 * 
 * 
 * == Created ==
 * on: 6/9/2014
 * by: Eric Hopkins
 * 
 * Please note taht this file is a temporary place holder. And is just a quick
 * way to enter data into the game to test that the functaionality of playing
 * the game atually works. It should either be removed or at least cleaned up
 * at a later date.
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public static class PopulateGameData
    {
        public static void load()
        {
            // Add regions
            Model.gameWorld.AddLast(new Region("Kanto"));

            // Add areas to region 0

            // PALLET TOWN
            Model.gameWorld.ElementAt(0).areas.AddLast(new Area("Pallet Town",
                "A fairly new and quiet town. It's a small and pretty place.",
                1, 3, 3));
            Model.gameWorld.ElementAt(0).areas.ElementAt(0).neighbors[0] = 1;
            Model.gameWorld.ElementAt(0).areas.ElementAt(0).peopleInArea[0] = new Person("Robert", "Townie",
                "Pokemon are so interesting", "I'm just testing out a bunch of text");
            Model.gameWorld.ElementAt(0).areas.ElementAt(0).peopleInArea[1] = new Person("Simon", "Townie",
                "I just have one line of text");
            Model.gameWorld.ElementAt(0).areas.ElementAt(0).peopleInArea[2] = new Person("Karen", "Townie",
                "I just moved to this town!", "I'm sure that I'll love it here.");
            Model.gameWorld.ElementAt(0).areas.ElementAt(0).buildingsInArea[0] = new Building("My House",
                "My own house", new Person("Mom", "My Mom", "Have fun on your pokemon adventure!"));
            Model.gameWorld.ElementAt(0).areas.ElementAt(0).buildingsInArea[1] = new Building("Rival's House",
                "My Rival's house", new Person("Rival's Sister", "My rival's sister.", "Wait who are you?",
                    "Oh you're <Rival>'s friend"));
            Model.gameWorld.ElementAt(0).areas.ElementAt(0).buildingsInArea[2] = new Building("Oak's Lab",
                "The Laboratory of Prof. Oak, the Pokemon professor!", new Person("Prof. Oak",
                    "A world renowned expert on Pokemon", "Please go to Viridian city and retrieve my package, thanks!"),
                    new Person("Assisstant #1", "One of Oak's assisstants", "Sorry I'm working"), new Person("Assisstant #2",
                        "One of Oak's assisstants", "Sorry I'm working"));

            // ROUTE 1
            Model.gameWorld.ElementAt(0).areas.AddLast(new Area("Route 1",
                "A country road full of greenery and rough paths", 2, 0, 0));
            Model.gameWorld.ElementAt(0).areas.ElementAt(1).neighbors[0] = 0;
            Model.gameWorld.ElementAt(0).areas.ElementAt(1).neighbors[1] = 2;

            // VIRIDIAN CITY
            Model.gameWorld.ElementAt(0).areas.AddLast(new Area("Viridian City",
                "A beautiful city that is enveloped in green year-round.", 1, 2, 2));
            Model.gameWorld.ElementAt(0).areas.ElementAt(2).neighbors[0] = 1;
            Model.gameWorld.ElementAt(0).areas.ElementAt(2).peopleInArea[0] = new Person("Random Guy",
                "some dude just walking around", "I like sleeping");
            Model.gameWorld.ElementAt(0).areas.ElementAt(2).peopleInArea[1] = new Person("Other Random Guy",
                "another dude wandering around", "I like slowpoke", "It's just like me", "It's my spirit animal");
            Model.gameWorld.ElementAt(0).areas.ElementAt(2).buildingsInArea[0] = new Building("Pokemon Center",
                "NOT YET IMPLEMENTED");
            Model.gameWorld.ElementAt(0).areas.ElementAt(2).buildingsInArea[1] = new Building("Pokemart",
                "NOT YET IMPLEMENTED");

            // END OF KANTO
        }
    }
}
