

namespace GregsListCS
{
  public class Job
  {

    public string? Id { get; set; }
    public string? Position { get; set; }
    public string? Company { get; set; }
    public int Pay { get; set; }
    public string? Description { get; set; }
    public Job(string? position, string? company, int pay, string? description)
    {
      Id = Guid.NewGuid().ToString();
      Position = position;
      Company = company;
      Pay = pay;
      Description = description;
    }
  }
}