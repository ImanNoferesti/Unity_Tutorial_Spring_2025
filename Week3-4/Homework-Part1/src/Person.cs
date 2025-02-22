namespace src;
//step 1
public class Person
{
    //step 3 added =
    public string Name = "unkown";
    public int Age = 0;
    private string _city;
    //step 2
    public string City { get; set; }

    //steps 4 & 5
    public void Introduce()
    {
        Console.WriteLine($"Hi, my name is {Name} and I am {Age} years old from {City}");
    }
    
    //step 8
    public static int Population;
    
    //step 6
    public Person()
    {
        Population++;
    }

    public Person(string Name, int Age, string _city)
    {
        this.Name = Name;
        this.Age = Age;
        this._city = _city;
        Population++;
    }
    
    //step 10
    static Person()
    {
        Console.WriteLine("Static Constructor Called!");
    }
    
    // step 9
    public static void ShowPopulation()
    {
        Console.WriteLine($"Population is: {Population}");
    }
    
}