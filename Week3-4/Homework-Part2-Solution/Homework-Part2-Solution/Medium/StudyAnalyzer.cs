namespace Homework_Part2_Solution.Medium;

public struct StudyAnalyzer : IDataAnalysis
{
    public List<double> NormalizeReactionTimes(List<double> rawData)
    {
        double max = rawData.Max();
        double min = rawData.Min();
        List<double> result = new List<double>();

        foreach (var value in rawData)
        {
            double normalizedVal = (value - min) / (max - min);
            result.Add(normalizedVal);
        }

        return result;
    }

    public StudyData CompareParticipants(StudyData p1, StudyData p2)
    {
        if (p1.GetAccuracyRate() > p2.GetAccuracyRate())
        {
            return p1;
        }

        return p2;
    }
}