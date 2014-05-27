/* Pokemon: Infinte: A recreation of classic Pokemon games in C#
 * 
 * 
 * == Created ==
 * on: 5/23/2014
 * by: Eric Hopkins
 * 
 * 
 * This file contains all the data for the game engine class. As of
 * it's creation, this will only really involve reading in the games
 * data, however anything "base level" to the game may best be passed
 * through the game engine. The Engine Class file is static and cannot
 * be instantiated.
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Pokemon
{
    public static class Engine
    {

        public static void ReadXML(string fileLocation, ref LinkedList<Pokemon> list)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(fileLocation);

            foreach (XmlNode node in doc.DocumentElement)
            {
                

                if (node.NodeType != XmlNodeType.Comment)
                {
                    string name = node.Attributes.GetNamedItem("name").Value;
                    int dexNum = int.Parse(node.ChildNodes.Item(0).InnerText);
                    int catchRate = int.Parse(node.ChildNodes.Item(1).InnerText);
                    // Levelgroup not yet used
                    bool genderless = node.ChildNodes.Item(3).InnerText != "0";

                    // just do types as strings for now
                    string[] types = new string[2];
                    int i = 0;
                    foreach (XmlNode n in node.ChildNodes.Item(4))
                    {
                        types[i] = n.InnerText;
                        i++;
                    }

                    int[] baseStats = new int[6];
                    int x = 0;
                    foreach (XmlNode n in node.ChildNodes.Item(5))
                    {
                        baseStats[x] = int.Parse(n.InnerText);
                        x++;
                    }

                    // TODO: attacks not yet implemented
					list.AddLast(new Pokemon(name, catchRate ,dexNum, genderless, baseStats, types));
                }
            }
        }
    }
}
