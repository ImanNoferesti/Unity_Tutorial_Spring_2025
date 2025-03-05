namespace src;

public class Person
{
    // Fields
    
    public string Name = "Unknown";
    public int Age = 0;
    private string _location = "Iowa City, IA";
    public static int Population;
    
    // Constructors

    static Person()
    {
        Console.WriteLine("Static constructor called!");
    }
    public Person()
    {
        Population++;
    }

    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;

        Population++;
    }
    
    // Methods

    public string Location
    {
        get { return this._location; }
        set { this._location = value; }
    }
    
    public void Introduce()
    {
        Console.WriteLine($"Hi, my name is {Name}. I am {Age} years old. I am from {_location}");
    }

    public static void ShowPopulation()
    {
        Console.WriteLine($"The total population is {Person.Population}");
    }
}