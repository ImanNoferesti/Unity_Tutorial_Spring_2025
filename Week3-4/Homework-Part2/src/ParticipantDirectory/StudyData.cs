namespace src.ParticipantDirectory;

public struct StudyData
{
    //Variables / Attributes (can not actually remember what we called these)
    public int ParticipantID;

    public int Age;

    public List<double> ReactionTimes = new List<double>();

    public double CorrectResponses { get; set; }

    public double TotalResponses { get; set; } 
    
    //Constructors
    public StudyData()
    {
        
    }

    public StudyData(int participantId, int age)
    {
        this.ParticipantID = participantId;

        this.Age = age;
    }
    
    //Methods
    public double GetMeanReactionTime()
    {
        double sum = 0;
        foreach (double i in ReactionTimes)
        {
            sum = sum + i;
        }
        double mean = sum / ReactionTimes.Count;
        return mean;
    }

    public double GetAccuracyRate()
    {
        if (TotalResponses == 0)
        {
            return 0;
        }
        else
        {
            double accuracy = CorrectResponses / TotalResponses;
            accuracy = accuracy * 100;
            return accuracy;
        }
           

    }

    public string GenerateReport()
    {
        string report = $"\nParticipant {ParticipantID} Summary Report:" +
                        $"\nAge: {Age}" +
                        $"\nMean RT: {GetMeanReactionTime()} s " +
                        $"\nAccuracy: {GetAccuracyRate()}%";
        return report;
    } 
    //Operator Overloading
    public static bool operator > (StudyData a, StudyData b)
    {
        // if (a.GetAccuracyRate() > b.GetAccuracyRate())
        // {
        //     return true;
        // }
        // else
        // {
        //     return false;
        // }
        return a.GetAccuracyRate() > b.GetAccuracyRate();
    }

    public static bool operator <(StudyData a, StudyData b)
    {
        return b.GetAccuracyRate() > a.GetAccuracyRate();
    }

   
}