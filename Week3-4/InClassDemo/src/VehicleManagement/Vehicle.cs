namespace src.VehicleManagement;

public class Vehicle
{
    
    // *************** Step 1 *************** 
    
    // private string _make;
    // private string _model;
    // private int _year;
    //
    // public string Make
    // {
    //     get { return _make; }
    //     set { _make = value; }
    // }
    //
    // public string Model
    // {
    //     get { return _model; }
    //     set { _model = value; }
    // }
    //
    // public int Year
    // {
    //     get { return _year; }
    //     set { _year = value; }
    // }
    
    // // Constructor
    // public Vehicle(string make, string model, int year)
    // {
    //     this._make = make; 
    //     this._model = model;
    //     this._year = year;
    // }
    
    // public void DisplayInfo()
    // { 
    //     Console.WriteLine($"Make: {_make}, Model: {_model}, Year: {_year}");
    // }
    //
    // public void StartEngine()
    // {
    //     Console.WriteLine($"The {_year} {_model}'s engine has started.");
    // }
    //
    // public void Drive()
    // {
    //     Console.WriteLine($"The {_year} {_model} is driving on the road.");
    // }

    // *************** Step 2 *************** 
  
    // Fields
    // public string Make { get; set; }
    // public string Model { get; set; }
    // public int Year { get; set; }
    
    // Constructor
    public Vehicle()
    {
    }
    
    // Methods
    
    public virtual void StartEngine()
    {
        Console.WriteLine($"The vehicle's engine has started.");
    }
    
    public virtual void Drive()
    {
        Console.WriteLine($"The vehicle is driving on the road.");
    }
}