using HomeWork2.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork2.Models
{
    class Book
    {
        public string Name;
        public string Author;
        public int PageCount;
        public Genre Genre;

        public Book(string name, string author, int pageCount, Genre genre)
        {
            Name = name;
            Author = author;
            PageCount = pageCount;
            Genre = genre;
        }

        public override string ToString()
        {
            return $"{Name} {Author} {PageCount} {Genre}";
        }
    }
}
