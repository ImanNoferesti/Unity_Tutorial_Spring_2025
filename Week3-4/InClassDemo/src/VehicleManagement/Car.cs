namespace src.VehicleManagement;

public class Car : Vehicle
{
  
    // Methods
    public override void StartEngine()
    {
        Console.WriteLine($"The car's engine has started.");
    }

    public void Honk()
    {
        Console.WriteLine("Honk");
    }

    
    // Overriding Honk
    public void Honk(int numHonks)
    {
        for (int i = 0; i < numHonks; i++)
        {
            Console.WriteLine("Honk");
        }
    }

}