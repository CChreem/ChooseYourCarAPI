namespace Domain
{
    public class Car
    {
        public string Color { get; set; }

        public int DoorQuantity { get; set; }

        public string Model { get; set; }

        public Car(string color, int doorQuantity, string model)
        {
            if (string.IsNullOrEmpty(color))
            {
                throw new ArgumentException($"'{nameof(color)}' cannot be null or empty.", nameof(color));
            }

            if (string.IsNullOrEmpty(model))
            {
                throw new ArgumentException($"'{nameof(model)}' cannot be null or empty.", nameof(model));
            }

            if (doorQuantity > 4) throw new ArgumentException($"'{nameof(doorQuantity)}' cannot be greater than 4.", nameof(doorQuantity));

            Color = color;
            DoorQuantity = doorQuantity;
            Model = model;
        }

    }
}