using System;

namespace Work_to_form.Exceptions
{
    class DoubleArgumentException : Exception
    {
        public DoubleArgumentException() : base("Значение должно быть числом") { }
    }
}
