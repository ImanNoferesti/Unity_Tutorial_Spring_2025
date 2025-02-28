namespace src.VehicleManagement;

public class Vehicle
{
    // ********* Step 1 ************
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    // private string _make;
    // private string _model;
    // private string _year;
    
    public Vehicle() 
    {
       
    }
    public Vehicle(string make, string model, int year) 
    {
        this.Make = make;
        this.Model = model;
        this.Year = year;
    }
    
    public void DisplayInfo()
    {
        Console.WriteLine($"Make: {Make} Model: {Model} Year: {Year}");
    }
    
    public virtual void StartEngine()
    {
        Console.WriteLine("The engine has started");
    }
    
    public void Drive()
    {
        Console.WriteLine("The vehicle is moving down the road");
    }
}

public class Car : Vehicle
{
    public override void StartEngine()
    {
        Console.WriteLine("Car engine started");
    }

    public void Honk(int a)
    {

    }
}

public class Truck : Vehicle
{
    
}