namespace src.StudyManagementSystem;

public abstract class Participant
{
    //Fields
    protected int _identifier;
    protected string _name;
    protected int _age;

    public int ID
    {
        get { return _identifier; }
    }

    public string Name
    {
        get { return _name; }
    }
    public int Age
    {
        get { return _age; }
    }
    
    //Constructors
    public Participant(int id, string name, int age)
    {
        this._age = age;
        this._name = name;
        this._identifier = id;
    }

    public Participant()
    {
        
    }
    
    //Methods
    public string GetDetails()
    {
        string details = $"Participant Name: {Name} ID: {ID} Age: {Age}";
        return details;
    }

    public abstract double Performance();

    public abstract string StudyType();


}