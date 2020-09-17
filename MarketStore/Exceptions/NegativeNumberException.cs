using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    public class NegativeNumberException: Exception
    {
        public NegativeNumberException(string msg)
            :base(msg)
        {

        }

    }
}
