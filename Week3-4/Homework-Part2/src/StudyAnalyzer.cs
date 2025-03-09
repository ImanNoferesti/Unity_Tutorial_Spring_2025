namespace src;

public struct StudyAnalyzer : IDataAnalysis
{
    
    //Methods
    public List<double> NormalizeReactionTimes(StudyData rawData)
    {
        List<double> normedRTs = new List<double>();
        int maxRT = rawData.RTs.Max();
        int minRT = rawData.RTs.Min();
        
        for (int i = 0; i > rawData.RTs.Count)
        {
            normedRTs[i] = (rawData.RTs[i] - minRT) / (maxRT - minRT);
        }
        return normedRTs;
        
    }
    
    public StudyData CompareParticipants(StudyData sub01, StudyData sub02)
    {
        StudyData higherPerformer = new StudyData();
        double s1PC = sub01.GetPercentCorrect(sub01.ErrFlags);
        double s2PC = sub02.GetPercentCorrect(sub02.ErrFlags);

        if (s1PC > s2PC)
        { 
            higherPerformer.SubID = sub01.SubID; 
            higherPerformer.SubAge = sub01.SubAge; 
            higherPerformer.RTs = sub01.RTs; 
            higherPerformer.ErrFlags = sub01.ErrFlags; 
            higherPerformer.RTs = sub01.MeanRT; 
            higherPerformer.PercentCorrect = sub01.PercentCorrect; 
            higherPerformer.SubjectReport = sub01.SubjectReport; 
        }
        else if (s2PC > s1PC)
        { 
            higherPerformer.SubID = sub02.SubID; 
            higherPerformer.SubAge = sub02.SubAge; 
            higherPerformer.RTs = sub02.RTs; 
            higherPerformer.ErrFlags = sub02.ErrFlags; 
            higherPerformer.RTs = sub02.MeanRT; 
            higherPerformer.PercentCorrect = sub02.PercentCorrect; 
            higherPerformer.SubjectReport = sub02.SubjectReport
        }
        else 
        { 
            Console.WriteLine("Neither subject performed better than the other.") 
        } 
        
        return higherPerformer;

    }
    
    
    
}