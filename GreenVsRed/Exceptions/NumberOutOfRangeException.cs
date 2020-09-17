using System;
using System.Collections.Generic;
using System.Text;

namespace GreenVsRed.Exceptions
{
    public class NumberOutOfRangeException : Exception
    {
        public NumberOutOfRangeException(string msg)
            :base(msg)
        {

        }


    }
}
