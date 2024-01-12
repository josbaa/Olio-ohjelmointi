using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olio_ohjelmoinnin_eka_tunti
{
    internal class Program
    {
        public static object Book1 { get; private set; }

        private static void Main(string[] args)
        {

            Console.WriteLine("Book exercise!");
            // Tähän olioon tallennetaan Aapinen
            Book book1 = new Book();
            book1.title = "Aapinen";
            book1.price = 20.50;
            Console.WriteLine("book1-olio on:" + book1.title);
            Console.WriteLine($"book1-olio on: {book1.title}, hinta: {book1.price} €");

            // TÄHÄN olioon tallennetaan Peppi Pitkätossu
            Book book2 = new Book();
            book2.title = "Peppi Pitkätossu";
            book2.SetId("12345");
            Console.WriteLine("book2-olio on" + book2.title);
            Console.WriteLine($"book-olio on: {book2.title}, hinta:{book2.price} €");
       

            book1.CompareBook(book2);
            book2.CompareBook (book1);
        }
    }

    internal class Book1
    {
    }
}
