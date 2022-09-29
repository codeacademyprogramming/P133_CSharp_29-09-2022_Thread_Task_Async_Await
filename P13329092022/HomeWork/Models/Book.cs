using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Models
{
    class Book
    {
        static int _count;

        public readonly string Code;
        public string Name;
        public string AuthorName;
        public int PageCount;

        static Book()
        {
            _count = 0;
        }

        public Book(string name, string authorName, int pageCount)
        {
            _count++;
            Code = $"{name.Substring(0, 2).ToUpper()}{_count}";
            Name = name;
            AuthorName = authorName;
            PageCount = pageCount;
        }

        public override string ToString()
        {
            return $"Code: {Code}\nName: {Name}\nAuthor Name: {AuthorName}\nPage Count: {PageCount}";
        }
    }
}
