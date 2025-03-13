namespace Homework_Part2_Solution.Medium;

public struct StudyData
{
    // Fields
    public int ParticipantId { get; set; }
    public int Age { get; set; }
    public List<double> ReactionTimes { get; set; }
    public double CorrectResponses { get; set; }

    private double _totalResponses;
    // Constructor
    public StudyData(int participantId, int age, List<double> reactionTimes, int correctResponses)
    {
        this.ParticipantId = participantId;
        this.Age = age;
        this.ReactionTimes = reactionTimes;
        this.CorrectResponses = correctResponses;
        this._totalResponses = this.ReactionTimes.Count;
    }
    
    // Methods
    public double GetMeanReactionTime()
    {
        double sum = 0;
        foreach (var value in this.ReactionTimes)
        {
            sum += value;
        }

        return sum / this._totalResponses;
    }

    public double GetAccuracyRate()
    {
        return this.CorrectResponses / this._totalResponses * 100;
    }

    public string GenerateReport()
    {
        return $"Summary: \n" +
               $"Participant Id={this.ParticipantId}\n" +
               $"Age={this.Age}\n" +
               $"Reaction Times=[{string.Join(',', this.ReactionTimes)}]\n" +
               $"Correct Responses={this.CorrectResponses}\n" +
               $"Total Responses={this._totalResponses}";
    }
    
    // Overloaded methods
    public static bool operator >(StudyData p1, StudyData p2)
    {
        return p1.GetAccuracyRate() > p2.GetAccuracyRate();
    }

    public static bool operator <(StudyData p1, StudyData p2)
    {
        return p1.GetAccuracyRate() < p2.GetAccuracyRate();
    }
    
}