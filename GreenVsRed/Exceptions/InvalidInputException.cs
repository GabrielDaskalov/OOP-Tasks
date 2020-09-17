using System;
using System.Collections.Generic;
using System.Text;

namespace GreenVsRed.Exceptions
{
    public class InvalidInputException : FormatException
    {
        public InvalidInputException(string msg)
            :base(msg)
        {

        }
    }
}
