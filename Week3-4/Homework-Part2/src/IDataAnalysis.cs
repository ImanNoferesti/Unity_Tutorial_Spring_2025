namespace src;

public interface IDataAnalysis
{
    List<double> NormalizeReactionTimes(List<double> rawData);

    StudyData CompareParticipants();
}