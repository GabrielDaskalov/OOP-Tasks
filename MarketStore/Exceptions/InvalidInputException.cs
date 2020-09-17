using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    public class InvalidInputException : FormatException
    {
        public InvalidInputException(string msg)
            :base(msg)
        {
        }


    }
}
