namespace Homework_Part2_Solution.Hard;

public class CognitiveStudyParticipant : Participant
{
    // Fields
    private float _memoryScore;
    
    // Setters
    public float MemoryScore
    {
        set
        {
            if (value >= 0 && value <= 100)
            {
                this._memoryScore = value;
            }
            else
            {
                Console.WriteLine("Memory score must be between 0 and 100. Try Again!");
            }
        }
    }
    
    // Constructor
    // The derived class calls the base constructor to initialize the base class fields before initializing its own fields.
    public CognitiveStudyParticipant(int id, string name, int age, float memoryScore) : base(id, name, age)
    {
        this._memoryScore = memoryScore;
    }
    
    
    // Methods
    // Overriden methods
    protected override float CalculatePerformance()
    {
        // Performance is normalized between 0.0 and 1.0
        float max = 100f;
        float min = 0f;
        
        return (this._memoryScore - min) / (max - min);
    }

    public override string StudyType()
    {
        return "Cognitive Study";
    }
    
    // Overloaded methods
    public static bool operator >(CognitiveStudyParticipant p1, CognitiveStudyParticipant p2)
    {
        return p1.CalculatePerformance() > p2.CalculatePerformance();
    }

    public static bool operator <(CognitiveStudyParticipant p1, CognitiveStudyParticipant p2)
    {
        return p1.CalculatePerformance() < p2.CalculatePerformance();
    }

    public static CognitiveStudyParticipant operator +(CognitiveStudyParticipant p1, CognitiveStudyParticipant p2)
    {
        float avgMemoryScore = (p1._memoryScore + p2._memoryScore) / 2;

        CognitiveStudyParticipant newParticipant = new CognitiveStudyParticipant
        (
            9999,
            "Combined Participant",
            (p1._age + p2._age) / 2,
            avgMemoryScore
        );

        return newParticipant;
    }
}