namespace src.VehicleManagement;

public class Car:Vehicle
{

    public Car(string make, string model, int year)
    {
        base._make = make;
        base._model = model;
        base._year = year;
    }
    
    // Overriden method
    public override void StartEngine()
    {
        Console.WriteLine("Car engine started.");
    }

    public void Honk()
    {
        Console.WriteLine("Beep!");
    }

    // Overloaded method
    public void Honk(int times)
    {
        string result = "";
        for (int i = 0; i < times; i++)
        {
            result += "Beep! ";
        }
        
        Console.WriteLine(result);
    }
    
    // Overriden abstract methods
    public override void Drive()
    {
        Console.WriteLine("The car is driving smoothly on the road.");
    }

    public override void FuelType()
    {
        Console.WriteLine("Gasoline");
    }
}