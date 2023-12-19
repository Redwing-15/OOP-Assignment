namespace OOP_Assignment
{
    class Clothing : Item
    {
        private int size; // XS, S, M, L, XL, XXL
        private string colour;
        private string style; // Shorts, Capris, Leggings, Vests, Tops, Jackets

        // This looks messy, interfaces will possibly fix this??
        public Clothing(int size, string colour, string style, string name, double price, int stockorderlevel, string supplier)
            : base(name, price, stockorderlevel, supplier)
        {
            this.size = size;
            this.colour = colour;
            this.style = style;
        }

        public int Size
        {
            get { return size; }
            set { size = value; }
        }
        public string Colour
        {
            get { return colour; }
            set { colour = value; }
        }
        public string Style
        {
            get { return style; }
            set { style = value; }
        }

        public override string ToString()
        {
            return $"""
                Price:  �{Price.ToString("0.00")}
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
        private string type; // Racer, Stability, Neutral, Trail, Track

        // This looks messy, interfaces will possibly fix this??
        public Shoe(int size, string type, string name, double price, int stockorderlevel, string supplier)
            : base(name, price, stockorderlevel, supplier)
        {
            this.size = size;
            this.type = type;
        }

        public int Size
        {
            get { return size; }
            set { size = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public override string ToString()
        {
            return $"""
                Price:  �{Price.ToString("0.00")}
                Type:   {Type}
                Size:   {Size}
                Brand:  {Supplier}
                Stock:  {Stock}
                """;
        }
    }

    abstract class Accessory : Item
    {
        private string accessoryType;
        public Accessory(string accessoryType, string name, double price, int stockorderlevel, string supplier)
            : base(name, price, stockorderlevel, supplier)
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