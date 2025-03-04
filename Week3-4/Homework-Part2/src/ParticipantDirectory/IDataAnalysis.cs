namespace src.ParticipantDirectory;

public interface IDataAnalysis
{
    public List<double> NormalizeReactionTimes(List<double> rawData);

    public StudyData CompareParticipants(StudyData p1, StudyData p2);
}