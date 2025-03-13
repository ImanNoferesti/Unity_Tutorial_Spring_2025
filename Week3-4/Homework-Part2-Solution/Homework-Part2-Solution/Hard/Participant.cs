namespace Homework_Part2_Solution.Hard;

public abstract class Participant
{
    // Fields
    private int _id;
    protected string _name;
    protected int _age;

    // Constructor
    protected Participant(int id, string name, int age)
    {
        this._id = id;
        this._name = name;
        this._age = age;
    }
    
    // Methods
    public void DisplayInfo()
    {
        Console.WriteLine($"Participant Info:\n" +
                          $"Id: {this._id}\n" +
                          $"Name: {this._name}\n" +
                          $"Age: {this._age}");
    }
    
    // Abstract methods
    protected abstract float CalculatePerformance();
    public abstract string StudyType();
}