using System;
using System.Collections.Generic;
using System.Text;

namespace _03_CarConstructors
{
    public class CarCannotContinueException : Exception
    {
        public CarCannotContinueException(string message)
            : base(message)
        {
        }
    }
}
