using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Exceptions
{
    public class InvalidActionException: ArgumentException
    {
        public InvalidActionException(string msg)
           : base(msg)
        {

        }
    }
}
