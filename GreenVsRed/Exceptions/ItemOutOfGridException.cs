using System;
using System.Collections.Generic;
using System.Text;

namespace GreenVsRed.Exceptions
{
    public class ItemOutOfGridException: Exception
    {
        public ItemOutOfGridException(string msg)
            :base(msg)
        {

        }

    }
}
