using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Lesson2
{
    public class Book : Item
    {
        public String author { get; set; }
        public override string ToString()
        {

            return $"{price},{name},{weight},{numOfSells},{author}";
        }

        public Book(int price, string name, int weight, int numOfSells, string author)
       : base(price, name, weight, numOfSells)
        {
            this.author = author;
        }


    }
}
