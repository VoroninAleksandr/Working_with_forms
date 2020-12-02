using System;

namespace Work_to_form.Exceptions
{
    class FieldNullException : Exception
    {
        public FieldNullException() : base("Заполните поля:\n'Наименование товара'\n'Страна производитель'") { }
    }
}
