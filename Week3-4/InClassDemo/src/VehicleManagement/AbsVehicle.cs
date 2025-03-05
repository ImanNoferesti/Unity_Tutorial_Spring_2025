namespace src.VehicleManagement;

public abstract class AbsVehicle
{
    // Fields
    
    protected string _make { get; set; }
    protected string _model { get; set; }
    protected int _year { get; set; }
    
    // Methods
    
    public void DisplayInfo()
    { 
        Console.WriteLine($"Make: {this._make}, Model: {this._model}, Year: {this._year}");
    }
    
    public virtual void StartEngine()
    {
        Console.WriteLine($"The vehicle's engine has started.");
    }
    
    public abstract void Drive();

    public abstract void FuelType();

}