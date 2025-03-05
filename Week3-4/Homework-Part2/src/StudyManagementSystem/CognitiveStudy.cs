namespace src.StudyManagementSystem;

public class CognitiveStudy : Participant
{
    //VARIABLES
    private int _memoryScore;

    public int MemoryScore
    {
        get { return _memoryScore; }
    }
    
    //CONSTRUCTORS
    public CognitiveStudy(int id, string name, int age)
    {
        this._age = age;
        this._identifier = id;
        this._name = name;
    }

    //METHODS
    public void SetScore(int memoryScore)
    {
        if (0 <= memoryScore && memoryScore<= 100)
        {
            _memoryScore = memoryScore;
            Console.WriteLine($"Memory score set to {MemoryScore}");
        }
        else Console.WriteLine("Please enter a score from 0-100");
    }
    
    public override double Performance()
    {
        return (_memoryScore / 100.0); // (x - xmin) / (xmax - xmin) simplifies to x / 100 in this case
    }
    
    public override string StudyType()
    {
        return "Cognitive Study";
    }
}