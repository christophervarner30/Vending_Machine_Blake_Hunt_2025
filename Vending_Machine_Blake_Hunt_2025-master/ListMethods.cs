using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine_Blake_Hunt
{
    internal class ListMethods
    {
        //put in some data at start
        public static void InitData(List<Item> current)
        {
            string[] allNames = {
                "Lays Plain Potato Chips",
                "Lays Barbique Potato Chips",
                "Lays Sour Cream and Onion",
                "Sun Chips French Onion",
                "Sun Chips tomato",
                "Doritos Nacho Cheese",
                "Doritos Cool Ranch",
                "Cheetos Cheese Flavor",
                "Freetos standard",
            };

            int i = 0;

            foreach (string name in allNames)
            {
                current.Add(new Item(allNames[i], i + 1));
                i++;
            }
        }
        //print all items
        public static void PrintAll(List<Item> itemList)
        {
            int i = 0;
            foreach (Item product in itemList)
            {
                Console.Write(itemList[i].ItemNumber.ToString() + " ");
                Console.Write(itemList[i].ItemName.ToString());
                Console.WriteLine();
                i++;
            }
        }
        //vend one item
        public static void PrintOne(List<Item> itemList, int x)
        {
            Console.WriteLine("Vending:");
            Console.WriteLine(itemList[x - 1].ItemName.ToString());
            Logger.LogVendingActivity(itemList[x - 1].ItemName);
        }
        //add one item
        public static void Add(List<Item> itemList, string name)
        {
            int i = (itemList.Count + 1);
            itemList.Add(new Item(name, i));
        }
    }
}
