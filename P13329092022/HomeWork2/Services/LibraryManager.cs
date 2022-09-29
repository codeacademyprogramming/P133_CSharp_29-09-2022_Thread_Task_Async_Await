using HomeWork2.Enums;
using HomeWork2.Exceptions;
using HomeWork2.Interfaces;
using HomeWork2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork2.Services
{
    class LibraryManager : ILibraryManager
    {
        List<Book> _books;
        public List<Book> Books => _books;

        public LibraryManager()
        {
            _books = new List<Book>();
        }

        public void Add(Book book)
        {
            if (/*_books.Count > 0 && */_books.Exists(b=>b.Name.ToUpper() == book.Name.ToUpper()))
            {
                throw new SameBookalreadyAddedExpection($"Bu {book.Name} Adda Kitab Artiq Movcuddur");
            }

            _books.Add(book);
        }

        public List<Book> Filter(Genre genre, string author)
        {
            return _books.FindAll(b => b.Genre == genre && b.Author.ToUpper() == author.ToUpper());
        }

        public List<Book> Search(string search)
        {
            return _books.FindAll(b => b.Name.ToUpper().Contains(search.ToUpper()) ||
            b.Author.ToUpper().Contains(search.ToUpper()));
        }

        public Book ShowInfo(string name)
        {
            Book book = _books.Find(b => b.Name.ToUpper() == name.ToUpper());

            if (book == null)
            {
                throw new BookNotFoundException($"Bu {name} Adda Kitab Yoxdur");
            }

            return book;
        }
    }
}
