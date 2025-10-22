using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;


namespace Lesson2
{
    public class files
    {

        const string FILENAME = "..\\..\\file.txt";

        public static void Write(List<Shelf<Book>> shelves)
        {
            StreamWriter streamWriter;
            streamWriter = new StreamWriter(FILENAME, false);
            foreach (var shelf in shelves)
            {
                foreach (var book in shelf.Items)
                {
                    streamWriter.WriteLine(book.name);
                }
            }
            streamWriter.Close();


        }
        public static void Read(string path)
        {
            StreamReader reader = new StreamReader(path);

            List<string> lines = new List<string>();

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                lines.Add(line); 
            }
        }
    }

}