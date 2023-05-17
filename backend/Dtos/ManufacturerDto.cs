using backend.Models;

namespace backend.Dtos;

public class ManufacturerDto
{
  public ManufacturerDto(Manufacturer m)
  {
    Id = m.Id;
    Name = m.Name;
    
    Vehicle = m.Vehicles
      .Select(v => new VehicleDto(v))
      .ToList();

    Foods = m.ManufacturerFoods
      .Select(mf => mf.Food)
      .ToDictionary(mf => mf.Id, mf => mf.Name);
  }

  public int Id { get; set; }
  public string Name { get; set; } = default!;
  public Dictionary<int, string> Foods { get; set; } = new();
  public List<VehicleDto> Vehicle { get; set; } = new();



}

public class VehicleDto
{
  public VehicleDto(Vehicle v)
  {
    Id = v.Id;
    Name = v.Name;
    Speed = v.Speed;
  }

  public int Id { get; set; }
  public string Name { get; set; } = default!;
  public int Speed { get; set; }


}