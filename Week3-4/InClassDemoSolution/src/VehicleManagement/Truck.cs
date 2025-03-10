using System.Text.Json.Serialization.Metadata;

namespace src.VehicleManagement;

public class Truck:Vehicle
{
    public int CargoCapacity { get; set; }

    public Truck()
    {
        
    }
    
    public Truck(string make, string model, int year, int cargoCapacity)
    {
        base._make = make;
        base._model = model;
        base._year = year;
        this.CargoCapacity = cargoCapacity;
    }

    public override void StartEngine()
    {
        Console.WriteLine("Truck engine started");
    }

    public static Truck operator +(Truck one, Truck two)
    {
        Truck newTruck = new Truck();
        newTruck.CargoCapacity = one.CargoCapacity + two.CargoCapacity;
        
        return newTruck;
    }
    
    // Overriden abstract methods
    public override void Drive()
    {
        Console.WriteLine("The truck is moving slowly, carrying heavy cargo.");
    }

    public override void FuelType()
    {
        Console.WriteLine("Diesel");
    }
}