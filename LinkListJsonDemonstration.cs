using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Bridgelabz.ObjectOriented
{
    class LinkListJsonDemonstration
    {
        public static void Main(String[] args)
        {
            LinkedList<LinkListItem> linklist = new LinkedList<LinkListItem>();
            LinkedList<LinkListItem> read = new LinkedList<LinkListItem>();

            linklist.AddLast(new LinkListItem(2, 3));
            linklist.AddLast(new LinkListItem(3, 4));
            linklist.AddLast(new LinkListItem(5, 6));
            linklist.AddLast(new LinkListItem(7, 8));


            ////Serializing linklist
            string linklistJSON = JsonConvert.SerializeObject(linklist);
            Console.WriteLine("Serialized JSON Object: " + linklistJSON);
            ////Writing to json file
            StreamWriter sw = new StreamWriter("link.json");
            sw.WriteLine(linklistJSON);
            sw.Close();
            ////Reading from Json file
            StreamReader sr = new StreamReader("link.json");



            ////Deserializing
            LinkedList<LinkListItem> readlist = JsonConvert.DeserializeObject<LinkedList<LinkListItem>>(sr.ReadLine());

            
            
            foreach (LinkListItem item in readlist)
                item.Show();

            Console.WriteLine("\n");

        }



    }

      
}

