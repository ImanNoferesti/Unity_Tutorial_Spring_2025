namespace Homework_Part2_Solution.Medium;

public interface IDataAnalysis
{
    List<double> NormalizeReactionTimes(List<double> rawData);
    StudyData CompareParticipants(StudyData p1, StudyData p2);
}