using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorDataResul<T> : DataResult<T>
    {
        public ErrorDataResul(T data, string message) : base(data, false, message)
        {

        }
        public ErrorDataResul(T data) : base(data, false)
        {

        }
        public ErrorDataResul(string message) : base(default, false, message)
        {

        }
        public ErrorDataResul() : base(default, false)
        {

        }
    }
}
