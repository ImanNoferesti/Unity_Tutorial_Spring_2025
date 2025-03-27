namespace src.VehicleManagement;

public abstract class Vehicle
{
    protected string _make;
    protected string _model;
    protected int _year;
    

    public void DisplayInfo()
    {
        Console.WriteLine($"Vehicle: {this._make}, {this._model}, {this._year}");
    }

    public virtual void StartEngine()
    {
        Console.WriteLine("Vehicle: Engine has started");
    }

    public abstract void Drive();

    public abstract void FuelType();
    
}