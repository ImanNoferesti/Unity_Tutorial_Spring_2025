namespace src.ParticipantDirectory;

public struct StudyData
{
    //Variables / Attributes (can not actually remember what we called these)
    public int ParticipantID;

    public int Age;

    public List<double> ReactionTimes = new List<double>();

    public double CorrectResponses { get; set; }

    public double TotalResponses { get; set; } 
    
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
            return accuracy;
        }
           

    }

    public string GenerateReport()
    {
        string report = $"\nParticipant {ParticipantID} Summary Report:" +
                        $"\nAge: {Age}" +
                        $"\nMean RT: {GetMeanReactionTime()} s " +
                        $"\nAccuracy: {GetAccuracyRate()} ";
        return report;
    } 

    //Constructors
    public StudyData()
    {
        
    }

    public StudyData(int participantId, int age)
    {
        this.ParticipantID = participantId;

        this.Age = age;
    }
}