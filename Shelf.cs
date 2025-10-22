using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    public class Shelf<T>
    {


        private int shelfNumber;

        public int ShelfNumber
        {

            get { return shelfNumber; }
            set
            {
                if (value < 1)
                    throw new ArgumentException("מספר מדף לא תקין", "shelfnumber");
                else { shelfNumber = value; }
            }
        }
        public int columnNumber { get; set; }
        private int weightcapacity;
        public int weightCapacity
        {
            get { return weightcapacity; }
            set
            {
                if (value > 1000)
                    throw new ArgumentException("משקל לא תקין", "weightcapacity");
                else
                {
                    weightcapacity = value;
                }
            }
        }

        public List<T> Items { get; set; }

        public Shelf(int shelfNumber, int columnNumber, int weightCapacity)
        {
            this.shelfNumber = shelfNumber;
            this.columnNumber = columnNumber;
            this.weightCapacity = weightCapacity;
            Items = new List<T>();


        }
        public T FindItem(Func<T, bool> p)
        {
            foreach (var item in Items)
            {
                if (p(item))
                {
                    return item;
                }

            }
            return default(T);

        }

    }
}
