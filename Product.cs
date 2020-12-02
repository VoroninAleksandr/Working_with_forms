namespace Work_to_form
{
    public class Product
    {
        public string NameProduct {get; set;}
        public string Countries { get; set; }
        public double Price;
        public override string ToString()
        {
            return $"Name: {NameProduct} Countries: {Countries} Price: {Price}";
        }
    }
}
