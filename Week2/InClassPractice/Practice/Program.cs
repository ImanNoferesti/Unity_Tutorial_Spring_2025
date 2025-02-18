/* Problem #1
 * Create a program that manages a student's scores. 
 * Try adding a single score and multiple scores at once.
 * Display the total number of scores stored.
 * Check if a specific score exists.
 * Find the first score above a given threshold and all scores below a given threshold.
 * Remove the lowest score.
 * Clear all scores.
 */

list<int> scores = new list<int>() {5, 10, 15, 20};
scores.Add(20);
scores.AddRange(new list<int>() {10, 20, 20});
Console.WriteLine(scores.Count); //9
Console.WriteLine(scores.Contains(20)); //true
Console.WriteLine(scores.Find(x => x > 10)); //15
Console.WriteLine(scores.FindAll(x => x < 10)); //5, 10, 10, 10
Console.WriteLine(scores.Remove(scores.Min())); //5
Console.WriteLine(scores.Clear()); //0



/* Problem #2
 * Create a program that manages a student gradebook, where each student's name is associated with their GPA.
 * Initialize the gradebook with some names and grades.
 * AddStudent: Adds a new student and their GPA to the gradebook. If the student already exists, display a message saying they are already added.
 * RemoveStudent: Removes a student from the gradebook if they exist.
 * PrintGradebook: Displays all student names and their GPAs.
 * ShowStatistics: Displays the total number of students.
 * ClearGradebook: Removes all students from the gradebook.
 */

Dictionary<string, float> gradebook = new Dictionary<string, double>() {{"Mike", 3.5f}, {"Iman", 4.0f}};
gradebook.Add("Cathleen", 4.0f);
if (gradebook.ContainsKey("Mike")) Console.WriteLine("Already added");
gradebook.Remove("Mike");

foreach (var student in gradebook){
    Console.WriteLine($"{student.Key}: {student.Value}");
}

Console.WriteLine(gradebook.Count);
gradebook.Clear();
 




 
 
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

Queue<string> messages = new Queue<string>();

while (messages.Count <= 5){
    messages.Dequeue();
    Console.WriteLine($"Newly Added Item: {messages.peek()}")
    Console.WriteLine($"Full List of stored messages: {messages}");
}

messages.Enqueue("Hello");
messages.Enqueue("How are you?");
messages.Enqueue("What's up?");
messages.Enqueue("Good morning");
messages.Enqueue("Have a great day!");
messages.Enqueue("See you later!");
messages.Enqueue("Take care!");





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

Stack<string> undoWords = new Stack<string>();

string Undo(){
    return undoWords.Pop();
}

undoWords.Push("Apple");
undoWords.Push("Banana");
undoWords.Push("Cherry");
undoWords.Push("Date");

Undo();
Console.WriteLine($"Full List of stored words: {undoWords}");
Undo();
Console.WriteLine($"Full List of stored words: {undoWords}");
Undo();
Console.WriteLine($"Full List of stored words: {undoWords}");




/* Problem #5
 * Write a function that removes the smallest value from a given list of integers in place (modifying the original list).
 * Test your function
 */

void RemoveSmallValue(List<int> numbers){
    if (numbers.Count == 0) return; 
    int minValue = numbers.Min();
    numbers.Remove(minValue);
}

RemoveSmallValue(new List<int>() {5, 10, 15, 20}); //5
Console.WriteLine(numbers); //10, 15, 20



/* Problem #6
 * Write a function that takes an integer value and an array of integers, then returns how many times the given value appears in the array.
 */



