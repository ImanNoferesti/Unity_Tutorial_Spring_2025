namespace src.Library;

public abstract class Vehicles
{
    public string Make;

    public string Model;

    public int Year;

    public Vehicles()
    {
        
    }
    public Vehicles(string make, string model, int year)
    {
        this.Make = make;
        this.Model = model;
        this.Year = year;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"\nMake: {Make} " +
                          $"\nModel: {Model}" +
                          $"\nYear: {Year}");
    }

    public virtual void StartEngine()
    {
        Console.WriteLine("Engine is starting... vroom vroom");
    }

    public abstract void Drive();

    public abstract void FuelType();
}