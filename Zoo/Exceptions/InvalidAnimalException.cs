using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Exceptions
{
    public class InvalidAnimalException : ArgumentException
    {
        public InvalidAnimalException(string msg)
            : base(msg)
        {

        }
    }
}
