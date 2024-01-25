using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace BookandAuthor
{
    internal class Book
    {
        private string name;
        public int id;
        private string isbn;

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

        public string Id { get => isbn; set => isbn = value; }

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

        public Book(string name)
        {
            this.Name = name;
            this.id = NextId;
            NextId++;
        }

        public override string ToString()
        {
            return $"{this.id}: Kirjan nimi:{this.Name}; teema:{theme}";
        }
    }
}
