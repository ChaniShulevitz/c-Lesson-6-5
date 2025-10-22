using System;
using System.Activities;
using System.Activities.Statements;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace Lesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            List<Shelf<Book>> BookShelves = new List<Shelf<Book>>();
            //פה יש את התפיסות של השגיאות
            //    Shelf<Book> one = new Shelf<Book>(1, 2, 200);
            Shelf<Book> one = null;

            try
            {
                one = new Shelf<Book>(0, 2, 40);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("בעיה בערך " + ex.Message);
                Console.WriteLine("הגורם לבעיב " + ex.ParamName);
            }
            catch (Exception ex)
            {
                Console.WriteLine("שגיאה לא מוכרת ");
            }
            //
            Shelf<Book> two = null;

            try
            {

                two = new Shelf<Book>(2, 2, 30);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("בעיה בערך " + ex.Message);
                Console.WriteLine("הגורם לבעיב " + ex.ParamName);
            }

            catch (Exception ex)
            {
                Console.WriteLine("שגיאה לא מוכרת ");
            }


            Shelf<Book> three = new Shelf<Book>(3, 3, 2);
            Shelf<Book> four = new Shelf<Book>(4, 1, 50);
            if (one != null)
            {
                one.Items.Add(new Book(200, "English", 100, 3, "Moshe Katz"));
                one.Items.Add(new Book(100, "children", 50, 6, "Moshe Katz"));
                one.Items.Add(new Book(80, "TheWar", 50, 50, "Dina segal"));
            }
            if (two != null)
            {
                two.Items.Add(new Book(200, "English", 20, 3, "Moshe Katz"));
            }
            three.Items.Add(new Book(150, "animals", 25, 9, "Rivka Levi"));
            three.Items.Add(new Book(250, "Science", 38, 12, "Ester Goldman"));
            four.Items.Add(new Book(300, "07/10/2023", 40, 300, "Yossi man"));
            four.Items.Add(new Book(200, "problemsOfChildren", 20, 20, "Kobi Levy"));
            BookShelves.Add(one);
            BookShelves.Add(two);
            BookShelves.Add(three);
            BookShelves.Add(four);


            files.Write(BookShelves);//זימון של פונקציה שכותבת לקובץ
            //שאילתה 1
            var fullshelves = from sh in BookShelves
                              where sh.Items.Sum(b => b.weight) >= sh.weightCapacity
                              select sh;

            foreach (var shell in fullshelves)
                Console.WriteLine(shell.ShelfNumber);

            //שאילתא 2

            var forChildren = from ch in BookShelves
                              from b in ch.Items

                              where b.name.Contains("children")
                              select ch;

            foreach (var b1 in forChildren)
                Console.WriteLine(b1.ShelfNumber);



            //שאילתא 3

            var expensive = from e in BookShelves
                            from b in e.Items
                                //  let b = items as Book
                            where b.price >= 250
                            select e;

            foreach (var c1 in expensive)
                Console.WriteLine(c1.ShelfNumber);


            //שאילתא 4

            var specificAuthor = from ch in BookShelves
                                 from b in ch.Items

                                 where b.author.Contains("Moshe Katz")
                                 select ch;

            foreach (var k1 in specificAuthor)
                Console.WriteLine(k1.ShelfNumber);




            //שאילתא 5

            var booksInSpecificShelf = from ch in BookShelves
                                       from b in ch.Items

                                       where b.numOfSells == 3
                                       select b;

            foreach (var p1 in booksInSpecificShelf)
            {
                Console.WriteLine(p1.name);

            }
            // עד פה שיעורי בית של שיעור שלוש

            // ביטוי למבדה-שיעורי בית משיעור ארבע



            // שאילתא אחד - מציאת הספרים שעולים יותר מ100 שקל ונמכרו מהם יותר מחמש עותקים

            var lam1 = BookShelves.SelectMany(shelf => shelf.Items)
          .Where(b => b.price > 100 && b.numOfSells > 5);
            foreach (var b1 in lam1)
            {
                Console.WriteLine(b1.name);
            }

            //   שאילתא 2
            var lam2 = BookShelves
           .SelectMany(shelf => shelf.Items)
           .Where(b => b.weight >= 50);
            foreach (var b2 in lam2)
            {
                Console.WriteLine(b2.name);

            }
            // שאילתא 3
            var lam3 = BookShelves
               .SelectMany(shelf => shelf.Items)
              .OrderBy(k => k.price);


            foreach (var b3 in lam3)
            {
                Console.WriteLine(b3.name);

            }
            //שאילתא 4

            var lam4 = BookShelves
          .SelectMany(shelf => shelf.Items)
         .Count(k2 => k2.name == "English");
            Console.WriteLine($"THE AMOUNT OF ENGLISH BOOKS ARE{lam4}");

            // קריאה לפונקציית FIND שעשיתי בSHELF :
            var fun = BookShelves[0].FindItem(k3 => k3.price > 100);
            Console.WriteLine(fun?.name);

            Console.WriteLine("here");
            Console.ReadLine();
            files.Read("..\\..\\file.txt");//זימון של הפונקציה שקוראת מקובץ הזימון של הכתיבה לקובץ עשיתי בשורה 78



        }
    }
}

