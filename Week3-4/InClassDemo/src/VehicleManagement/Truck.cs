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
    
    public override void StartEngine()
    {
        Console.WriteLine($"The truck's engine has started.");
    }

    public static int operator +(Truck a, Truck b)
    {
        return a.CargoCapacity + b.CargoCapacity;
    }
   
    
}