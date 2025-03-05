namespace src.StudyManagementSystem;

public class PhysicalStudy : Participant
{
    //FIELDS
    private double _reactionTime;

    public double ReactionTime
    {
        get { return _reactionTime; }
    }
    
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
        return 1 - (_reactionTime - .200);
    }

    public override string StudyType()
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
}