using src.ParticipantDirectory;
using src.StudyManagementSystem;

// ***** MEDIUM PROBLEM *****
//
// StudyData participant1 = new StudyData(01, 19);
// StudyData participant2 = new StudyData(02, 23);
// participant1.ReactionTimes.AddRange(.532, .431, .678, .512);
// participant1.TotalResponses = 4;
// participant1.CorrectResponses = 3;
// participant2.ReactionTimes.AddRange(.511, .422, .543, .514);
// participant2.TotalResponses = 4;
// participant2.CorrectResponses = 4;
// Console.WriteLine(participant1.GetAccuracyRate());
// Console.WriteLine($"Participant number: {participant1.ParticipantID} Participant age: {participant1.Age}");
// Console.WriteLine($"Participant {participant1.ParticipantID} Reaction Times: {string.Join(", ", participant1.ReactionTimes)}");
// Console.WriteLine($"Participant {participant1.ParticipantID} Mean Reaction Time: {participant1.GetMeanReactionTime()}");
// Console.WriteLine(participant1.GenerateReport());
//
// StudyAnalyzer newParticipant = new StudyAnalyzer();
// Console.WriteLine(String.Join(",",newParticipant.NormalizeReactionTimes(participant1.ReactionTimes)));
// StudyData betterParticipant = newParticipant.CompareParticipants(participant1, participant2);
// Console.WriteLine(betterParticipant.ParticipantID);
// Console.WriteLine(participant1 > participant2);

// ***** HARD PROBLEM *****
CognitiveStudy p1 = new CognitiveStudy(01, "John", 20);
CognitiveStudy p2 = new CognitiveStudy(02, "Jill", 19);
Console.WriteLine(p1.GetDetails());
p1.SetScore(90);
Console.WriteLine(p1.Performance());
