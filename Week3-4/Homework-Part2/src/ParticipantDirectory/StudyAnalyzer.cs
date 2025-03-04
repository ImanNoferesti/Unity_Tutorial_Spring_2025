namespace src.ParticipantDirectory;

public struct StudyAnalyzer : IDataAnalysis
{
    
    public List<double> NormalizeReactionTimes(List<double> rawData)
    {
        double max = rawData.Max();
        double min = rawData.Min();
        List<double> rawDataNormal = new List<double>();
        foreach (double i in rawData)
        {
            double normalValue = (i - min) / (max - min);   //I don't know if this formula is correct, but I also
            rawDataNormal.Add(normalValue);                 //don't think it matters as much as implementation
        }
        return rawDataNormal;
    }

    // This probably needs to be static to call without new member, redo when mental effort exists
    //Honestly above too probably
    public StudyData CompareParticipants(StudyData p1, StudyData p2)
    {
        StudyData nullParticipant = new StudyData(00, 02);
        if (p1.GetAccuracyRate() > p2.GetAccuracyRate())
        {
            return p1;
        }
        else if (p2.GetAccuracyRate() > p1.GetAccuracyRate())
        {
            return p2;
        }
        else return nullParticipant;
        
    }
}