using TechnicalTiagnosis.Core.Enums;

namespace TechnicalTiagnosis.Core.Entities;
public class Car
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Pelak { get; set; }
    public string Model { get; set; }
    public CarTypes CarType { get; set; }
}