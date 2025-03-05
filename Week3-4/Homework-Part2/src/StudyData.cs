namespace src;

public struct StudyData
{
    // fields

    public int SubID = 999;
    public int SubAge = 0;
    public List<int> RTs = new List<int>() { 200, 400, 300, 200 };
    public int TotalCnt = RTs.Count;
    public int CorrCnt = TotalCnt;

    // Methods

    public StudyData()
    {
        
    }
    
    public double GetMeanRT(List<int> RTs)
    {
        double mnRT;
        
        int sumRTs = 0;
        int cnt = 0;
        for (int i = 0; i < RTs.Count; i++)
        {
            sumRTs = sumRTs + RTs[i];
            cnt++;
        }

        mnRT = sumRTs / cnt;

        return mnRT;
    }

    public double GetPerCorr(int totalCnt, int corrCnt)
    {
        
    }

    public void GenerateReport()
    {
        

    }
}