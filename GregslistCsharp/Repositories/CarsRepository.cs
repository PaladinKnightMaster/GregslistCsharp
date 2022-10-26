namespace GregslistCsharp.Repositories;

public class CarsRepository
{
  private readonly IDbConnection _db;

  public CarsRepository(IDbConnection db)
  {
    _db = db;
  }

  public List<Car> GetCars()
  {
    var sql = "SELECT * FROM cars";
    return _db.Query<Car>(sql).ToList();
  }

  public Car GetCarById(int id)
  {
    var Id = id;
    var sql = "SELECT * FROM cars WHERE id = @id";
    return _db.QuerySingle<Car>(sql, new { id });
  }

  public Car PostCar(Car carData)
  {
    var sql = @"INSERT INTO cars
    (make, model, year, price, description, imgUrl)
      VALUES
    (@Make, @Model, @Year, @Price, @Description, @ImgUrl);
      SELECT LAST_INSERT_ID();
    ";
    carData.id = _db.ExecuteScalar<int>(sql, carData);
    return carData;
  }

  public Car RemoveCar(int id)
  {
    var car = this.GetCarById(id);
    var Id = id;
    var sql = "DELETE FROM cars WHERE id = @id;";
    _db.Execute(sql, new { id });
    return car;
  }

  public Car GetCarColName(int id)
  {
    var sql = "SELECT name FROM cars WHERE id = @id";
    var colName = _db.QuerySingle<Car>(sql, new { id });
    return colName;
  }

  public Car EditCar(int id, Car carData)
  {
    var colName = this.GetCarColName(id);
    // var sql = "ALTER TABLE cars CHANGE @colName @colName VALUES (@Make, @Model, @Year, @Price, @Description, @ImgUrl)";
    // _db.Execute(sql ,new {colName}, carData);
    return carData;
  }
}