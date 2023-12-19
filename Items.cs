namespace OOP_Assignment
{
    class Clothing : Item
    {
        private ClothingSize size;
        private string colour;
        private ClothingStyle style;

        public Clothing(ClothingSize size, string colour, ClothingStyle style, string name, double price)
            : base(name, price)
        {
            this.size = size;
            this.colour = colour;
            this.style = style;
        }

        public ClothingSize Size
        {
            get { return size; }
            set { size = value; }
        }
        public string Colour
        {
            get { return colour; }
            set { colour = value; }
        }
        public ClothingStyle Style
        {
            get { return style; }
            set { style = value; }
        }

        public override string ToString()
        {
            return $"""
                Price:  £{Price.ToString("0.00")}
                Type:   {Style}
                Size:   {Size}
                Colour: {Colour}
                Brand:  {Supplier}
                Stock:  {Stock}
                """;
        }
    }

    class Shoe : Item
    {
        private int size;
        private ShoeType type;

        public Shoe(int size, ShoeType type, string name, double price)
            : base(name, price)
        {
            this.size = size;
            this.type = type;
        }

        public int Size
        {
            get { return size; }
            set { size = value; }
        }
        public ShoeType Type
        {
            get { return type; }
            set { type = value; }
        }

        public override string ToString()
        {
            return $"""
                Price:  £{Price.ToString("0.00")}
                Shoe Type:   {Type}
                Shoe Size:   {Size}
                Brand:  {Supplier}
                Stock:  {Stock}
                """;
        }
    }

    abstract class Accessory : Item
    {
        private string accessoryType;
        public Accessory(string accessoryType, string name, double price)
            : base(name, price)
        {
            this.accessoryType = accessoryType;
        }

        public string AccessoryType
        {
            get { return accessoryType; }
            set { accessoryType = value; }
        }
    }
}