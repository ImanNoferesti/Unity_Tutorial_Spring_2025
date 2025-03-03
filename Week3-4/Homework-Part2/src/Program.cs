using src.ParticipantDirectory;

// StudyData participant1 = new StudyData(01, 19);
// participant1.ReactionTimes.AddRange(.532, .431, .678, .512);
// participant1.TotalResponses = 4;
// participant1.CorrectResponses = 3;
// Console.WriteLine(participant1.GetAccuracyRate());
// Console.WriteLine($"Participant number: {participant1.ParticipantID} Participant age: {participant1.Age}");
// Console.WriteLine($"Participant {participant1.ParticipantID} Reaction Times: {string.Join(", ", participant1.ReactionTimes)}");
// Console.WriteLine($"Participant {participant1.ParticipantID} Mean Reaction Time: {participant1.GetMeanReactionTime()}");
// Console.WriteLine(participant1.GenerateReport());

StudyAnalyzer newPerson = new StudyAnalyzer();
List<double> rawData = new List<double>([.111,.333,.444,.555,.666,.999]);
Console.WriteLine(String.Join(",", newPerson.NormalizeReactionTimes(rawData)));