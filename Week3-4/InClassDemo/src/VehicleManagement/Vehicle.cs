namespace src.VehicleManagement;

public class Vehicle // Parent (Base) Class
{
    public string? Make { get; set; }
    
    public string? Model { get; set; }
    
    public int Year { get; set; }

    public void DisplayInfo(string Make, string Model, int Year)
    {
        Console.WriteLine($"Vehicle's details: Make;{Make}, Model;{Model}, Year;{Year}");
    }

    public void StartEngine()
    {
        Console.WriteLine("The engine has started.");
    }
}