using System;

namespace Work_to_form.Exceptions
{
    class ArgumentEmptyException : Exception
    {
        public DateTime time { get; private set; }
        public ArgumentEmptyException() : base("Необходимо выбрать товар") => time = DateTime.Now;
    }
}
