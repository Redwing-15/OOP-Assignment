namespace OOP_Assignment
{
    class Bag : Accessory
    {
        private int capacity;
        public Bag(int capacity, string accessoryType, string name, double price)
            : base(accessoryType, name, price)
        {
            this.capacity = capacity;
        }

        public int Capacity
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
        private NutrientType nutritionType;
        public Nutrition(string quantity, NutrientType nutritionType, string accessoryType, string name, double price)
            : base(accessoryType, name, price)
        {
            this.quantity = quantity;
            this.nutritionType = nutritionType;
        }

        public string Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public NutrientType NutritionType
        {
            get { return nutritionType; }
            set { nutritionType = value; }
        }

        public override string ToString()
        {
            return $"""
                Price:    £{Price.ToString("0.00")}
                Type:      {AccessoryType}
                Quantity:  {Quantity}g
                Nutrient:  {NutritionType}
                Brand:     {Supplier}
                Stock:  {Stock}
                """;
        }
    }

    class Watch : Accessory
    {
        private WatchType watchType;
        public Watch(WatchType watchType, string accessoryType, string name, double price)
            : base(accessoryType, name, price)
        {
            this.watchType = watchType;
        }

        public WatchType WatchType
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