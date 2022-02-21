using Microsoft.AspNetCore.Mvc;
using GregsListCS;

namespace gregsCS.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class CarsController : ControllerBase
  {
    private readonly CarsService _cs;
    public CarsController(CarsService cs)
    {
      _cs = cs;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Car>> Get()
    {
      try
      {
        List<Car> cars = _cs.Get();
        return Ok(cars);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    [HttpGet("{id}")]
    public ActionResult<Car> Get(string id)
    {
      try
      {
        Car car = _cs.Get(id);
        return Ok(car);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    [HttpPost]
    public ActionResult<Car> Create([FromBody] Car newCar)
    {
      try
      {
        Car car = _cs.Create(newCar);
        return Ok(car);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    [HttpPut("{id}")]
    public ActionResult<Car> Update([FromBody] Car updateCar, string id)
    {
      try
      {
        updateCar.Id = id;
        Car car = _cs.Edit(updateCar);
        return Ok(car);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    [HttpDelete("{id}")]
    public ActionResult<String> Remove(string id)
    {
      try
      {
        _cs.Remove(id);
        return Ok("Car Removed");
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
  }
}