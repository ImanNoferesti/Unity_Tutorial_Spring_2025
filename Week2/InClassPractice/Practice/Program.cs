/* Problem #1
 * Create a program that manages a student's scores. 
 * Try adding a single score and multiple scores at once.
 * Display the total number of scores stored.
 * Check if a specific score exists.
 * Find the first score above a given threshold and all scores below a given threshold.
 * Remove the lowest score.
 * Clear all scores.
 */

// List<float> scores = new List<float>() { 45.5f, 50f, 90f };
//
// scores.Add(80f);
// scores.AddRange(new List<float>(){35f, 99f});
// scores.AddRange([100f, 35f]);
//
// Console.WriteLine($"Total: {scores.Count}");
//
// Console.WriteLine($"50 ? {scores.Contains(50f)}");
//
// float threshold = 60f;
//
// float firstScoreAbove = scores.Find(x => x > 60);
// Console.WriteLine($"Score above 60: {firstScoreAbove}");
//
// List<float> scoresBelowThreshold = scores.FindAll(x => x < 60);
// Console.WriteLine(string.Join(',', scoresBelowThreshold));
//
// scores.Sort();
// scores.RemoveAt(0);
//
// scores.Clear();

/* Problem #2
 * Create a program that manages a student gradebook, where each student's name is associated with their GPA.
 * Initialize the gradebook with some names and grades.
 * AddStudent: Adds a new student and their GPA to the gradebook. If the student already exists, display a message saying they are already added.
 * RemoveStudent: Removes a student from the gradebook if they exist.
 * PrintGradebook: Displays all student names and their GPAs.
 * ShowStatistics: Displays the total number of students.
 * ClearGradebook: Removes all students from the gradebook.
 */

// Dictionary<string, float> gradebook = new Dictionary<string, float>();
// string name;
// float gpa;
// int option = 0;
// string safeGuard = "I am sure that I want to delete all of the students";
//
// while (option != 6) 
// { 
//  Console.Write("Welcome to the gradebook system - Castillo Elementary" +
//                 "\nMenu option:" +
//                 "\n1. Add a student" +
//                 "\n2. Remove a student" +
//                 "\n3. All of the students with their names and GPAs" +
//                 "\n4. Show the total number of students" +
//                 "\n5. Remove all students from the gradebook" +
//                 "\n6. Exit");
//  Console.WriteLine("\nPlease enter an option below:");
//  option = int.Parse(Console.ReadLine());
//  switch (option)
//  {
//   case 1: // Add a student
//    Console.WriteLine("Please enter the name of the student to be added below:");
//    name = Console.ReadLine();
//
//    if (gradebook.ContainsKey(name))
//    {
//     Console.WriteLine("\n" +
//                       "\n" +
//                       $"\n{name} is already registered in the gradebook" +
//                       "\n" +
//                       "\n");
//    }
//    else
//    {
//     Console.WriteLine("Please enter the student's GPA below");
//     gpa = float.Parse(Console.ReadLine());
//     gradebook.Add(name,gpa);
//     Console.WriteLine("\n" +
//                       "\n" +
//                       $"\nYou have added {name} with a GPA of {gpa} to the gradebook" +
//                       "\n" +
//                       "\n");
//    }
//    break;
//   
//   case 2: // Remove a student
//    Console.WriteLine("Please enter the name of the student to be removed below:");
//    name = Console.ReadLine();
//    if (gradebook.ContainsKey(name))
//    {
//     gradebook.Remove(name);
//     
//     Console.WriteLine("\n" +
//                       "\n" +
//                       $"\nYou have removed {name} from the gradebook" +
//                       "\n" +
//                       "\n");
//    }
//    else
//    {
//     Console.WriteLine("\n" + 
//                       "\n" + 
//                       "\nThe student is not registered in the gradebook or" +
//                       "\nthe name is incorrect. Please try again or add the" +
//                       "\nstudent to gradebook" + 
//                       "\n" + 
//                       "\n");
//    }
//   break;
//   
//   case 3: // Displays all the students with their names and GPAs
//    
//    Console.WriteLine("Students currently registered in the gradebook with their GPAs" + 
//                      "\n" + 
//                      "\n" +
//                      "\n");
//    
//    foreach (KeyValuePair<string, float> kvp in gradebook)
//    {
//     Console.WriteLine($"{kvp.Key} - GPA: {kvp.Value}");
//    }
//    Console.WriteLine("\n" + 
//                      "\n" +
//                      "\n");
//    break;
//   
//   case 4: // Show a total of students in the gradebook
//    int totalStudents = gradebook.Count;
//    Console.WriteLine("\n" + 
//                      "\n" + 
//                      $"The total number of students registered in the gradebook is {totalStudents}" + 
//                      "\n" + 
//                      "\n");
//    break;
//   
//   case 5: // Remove all the students. This option contains a safeguard
//    Console.WriteLine("You are about to remove all the students from the gradebook records." +
//                      "\nPlease confirm by typing the following sentence below: I am sure that I want to delete all of the students");
//    string sentence = Console.ReadLine();
//    if (sentence == safeGuard)
//    {
//     gradebook.Clear();
//     Console.WriteLine("\n" + 
//                       "\n" + 
//                       $"You have removed all the students from the gradebook records." + 
//                       "\n" + 
//                       "\n");
//    }
//    else
//    {
//     Console.WriteLine("\n" + 
//                       "\n" + 
//                       $"The text does not match. Please try again." + 
//                       "\n" + 
//                       "\n");
//    }
//    break;
//   
//   case 6: // Exit the program
//    Console.WriteLine("\n" + 
//                      "\n" + 
//                      $"You have exited the gradebook management system. Good-bye!" + 
//                      "\n" + 
//                      "\n");
//    break;
//   
//   default: // Show invalid option message
//    Console.WriteLine("\n" + 
//                      "\n" + 
//                      "Invalid option number, please try again" + 
//                      "\n" + 
//                      "\n");
//    break;
//  }
// }


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

// Dictionary<int, string> chatRecord = new Dictionary<int, string>();
// string exitMessage = "No exit";
// string lastMessage = "";
// int counter = 1;
//
// while (lastMessage != "Take care!")
// {
//  Console.WriteLine("Write the message and click enter:");
//  lastMessage = Console.ReadLine();
//  if (counter != 6)
//  {
//   chatRecord.Add(counter, lastMessage);
//   counter++;
//   foreach (KeyValuePair<int, string> kvp in chatRecord)
//     {
//      Console.WriteLine($"{kvp.Value}");
//     }
//  }
//  else
//  {
//   chatRecord[1] = chatRecord[2];
//   chatRecord[2] = chatRecord[3];
//   chatRecord[3] = chatRecord[4];
//   chatRecord[4] = chatRecord[5];
//   
//   chatRecord[5] = lastMessage;
//   foreach (KeyValuePair<int, string> kvp in chatRecord)
//   {
//    Console.WriteLine($"{kvp.Value}");
//   }
//  }
//  
// }


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

// LinkedList<string> memoryWords = new LinkedList<string>(); // storing the words
// string lastWord = "Default"; // to keep memory of the last word
// int option = 0;
//
// while (option != 3)
// {
//  Console.WriteLine("Please enter 1 for adding a word, 2 for deleting the last word entered or 3 for closing the program");
//  option = int.Parse(Console.ReadLine());
//
//  switch (option)
//  {
//   case 1: // When adding a new word
//    Console.WriteLine("Please enter the word to be stored");
//    lastWord = Console.ReadLine();
//    memoryWords.AddLast(lastWord);
//    Console.WriteLine("\n");
//    foreach (var word in memoryWords)
//    {
//     Console.WriteLine(word);
//    }
//    Console.WriteLine("\n");
//    break;
//   case 2: // When undoing last action
//    memoryWords.RemoveLast();
//    Console.WriteLine("\n");
//    foreach (var word in memoryWords)
//    {
//     Console.WriteLine(word);
//    }
//    Console.WriteLine("\n");
//    break;
//   case 3: // Exiting
//    Console.WriteLine("You have closed the program. Good-bye!");
//    break;
//   
//   default:
//    Console.WriteLine("Invalid option, please try again.");
//    break;
//  }
//  
// }



/* Problem #5
 * Write a function that removes the smallest value from a given list of integers in place (modifying the original list).
 * Test your function
 */

// List<int> myListOfValues = new List<int>([5, 25, 29, 1, 3, 44, 2]);
//
// List<int> Sorting(List<int> list)
// {
//
//  list.Sort();
//  list.Remove(list[0]);
//  
//  return list;
// }
//
// Sorting(myListOfValues);
//
// Console.WriteLine(string.Join(", ", myListOfValues));


/* Problem #6
 * Write a function that takes an integer value and an array of integers, then returns how many times the given value appears in the array.
 */

// int[] countersList = new[] { 1, 2, 3, 4, 5, 5, 5, 3, 2, 2, 2, 2, 4 };
//
//
// void counterInteger(int[] lists, int target)
// {
//  int[] storing = Array.FindAll(lists, x => x == target);
//
//  int timesShow = 0;
//  timesShow = storing.Length;
//  Console.WriteLine(timesShow);
// }
//
// counterInteger(countersList, 2);


