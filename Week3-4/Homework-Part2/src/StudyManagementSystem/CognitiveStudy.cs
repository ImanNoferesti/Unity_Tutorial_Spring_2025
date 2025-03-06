namespace src.StudyManagementSystem;

public class CognitiveStudy : Participant
{
    //VARIABLES
    private int _memoryScore;

    public double PerformanceScore;

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
        PerformanceScore = (_memoryScore / 100.0); // (x - xmin) / (xmax - xmin) simplifies to x / 100 in this case
        return PerformanceScore;
    }
    
    public override string GetStudyType()
    {
        return "Cognitive Study";
    }

    public static bool operator <(CognitiveStudy a, CognitiveStudy b)
    {
        return a.Performance() < b.Performance();
    }

    public static bool operator >(CognitiveStudy a, CognitiveStudy b)
    {
        return a.Performance() > b.Performance();
    }

    public static CognitiveStudy operator +(CognitiveStudy a, CognitiveStudy b)
    {
        double avgPerf = (a.Performance() + b.Performance()) / 2;
        CognitiveStudy averagePerformanceParticipant = new CognitiveStudy(0,"Average", 0);
        averagePerformanceParticipant.PerformanceScore = avgPerf;
        return averagePerformanceParticipant;
    }
}