namespace src.VehicleManagement;

public class Truck : Vehicle
{
    // Fields
    public int CargoCapacity { get; set; }
    
    // Constructor
    public Truck(string make, string model, int year, int cargoCapacity)
        : base(make, model, year)
    {
        CargoCapacity = cargoCapacity;
    }
}