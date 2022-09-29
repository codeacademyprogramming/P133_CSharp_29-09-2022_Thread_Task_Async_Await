using HomeWork.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Services
{
    class Library
    {
        List<Book> Books;

        public Library()
        {
            Books = new List<Book>();
        }

        public List<Book> FindAllBooksByName(string val)
        {
            return Books.FindAll(b => b.Name.ToLower().Contains(val.ToLower()));
        }

        public void RemoveAllBookByName(string val)
        {
            Books.RemoveAll(b => b.Name.ToLower().Contains(val.ToLower()));
        }

        public List<Book> SearchBooks(string search)
        {
            return Books.FindAll(b => b.Name.ToLower().Contains(search.ToLower()) || 
            b.AuthorName.ToLower().Contains(search.ToLower()) || 
            b.PageCount.ToString().Contains(search.ToLower()));
        }

        public List<Book> FindAllBooksByPageCountRange(int min, int max)
        {
            return Books.FindAll(b => b.PageCount >= min && b.PageCount <= max);
        }

        public void RemoveByNo(string code)
        {
            Book book = Books.Find(b => b.Code == code.ToUpper());

            if (book != null)
            {
                Books.Remove(book);
            }
            else
            {
                Console.WriteLine($"{code} Yasnlisdir");
            }
        }

    }
}
