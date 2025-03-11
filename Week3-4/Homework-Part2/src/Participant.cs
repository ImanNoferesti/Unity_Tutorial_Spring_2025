namespace src;

public abstract class Participant
{
    // fields
    protected int _subID = 999;
    protected string _subName = "name";
    protected int _subAge = 0;
    public string SubInfo = "no info recorded";
    
    // Constructor
    
    // QUESTION:
    // error:  Member names cannot be the same as their enclosing type
    // ...but constructors have the same name as the class
    
    public void Participant(int ID, string Name, int Age)
    {
        this._subID = ID;
        this._subName = Name;
        this._subAge = Age;
    }

    public abstract double CalculatePerformance();
   
    public string DisplayParticipantInfo(Participant p)
        //
    {
        // convert _subID to string
        // convert _subName to string
        // convert  subAge to String
        // concatenate those three into a string and assign to SubjectReport
        
        return SubInfo;
    }
}