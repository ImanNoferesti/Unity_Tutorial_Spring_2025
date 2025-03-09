using src;

List<int> s1RTData = new List<int>() { 550, 600, 490, 520, 650, 540 };
List<int> s1ErrData = new List<int>() { 1, 1, 1, 0, 1, 0 };
List<int> s2RTData = new List<int>() { 460, 380, 420, 500, 510, 420 };
List<int> s2ErrData = new List<int>() { 0, 1, 0, 1 , 0, 0};
    
StudyData sub01 = new StudyData(1, 21,s1RTData, s1ErrData);
// Console.WriteLine(string.Join(',', sub01.RTs));
// Console.WriteLine(string.Join(',', sub01.ErrFlags));

StudyData sub02 = new StudyData(1, 21,s2RTData, s2ErrData);
// Console.WriteLine(string.Join(',', sub02.RTs));
// Console.WriteLine(string.Join(',', sub02.ErrFlags));

sub01.GetMeanRT(sub01.RTs);
sub01.GetPercentCorrect(sub01.ErrFlags);

sub02.GetMeanRT(sub02.RTs);
sub02.GetPercentCorrect(sub02.ErrFlags);

Console.WriteLine($"Sub 01: MeanRT = {sub01.MeanRT}, Percent Correct = {sub01.PercentCorrect}");
Console.WriteLine($"Sub 01: MeanRT = {sub02.MeanRT}, Percent Correct = {sub02.PercentCorrect}");

NormalizeReactionTimes(sub01);
NormalizeReactionTimes(sub01);
CompareParticipants(sub01, sub02);

// sub01.GenerateReport();
// Console.WriteLine(sub01.SubjectReport);
