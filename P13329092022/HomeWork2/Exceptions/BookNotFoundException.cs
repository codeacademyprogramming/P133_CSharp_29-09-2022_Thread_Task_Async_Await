using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork2.Exceptions
{
    class BookNotFoundException : Exception
    {
        public BookNotFoundException(string msg) : base(msg)
        {

        }
    }
}
