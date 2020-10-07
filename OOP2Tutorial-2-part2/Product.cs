namespace OOP2Tutorial_2_part2
{
    public class Product
    {
        private string _name;
        private int _price;

        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new NullValueException("Name cannot be null or empty.");
                }
                else
                {
                    _name = value;
                }
            }
        }

        public int Price
        {
            get => _price;
            set
            {
                 if (value < 0 || value > 999) 
                 {
                     throw new ValueOutOfBoundException("Price has to be in range [0,999].");
                 }
                 else
                 {
                     _price = value;
                 }
            }
        }
        
        // Overwrite toString()
        public override string ToString()
        {
            return ("Product: " + _name + "  Price: " + _price);
        }
    }
}