using Homework_Part2_Solution.Medium;
using Homework_Part2_Solution.Hard;


// **************** Medium Problem ****************
Console.WriteLine("**************** Medium Problem ****************\n");

// Create instances of StudyData with sample participant data.
StudyData participant1 = new StudyData(1234, 22, new List<double>() { 22.3, 33.2, 21, 44.12 }, 2);
StudyData participant2 =  new StudyData(4213, 19, new List<double>() { 54.3, 23.23, 11, 14.16, 33, 5.9 }, 4);

// Call GetMeanReactionTime(), GetAccuracyRate(), and GenerateReport().
Console.WriteLine($"Participant1 Mean Reaction Time: {participant1.GetMeanReactionTime()} ");
Console.WriteLine($"Participant1 Accuracy Rate: {participant1.GetAccuracyRate()}%");
Console.WriteLine(participant1.GenerateReport() + "\n");


// Use StudyAnalyzer to normalize reaction times and compare participants.
List<double> normalizedRT = new List<double>();
StudyAnalyzer studyAnalyzer = new StudyAnalyzer();
normalizedRT = studyAnalyzer.NormalizeReactionTimes(participant1.ReactionTimes);
Console.WriteLine($"Participant1 Normalized Reaction Times: [{string.Join(',', normalizedRT)}]");
Console.WriteLine($"Participant with a better accuracy:\n" +
                  $"{studyAnalyzer.CompareParticipants(participant1, participant2).GenerateReport()}\n");

// Use operator overloading to determine who performed better.
Console.WriteLine($"Did participant1 perform better than participant2: {participant1 > participant2}");







// **************** Hard Problem ****************
Console.WriteLine("\n\n**************** Hard Problem ****************\n");

// Creating cognitive study participants
CognitiveStudyParticipant cog1 = new CognitiveStudyParticipant(1, "Alice", 25, 80);
CognitiveStudyParticipant cog2 = new CognitiveStudyParticipant(2, "Bob", 30, 90);

// Creating physical study participants
PhysicalStudyParticipant phy1 = new PhysicalStudyParticipant(3, "Charlie", 28, 0.5f);
PhysicalStudyParticipant phy2 = new PhysicalStudyParticipant(4, "David", 35, 0.7f);

// Display participant details
cog1.DisplayInfo();
cog2.DisplayInfo();
phy1.DisplayInfo();
phy2.DisplayInfo();

// Compare performance using operator overloading
Console.WriteLine("\nPerformance Comparison:");
Console.WriteLine($"Is Alice better than Bob? {cog1 > cog2}");
Console.WriteLine($"Is Charlie better than David? {phy1 > phy2}");

// Combining two cognitive study participants
Console.WriteLine("\nCombining Cognitive Participants:");
CognitiveStudyParticipant combined = cog1 + cog2;
combined.DisplayInfo();

// Retrieve study type
Console.WriteLine("\nStudy Types:");
Console.WriteLine($"Alice is in {cog1.StudyType()}");
Console.WriteLine($"David is in {phy2.StudyType()}");

