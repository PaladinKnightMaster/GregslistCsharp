namespace GregslistCsharp.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CarsController : ControllerBase
{
  private readonly CarsService _carsService;

  public CarsController(CarsService carsService)
  {
    _carsService = carsService;
  }


  [HttpGet]
  public ActionResult<List<Car>> GetCars()
  {
    try
    {
      List<Car> cars = _carsService.GetCars();
      return Ok(cars);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpGet("{id}")]
  public ActionResult<Car> GetCarById(int id)
  {
    try
    {
      Car car = _carsService.GetCarById(id);
      return car;
    }
    catch (System.Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpPost]
  public ActionResult<Car> Create([FromBody] Car carData)
  {
    try
    {
      Car car = _carsService.PostCar(carData);
      return Ok(car);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

}
