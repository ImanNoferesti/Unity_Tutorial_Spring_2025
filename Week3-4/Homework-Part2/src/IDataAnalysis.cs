namespace src;

public interface IDataAnalysis
{
    List<double> NormalizeReactionTimes(StudyData rawData);

    StudyData CompareParticipants(StudyData sub01, StudyData sub02);
}