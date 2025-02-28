namespace src.VehicleManagement;

public class Vehicle
{
    private string _make;
    private string _model;
    private int _year;

    public Vehicle(string make, string model, int year)
    {
        this._make = make;
        this._model = model;
        this._year = year;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Vehicle: {this._make}, {this._model}, {this._year}");
    }

    public void StartEngine()
    {
        Console.WriteLine("Vehicle: Engine has started");
    }

    public void Drive()
    {
        Console.WriteLine("Vehicle is moving on the road.");
    }
}