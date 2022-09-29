using HomeWork2.Enums;
using HomeWork2.Models;
using HomeWork2.Services;
using System;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            LibraryManager libraryManager = new LibraryManager();

            libraryManager.Add(new Book("Xemse", "Nizami Gencevi", 600, Genre.Drama));
            libraryManager.Add(new Book("Deceller", "Code", 600, Genre.Science_Fiction));
            libraryManager.Add(new Book("Sefiller", "Viktor Hugo", 300, Genre.Drama));
            libraryManager.Add(new Book("Sherlok Holmes", "Ramiz", 10, Genre.Science_Fiction));
            //libraryManager.Add(new Book("Xemse", "Nizami Gencevi", 600, Genre.Drama));
            Console.WriteLine();
        }
    }
}
