using Microsoft.AspNetCore.Mvc;
using GregsListCS;

namespace GregsListCS.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HouseController : ControllerBase
    {
        private readonly HousesService _hs;
        public HouseController(HousesService hs)
        {
            _hs = hs;
        }
        [HttpGet]
        public ActionResult<IEnumerable<House>> Get()
        {
            try
            {
                List<House> houses = _hs.Get();
                return Ok(houses);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpGet("{id}")]
        public ActionResult<House> Get (string id)
        {
            try
            {
                House house = _hs.Get(id);
                return Ok(house);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPost]
        public ActionResult<House> Create([FromBody] House newHouse)
        {
            try{
                House house = _hs.Create(newHouse);
                return house;
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPut("{id}")]
        public ActionResult<House> Update([FromBody] House updateHouse, string id)
        {
            try
            {
                updateHouse.Id = id;
                House house = _hs.Edit(updateHouse);
                return Ok(house);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpDelete("{id}")]
        public ActionResult<String> Remove (string id)
        {
            try
            {
                _hs.Remove(id);
                return Ok ("House Removed");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}