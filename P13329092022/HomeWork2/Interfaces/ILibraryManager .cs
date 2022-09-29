using HomeWork2.Enums;
using HomeWork2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork2.Interfaces
{
    interface ILibraryManager
    {
        List<Book> Books {get;}

        void Add(Book book);
        Book ShowInfo(string name);
        List<Book> Search(string search);
        List<Book> Filter(Genre genre, string author);
    }
}
