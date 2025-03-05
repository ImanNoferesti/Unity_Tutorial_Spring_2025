namespace src.VehicleManagement;

public class Car : AbsVehicle
{
  // Constructor
  public Car(string make, string model, int year)
  {
      base._make = make;
      base._model = model;
      base._year = year;
  }
  
    
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
  
  // Ovrriding Drive...must have SOME implementation eve if {}
  public override void Drive()
  {
      Console.WriteLine($"The car is driving smoothly on the road.");
  }

  public override void FuelType()
  {
      
  }
}