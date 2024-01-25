using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace BookandAuthor
{
    internal class Book
    {
        private string name;
        private string author;
        private int id;
        private string isbn;
        private double price;
        public string publisher;


        public static string theme = "Oppikirjat";
        public static int NextId = 1; //alkuarvo

        private const string PREFIX = "978";
        private const int MAXLENGHT = 13;

        public string Name 
        {
            get 
            {
                return name; 
            }

            set 
            {
                if(value == string.Empty)
                {
                    // ???? 
                }

                name = value; 
            }
        }

        public string Isbn 
        {
            get => isbn;
             set
            {
                if (value.StartsWith(PREFIX) && value.Length == MAXLENGHT) 
                {
                    isbn = value;
                }
            }
        }

        public string Author { get => author; set => author = value; }
        public double Price
        {
            get => price;
            set
            {
                if (value > 30)
                {
                    price = 0.9 * value;
                }
                else
                {
                    price = value;
                }
            }
        }

        public Book() 
        {
            this.Name = string.Empty;
            this.id = NextId;
            NextId++;
        }

        public Book(string name, string isbn)
        {
            this.Name = name;
            this.isbn = isbn;
            this.id = NextId;
            NextId++;
        }


        public void Setname(string value)
        {
            this.Name = value;
        }

        public string GetName() 
        {
            return this.Name; 
        }
        public void GetBookDetails(string isbnValue)
        {
            //Console.Writeline(isbnValue);
            if (this.isbn == isbnValue)
            {
                //tulosta kirjan tiedot
                Console.WriteLine(this.ToString());
            }
            else
            {
                Console.WriteLine("Kirjan tietoja ei voi tulostaa");
            }
        }

        public Book(string name)
        {
            this.Name = name;
            this.id = NextId;
            NextId++;
        }

        public Book(string name, string author, string isbn, double price, string publisher)
        {
            this.isbn = isbn;
            this.Price = price;
            this.publisher = publisher;
            this.name = name;
            this.author = author;

            this.id = NextId;
            NextId++;
        }

        public override string ToString()
        {
            return $"{this.id}: Kirjan nimi:{this.Name}; teema:{theme}";
        }
    }
}