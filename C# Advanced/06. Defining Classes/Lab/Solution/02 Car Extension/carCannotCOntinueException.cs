using System;
using System.Collections.Generic;
using System.Text;

namespace _02_CarExtension
{
    public class CarCannotContinueException : Exception
    {
        public CarCannotContinueException(string message)
            : base(message)
        {
        }
    }
}
