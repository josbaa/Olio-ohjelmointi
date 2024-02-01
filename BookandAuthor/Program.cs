using Literature;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookandAuthor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            Book testBook1 = new Book("Peppi Pitkätossu", "Astrid Lindgren", "9782221113333", 35, "WSOY");
            //testBook1.Setname("Aapinen");
            testBook1.Name = "Aapinen";
            Console.WriteLine(testBook1);


            Console.WriteLine("Kirjan otsikko on:" + testBook1.Name);


            Book testBook2 = new Book("Matematiikka I" + "1234567891012");
            Console.WriteLine(testBook2);

            Console.WriteLine("\nMuutetaan teema\n");
            Book.theme = "Oppikirjat";
            
            Console.WriteLine("Tulostetaan kirjat uudelleen\n");
            Console.WriteLine(testBook1);
            Console.WriteLine(testBook2);

            Author author1 = new Author ("Astrid.Lindgren", "1.1.1950", testBook1);


            Console.ReadLine();
        }
    }
}
