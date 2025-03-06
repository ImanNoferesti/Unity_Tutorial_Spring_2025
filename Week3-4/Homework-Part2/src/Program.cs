using src;

List<int> s1RTData = new List<int>() { 450, 360, 400, 520 };
List<int> s1ErrData = new List<int>() { 1, 1, 1, 0 };
List<int> s2RTData = new List<int>() { 460, 660, 540, 620 };
List<int> s2ErrData = new List<int>() { 0, 1, 0, 1 };
    
StudyData sub01 = new StudyData(1, 21,s1RTData, s1ErrData);
Console.WriteLine(string.Join(',', sub01.RTs));
Console.WriteLine(string.Join(',', sub01.ErrFlags));

StudyData sub02 = new StudyData(1, 21,s2RTData, s2ErrData);
Console.WriteLine(string.Join(',', sub02.RTs));
Console.WriteLine(string.Join(',', sub02.ErrFlags));

sub01.GetMeanRT(sub01.RTs);
Console.WriteLine($"{sub01.MeanRT}");
sub01.GetPercentCorrect(sub01.ErrFlags); 
Console.WriteLine($"{sub01.PercentCorrect}");

sub01.GenerateReport();
Console.WriteLine(sub01.SubjectReport);
