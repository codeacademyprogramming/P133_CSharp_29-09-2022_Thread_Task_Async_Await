﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork2.Exceptions
{
    class SameBookalreadyAddedExpection : Exception
    {
        public SameBookalreadyAddedExpection(string msg) : base(msg)
        {

        }
    }
}
