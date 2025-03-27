namespace Homework_Part2_Solution.Hard;

public class PhysicalStudyParticipant : Participant
{
    // Fields
    private float _reactionTime;
    
    // Setters
    public float ReactionTime
    {
        set
        {
            if (value > 0)
            {
                this._reactionTime = value;
            }
            else
            {
                Console.WriteLine("Reaction time must be positive.");
            }
        }
    }
    
    // Constructor
    // The derived class calls the base constructor to initialize the base class fields before initializing its own fields.
    public PhysicalStudyParticipant(int id, string name, int age, float reactionTime) : base(id, name, age)
    {
        this._reactionTime = reactionTime;
    }
    
    // Methods
    // Overriden methods
    protected override float CalculatePerformance()
    {
        return 1 / this._reactionTime;
    }

    public override string StudyType()
    {
        return "Physical Study";
    }
    
    // Overloaded methods
    public static bool operator >(PhysicalStudyParticipant p1, PhysicalStudyParticipant p2)
    {
        return p1.CalculatePerformance() > p2.CalculatePerformance();
    }

    public static bool operator <(PhysicalStudyParticipant p1, PhysicalStudyParticipant p2)
    {
        return p1.CalculatePerformance() < p2.CalculatePerformance();
    }
    
    
}