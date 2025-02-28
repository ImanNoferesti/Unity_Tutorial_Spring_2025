namespace src.Library;

public class Car : Vehicles
{
    public Car(string make, string model, int year)
    {
        this.Year = year;
        this.Make = make;
        this.Model = model;
    }
    public override void StartEngine()
    {
        Console.WriteLine("Car engine started!");
    }

    public override void Drive()
    {
        Console.WriteLine("The car is driving smoothly on the road.");
    }

    public override void FuelType()
    {
        Console.WriteLine("The car take E-85");
    }
    public static void Honk()
    {
        Console.WriteLine("Beep!");
    }
    public static void Honk(int quant)
    {
        for (int i = 0; i < quant; i++)
        {
            Console.WriteLine("Beep!");
        }
    }
}