

namespace GregsListCS.DB
{
  public static class FakeDB
  {
    public static List<Car>? Cars { get; set; } = new List<Car>()
    {
      new Car("Aventador", "Lamborghini", 2020, 300000, "Lime Green"),
      new Car("AMG CLA 35 Coupe", "Mercedes", 2022, 35000, "Pearl"),
      new Car("Mustang", "Ford", 2019, 23000, "Red")
    };

      public static List<House> Houses { get; set; } = new List<House>()
    {
      new House(  3, 2, 2, 500000),
      new House( 5, 3, 2, 700000),

    };
  }
}