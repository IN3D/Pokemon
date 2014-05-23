/* Pokemon: Infinte: A recreation of classic Pokemon games in C#
 * 
 * 
 * == Created ==
 * on: 5/23/2014
 * by: Eric Hopkins
 * 
 * == Last Modified ==
 * on: 25/23/2014
 * by: Eric Hopkins
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
        public static void ReadXML(string fileLocation)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(fileLocation);

            foreach (XmlNode node in doc.DocumentElement)
            {
                if (node.NodeType != XmlNodeType.Comment)
                {
                    Console.WriteLine("Name: " + node.Attributes.GetNamedItem("name").Value);
                    Console.WriteLine("\tDexNumber: " + node.ChildNodes.Item(0).InnerText);
                    Console.WriteLine("\tCatch Rate: " + node.ChildNodes.Item(1).InnerText);
                    Console.WriteLine("\tLevel Group: " + node.ChildNodes.Item(2).InnerText);
                    bool genderless = node.ChildNodes.Item(3).InnerText != "0";
                    Console.WriteLine("\tGenderless: " + genderless.ToString());
                    Console.WriteLine("\tTypes: ");
                    int i = 1;
                    foreach (XmlNode n in node.ChildNodes.Item(4))
                    {
                        Console.WriteLine("\t\tType " + i + ": " + n.InnerText);
                        i++;
                    }
                    Console.WriteLine("\tStats: ");
                    foreach (XmlNode n in node.ChildNodes.Item(5))
                    {
                        Console.WriteLine("\t\t" + n.Attributes.GetNamedItem("name").Value + ": " + n.InnerText);
                    }
                    Console.WriteLine("\tLearn Set: ");
                    foreach(XmlNode n in node.ChildNodes.Item(6))
                    {
                        Console.WriteLine("\t\tlvl. " + n.Attributes.GetNamedItem("level").Value + ": " + n.InnerText);
                    }
                }
            }
        }
    }
}
