namespace src.StudyManagementSystem;

public class PhysicalStudy : Participant
{
    //FIELDS
    private double _reactionTime;

    public double ReactionTime
    {
        get { return _reactionTime; }
    }

    public double PerformanceScore;
    
    //CONSTRUCTORS
    public PhysicalStudy(int id, string name, int age)
    {
        this._age = age;
        this._identifier = id;
        this._age = age;
    }
    
    //METHODS
    public override double Performance()
    {
        // (x - xmin) / (xmax - xmin) -- simplifies to x - .200
        // to inverse subtract from 1
        PerformanceScore = 1 - (_reactionTime - .200);
        return PerformanceScore;
    }

    public override string GetStudyType()
    {
        return "Physical Study";
    }

    public void SetReactionTime(double rt)
    {
        if (.200 < rt && rt > 1.200)
        {
            _reactionTime = rt;
        }
        else Console.WriteLine("Reaction time outside of cutoff");
    }
    public static bool operator <(PhysicalStudy a, PhysicalStudy b)
    {
        return a.Performance() < b.Performance();
    }

    public static bool operator >(PhysicalStudy a, PhysicalStudy b)
    {
        return a.Performance() > b.Performance();
    }

    public static PhysicalStudy operator +(PhysicalStudy a, PhysicalStudy b)
    {
        double avgPerf = (a.Performance() + b.Performance()) / 2;
        PhysicalStudy averagePerformanceParticipant = new PhysicalStudy(0,"Average", 0);
        averagePerformanceParticipant.PerformanceScore = avgPerf;
        return averagePerformanceParticipant;
    }
}