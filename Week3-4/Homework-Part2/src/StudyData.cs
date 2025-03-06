namespace src;

public struct StudyData
{
    // fields

    public int SubID = 999;
    public int SubAge = 0;
    public List<int> RTs = new List<int>();
    public List<int> ErrFlags = new List<int>();
    public int TotalCnt;
    public int CorrCntt;
    public double MeanRT = 0;
    public double PercentCorrect = 0;
    public string SubjectReport = "No data";

    // Methods

    public StudyData(int id, int age, List<int> rts, List<int> efs)
    {
        SubID = id;
        SubAge = age;
        RTs = rts;
        ErrFlags = efs;
    }
    
    public double GetMeanRT(List<int> RTs)
    {
        int sumRTs = 0;
        int cnt = 0;
        for (int i = 0; i < RTs.Count; i++)
        {
            sumRTs = sumRTs + RTs[i];
            cnt++;
        }
        
        MeanRT = sumRTs / cnt;

        return MeanRT;
    }

    public double GetPercentCorrect(List<int> ErrFlags)
    {
        int totalCnt = ErrFlags.Count;
//        Console.WriteLine(totalCnt);
        List<int> temp = ErrFlags.FindAll(x => x == 1);
        int corrCnt = temp.Count;
//        Console.WriteLine(corrCnt);
        PercentCorrect = corrCnt / totalCnt;

//        Console.WriteLine($"{corrCnt}/{totalCnt} = {PercentCorrect}");
        return PercentCorrect;
    }

    public string GenerateReport()
    //
    {
        // convert SubID to string
        // convert MeanRT to string
        // convert PercentCorrect to String
        // concatenate those three into a string and assign to SubjectReport
        
        return SubjectReport;
    }
}