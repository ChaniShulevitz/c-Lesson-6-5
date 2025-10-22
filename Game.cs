using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lesson2
{
    public class Game : Item
    {
        public int PlayerAge { get; set; }
        public Game(int price, string name, int weight, int numOfSells, int PlayerAge)
            : base(price, name, weight, numOfSells)
        {
            PlayerAge = PlayerAge;
        }


        public override string ToString()
        {

            return $"{price},{name},{weight},{numOfSells},{PlayerAge}";
        }
    }
}