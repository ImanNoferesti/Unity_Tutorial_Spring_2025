/* Problem #1
 * Create a program that manages a student's scores. 
 * Try adding a single score and multiple scores at once.
 * Display the total number of scores stored.
 * Check if a specific score exists.
 * Find the first score above a given threshold and all scores below a given threshold.
 * Remove the lowest score.
 * Clear all scores.
 */

List<int> studentScores = new List<int> { 85 };
studentScores.AddRange(new List<int>(){85, 49, 90});
studentScores.AddRange([53, 100, 87]);

Console.WriteLine($"Total # of scores: {studentScores.Count}");

Console.WriteLine($"100? {studentScores.Contains(100)}");

int threshold = 50;
int firstScoreAbove = studentScores.Find(x => x > 50);
Console.WriteLine($"Score above 50: {firstScoreAbove}");

List<int> scoresBelow = studentScores.FindAll(x => x < 50);
Console.WriteLine(string.Join(',' scoresBelow));

studentScores.Sort();
studentScores.RemoveAt(0);
Console.WriteLine(string.Join(',', studentScores));

studentScores.Clear();

/* Problem #2
 * Create a program that manages a student gradebook, where each student's name is associated with their GPA.
 * Initialize the gradebook with some names and grades.
 * AddStudent: Adds a new student and their GPA to the gradebook. If the student already exists, display a message saying they are already added.
 * RemoveStudent: Removes a student from the gradebook if they exist.
 * PrintGradebook: Displays all student names and their GPAs.
 * ShowStatistics: Displays the total number of students.
 * ClearGradebook: Removes all students from the gradebook.
 */

Dictionary<string, float> gradebook = new Dictionary<string, float>()
{
 { "Margaret", 3.7f },
 { "Robin", 3.2f },
 { "Sam", 3.5f }
};

Console.WriteLine("Please select an option (1 - 5: ");


gradebook.Add("Anya", 5.5f);

gradebook.Remove("Sam");





 
 
/* Problem #3
 * You are managing a messaging system that stores only the last 5 messages sent.
 * If a new message is added beyond this limit, the oldest message is automatically removed.
 * Task:
 * 1. Initialize a collection with no messages.
 * 2. Add the following messages in order:
         "Hello"
         "How are you?"
         "What's up?"
         "Good morning"
         "Have a great day!"
         "See you later!" (This should remove "Hello")
         "Take care!" (This should remove "How are you?")
 * 3. Print all stored messages after each addition.
 */






/* Problem #4
 * You are implementing an undo feature for a text editor.
 * Words are stored as they are added, but when an undo action occurs, the last added word is removed.
 * Task:
 * 1. Initialize a collection with no words.
 * 2. Add the following words in order:
     "Apple"
     "Banana"
     "Cherry"
     "Date"
 * 3. Perform three undo actions, each removing the most recently added word.
 * 4. Print the stored words after each undo.
 */







/* Problem #5
 * Write a function that removes the smallest value from a given list of integers in place (modifying the original list).
 * Test your function
 */





/* Problem #6
 * Write a function that takes an integer value and an array of integers, then returns how many times the given value appears in the array.
 */



