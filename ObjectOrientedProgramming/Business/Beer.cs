namespace ObjectOrientedProgramming.Business
{
    public class Beer
    {
        private decimal _alcohol; // field
        public string Name { get; set; } // property
        public decimal Price { get; set; }

        public decimal Alcohol
        {
            get
            {
                return _alcohol;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Alcohol cannot be negative");
                }
                _alcohol = value;
            }
        }

        public Beer(string name, decimal price, decimal alcohol)
        {
            Name = name;
            Price = price;
            Alcohol = alcohol;
        }

        public string GetInfo()
        {
            return $"Name: {Name}, Price: {Price}";
        }
    }
}