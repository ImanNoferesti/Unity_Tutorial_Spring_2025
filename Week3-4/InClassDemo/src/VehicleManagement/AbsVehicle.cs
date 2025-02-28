namespace src.VehicleManagement;

public abstract class AbsVehicle
{
    // Fields
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    
    // Constructor
    public AbsVehicle(string make, string model, int year)
    {
        Make = make; 
        Model = model;
        Year = year;
    }
    
    // Methods
    
    public void DisplayInfo()
    { 
        Console.WriteLine($"Make: {Make}, Model: {Model}, Year: {Year}");
    }
    
    public virtual void StartEngine()
    {
        Console.WriteLine($"The vehicle's engine has started.");
    }
    
    public abstract void Drive();

    public abstract void FuelType();

}