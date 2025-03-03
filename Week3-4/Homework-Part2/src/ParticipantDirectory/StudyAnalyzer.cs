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
            double normalValue = (i - min) / (max - min);
            rawDataNormal.Add(normalValue);
        }
        return rawDataNormal;
    }

    public int CompareParticipants(StudyData a, StudyData b)
    {
        return 0;
    }
}