using System;

namespace SeleniumPOM.CustomException
{
    class NoSuitableDriverFound : Exception
    {
        public NoSuitableDriverFound(string msg) : base(msg)
        {
        }
    }
}
