namespace src.VehicleManagement;

public class Truck : AbsVehicle
{
    // Fields
    public int CargoCapacity { get; set; }
    public string Fuel { get; set; }
    
    // Constructors
    
    public Truck()
    {
        
    }
    
    public Truck(string make, string model, int year, int cargoCapacity, string fuel)
    {
        base._make = make;
        base._model = model;
        base._year = year;
        this.CargoCapacity = cargoCapacity;
        this.Fuel = fuel;
    }
    
    public override void StartEngine()
    {
        Console.WriteLine($"The truck's engine has started.");
    }
    
    // this needs to be of type Truck so that it creates a new instance of truck (one with capacity a + b)
    // rather than overwriting the capacity of a or b.
    
    public static Truck operator +(Truck a, Truck b)
    {
        Truck newTruck = new Truck();
        newTruck.CargoCapacity = a.CargoCapacity + a.CargoCapacity;
        
        return newTruck;
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