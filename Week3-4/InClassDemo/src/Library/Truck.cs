namespace src.Library;

public class Truck : Vehicles
{
    public int CargoCapacity;

    public Truck(string make, string model, int year, int cargoCapacity)
    {
        this.Make = make;
        this.Model = model;
        this.Year = year;
        this.CargoCapacity = cargoCapacity;
    }

    public override void Drive()
    {
        Console.WriteLine("The truck is moving slowly, carrying heavy cargo.");
    }

    public override void FuelType()
    {
        Console.WriteLine("The truck takes Diesel fuel.");
    }
    public override void StartEngine()
    {
        Console.WriteLine("Truck engine started!");
    }

    public static int operator +(Truck a, Truck b)
    {
        return a.CargoCapacity + b.CargoCapacity;
    }
}