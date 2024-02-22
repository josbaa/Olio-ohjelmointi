using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FileExercise
{
    internal class Book
    {
        private string title;
        private string author;
        private string price;

        public string Title { get => title; set => title = value; }
        public string Author { get => author; set => author = value; }
        public string Price { get => price; set => price = value; }

        public Book() { }

        public override string? ToString()
        {
            return $"Title: {Title}, Author: {Author}, Price: {Price}";
        }
    }
}
