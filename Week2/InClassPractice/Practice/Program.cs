/* Problem #1
 * Create a program that manages a student's scores. 
 * Try adding a single score and multiple scores at once.
 * Display the total number of scores stored.
 * Check if a specific score exists.
 * Find the first score above a given threshold and all scores below a given threshold.
 * Remove the lowest score.
 * Clear all scores.
 */

using System.Runtime.InteropServices.JavaScript;
using System.Text.Json.Serialization;


List<float> gradeList = new List<float>() { 1.4f, 2.2f, 3.2f };
gradeList.Add(1.3f);
gradeList.AddRange([1.2f, 3.3f]);
Console.WriteLine(gradeList.Count());
gradeList.Contains(1.3f); //false
gradeList.Sort();
gradeList.FindAll(x => x > 3.0f);
gradeList.Find(x => x < 3.0f);
gradeList.RemoveAt(0);
Console.WriteLine(String.Join(",", gradeList));
gradeList.Clear();

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
    { "Brock", 3.2f},
    {"Alice", 3.75f},
    {"John", 2.2f}
};
gradebook.Add("Jason", 3.4f);
gradebook.Remove("Brock");




 
 
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
List<int> sampleList = new List<int>([3,2,4,6]);
void RemoveFirst(List<int> inList)
{
    inList.Sort();
    inList.RemoveAt(0);
}
Console.WriteLine(String.Join(",",sampleList));
RemoveFirst(sampleList);
Console.WriteLine(String.Join(",",sampleList));


/* Problem #6
 * Write a function that takes an integer value and an array of integers, then returns how many times the given value appears in the array.
 */
int[] exampleArray = new int[] {};
int ReturnsCount(int value, int[] exampleArray)
{
    int[] countArray = new int[] { };
    countArray = Array.FindAll(exampleArray, x => x == value);
    return countArray.Length;
}

Console.WriteLine(ReturnsCount(3, [1, 3, 4, 5, 6, 3, 3]));

