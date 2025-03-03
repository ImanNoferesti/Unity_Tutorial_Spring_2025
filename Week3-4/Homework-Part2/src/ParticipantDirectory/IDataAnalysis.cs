namespace src.ParticipantDirectory;

public interface IDataAnalysis
{
    public List<double> NormalizeReactionTimes(List<double> rawData);

    public int CompareParticipants(StudyData a, StudyData b);
}