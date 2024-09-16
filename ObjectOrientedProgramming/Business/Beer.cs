namespace ObjectOrientedProgramming.Business
{
    public class Beer : Drink, ISalable, ISend
    {
        private const string Category = "Beer"; // constant
        private decimal _alcohol; // field
        public string Name { get; set; } // property
        public decimal Price { get; set; }

        public static int QuantityObjects;

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

        public Beer(string name, decimal price, decimal alcohol, int quantity)
            : base(quantity)
        {
            Name = name;
            Price = price;
            Alcohol = alcohol;
            QuantityObjects++;
        }

        public virtual string GetInfo()
        {
            return $"Name: {Name}, Price: {Price}";
        }

        public string GetInfo(string message)
        {
            return $"{message} Name: {Name}, Price: {Price}";
        }
        public string GetInfo(int message)
        {
            return $"{message} Name: {Name}, Price: {Price}";
        }

        public override string GetCategory()
        {
            return Category;
        }

        public decimal GetPrice() => Price;
        public void Send()
        {
            Console.WriteLine("Sending beer");
        }
    }
}