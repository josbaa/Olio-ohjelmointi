using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookExercise
{
    internal class book
    {
        public string title;
        public string id;
        public double price;
        

        public book() 
        {
            this.title = string.Empty;
            this.price = 15.0;
            SetId("0000");
        }

        public book(string title, double price)
        {
            this.title = title;
            this.price = price;
            SetId(id);
        }

        public void SetId(string Idvalue)
        {
            //tarkista tässä onko id 5 merkkiä pitkä merkkijono
            if (Idvalue.Length == 5)
            {
                this.id = Idvalue;
            }
            else
            {
                this.id = "arvo puuttuu";
            }
        }

        internal void CompareBook(book otherBook)
        {
            Console.WriteLine("Ensimmäinen kirja maksaa " + this.price);
            Console.WriteLine("Toinen kirja maksaa " + otherBook.price);

            if(this.price > otherBook.price)
            {
                Console.WriteLine(this.title + "on kalliimpi kuin" + otherBook.title);
            }
            else if(this.price == otherBook.price)
            {
                Console.WriteLine(this.title + " on saman hintainen kuin" + otherBook.title);
            }
           
        }



    }
}
