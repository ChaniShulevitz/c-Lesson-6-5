using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    public class Item
    {

        public int price { get; set; }
        public string name { get; set; }
        public int weight { get; set; }
        public int numOfSells { get; set; }

        public Item(int price, string name, int weight, int numOfSells)
        {
            this.price = price;
            this.name = name;
            this.weight = weight;
            this.numOfSells = numOfSells;
        }
        public Item()
        {

        }
    }
}
