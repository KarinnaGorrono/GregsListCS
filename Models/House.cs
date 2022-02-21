
namespace GregsListCS
{
  public class House
  {

    public string Id { get; set; }
    public int Bedrooms { get; set; }
    public int Bathrooms { get; set; }
    public int Levels { get; set; }
    public int Price { get; set; }


    public House( int bedrooms, int bathrooms, int levels, int price)
    {
      Id = Guid.NewGuid().ToString();
     
      Bedrooms = bedrooms;
      Bathrooms = bathrooms;
      Levels = levels;
      Price = price;
    }

  }
}