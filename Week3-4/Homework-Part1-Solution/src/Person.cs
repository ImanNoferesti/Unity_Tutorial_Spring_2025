namespace src;

public class Person
{
    // Fields
    public string Name = "Unknown";
    public int Age = 0;
    private string _city = "Iowa City";
    private static int _population = 0;

    // Getters and Setters
    public string City
    {
        get { return this._city; }
        set { this._city = value; }
    }

    public static int Population
    {
        get { return _population; }
    }

    // Constructors
    public Person()
    {
        _population++;
    }

    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
        _population++;
    }
    
    static Person()
    {
        Console.WriteLine("Static constructor called!");
    }
    
    // Methods
    public void Introduce()
    {
        Console.WriteLine($"Hi, my name is {this.Name} and I am {this.Age} years old from {this._city}.");
    }

    public static void ShowPopulation()
    {
        Console.WriteLine($"Population: {_population}");
    }
    
    
}