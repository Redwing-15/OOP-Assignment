namespace OOP_Assignment
{
    class Bag : Accessory
    {
        private string capacity;
        public Bag(string capacity, string accessoryType, string name, double price, int stock, int stockorderlevel, string supplier)
            : base(accessoryType, name, price, stock, stockorderlevel, supplier)
        {
            this.capacity = capacity;
        }

        public string Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        public override string ToString()
        {
            return $"""
                Price:     £{Price.ToString("0.00")}
                Type:      {AccessoryType}
                Capacity:  {Capacity}L
                Brand:     {Supplier}
                Stock:     {Stock}
                """;
        }
    }

    class Nutrition : Accessory
    {
        private string quantity;
        private string nutritionType;
        public Nutrition(string quantity, string nutritionType, string accessoryType, string name, double price,
            int stock, int stockorderlevel, string supplier)
            : base(accessoryType, name, price, stock, stockorderlevel, supplier)
        {
            this.quantity = quantity;
            this.nutritionType = nutritionType;
        }

        public string Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public string NutritionType
        {
            get { return nutritionType; }
            set { nutritionType = value; }
        }

        public override string ToString()
        {
            return $"""
                Price:    £{Price.ToString("0.00")}
                Type:      {AccessoryType}
                Quantity:  {Quantity}
                Nutrient:  {NutritionType}
                Brand:     {Supplier}
                Stock:  {Stock}
                """;
        }
    }

    class Watch : Accessory
    {
        private string watchType;
        public Watch(string watchType, string accessoryType, string name, double price, int stock, int stockorderlevel, string supplier)
            : base(accessoryType, name, price, stock, stockorderlevel, supplier)
        {
            this.watchType = watchType;
        }

        public string WatchType
        {
            get { return watchType; }
            set { watchType = value; }
        }

        public override string ToString()
        {
            return $"""
                Price:  £{Price.ToString("0.00")}
                Type:   {AccessoryType}
                Spec:   {watchType}
                Brand:  {Supplier}
                Stock:  {Stock}
                """;
        }
    }
}