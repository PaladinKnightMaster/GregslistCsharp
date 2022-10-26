namespace GregslistCsharp.Services;

public class CarsService
{
  private readonly CarsRepository _carsRepo;

  public CarsService(CarsRepository carsRepo)
  {
    _carsRepo = carsRepo;
  }

  public List<Car> GetCars()
  {
    return _carsRepo.GetCars();
  }

  public Car GetCarById(int id)
  {
    return _carsRepo.GetCarById(id);
  }

  public Car PostCar(Car carData)
  {
    return _carsRepo.PostCar(carData);
  }

  public Car RemoveCar(int Id)
  {
    return _carsRepo.RemoveCar(Id);
  }

  public Car EditCar(int id, Car carData)
  {
    return _carsRepo.EditCar(id, carData);
  }
}