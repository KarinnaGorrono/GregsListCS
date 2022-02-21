namespace GregsListCS
{
    public class Car{
        public string? Id { get; set; }
        public string? Model { get; set; }
        public string? Make { get; set; }
        public int Year { get; set; }
        public int Price { get; set; }
        
        public string? Color { get; set; }

        public Car(string? model, string? make, int year, int price, string? color)

        {
            Id = Guid.NewGuid().ToString();
            Model = model;
            Make = make;
            Year = year;
            Price = price;
            Color = color;
        }

    }
}