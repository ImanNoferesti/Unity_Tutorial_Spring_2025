namespace src.VehicleManagement;

public class Truck : AbsVehicle
{
    // Fields
    public int CargoCapacity { get; set; }
    public string Fuel { get; set; }
    
    // Constructor
    public Truck(string make, string model, int year, int cargoCapacity, string fuel)
        : base(make, model, year)
    {
        CargoCapacity = cargoCapacity;
        Fuel = fuel;
    }
    
    public override void StartEngine()
    {
        Console.WriteLine($"The truck's engine has started.");
    }

    public static int operator +(Truck a, Truck b)
    {
        return a.CargoCapacity + b.CargoCapacity;
    }
   
    // Ovrriding Drive (abstract method) 
    public override void Drive()
    {
        Console.WriteLine($"The truck is stuck in the snow b/c it is a POS Cybertruck.");
    }

    public override void FuelType()
    {
        Console.WriteLine($"Truck Fuel Type: {Fuel}.");
    }
}