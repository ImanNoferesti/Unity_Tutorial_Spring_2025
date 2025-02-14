//
// //////////////////// Arrays /////////////////////////
//
// // Declaration
//
// using System.Security.Cryptography;
//
// int[] numbers;
// // Initialization
// numbers = new int [5]
// // Declaration and Initialization Together
// numbers = new int[] { 1, 2, 3, 4, 5 };
// int [] value = new int[] {1 ,2 ,3 ,4 ,5 };
// // Alternative Short Syntax
// int[] score = {5, 20, 2 };
// // Accessing and Modifying Elements
// value[1] = 10; // value array is now [1, 10, 3, 4, 5]
// // Get the size of an array
// Console.WriteLine(value.Length);
// // Sort scores
// Array.Sort(value);
// foreach (int val in value)
// {
//     Console.WriteLine(val);
// }
// // Copy the first 2 elements of scores to a new array
// int[] sco = new int[2];
// Array.Copy(score, sco, 2);
// Console.WriteLine(sco[0]);
// // Copy scores starting at index 1 in destinationArray
// int[] copyArray = new int[10];
// score.CopyTo(copyArray, 0);
// // Find the first even score 
// int firstEven = Array.Find(score, x => x % 2 == 0);
// // Find all scores greater than 10
// int[] allEven = Array.FindAll(score, x => x > 10);
// // Find the index of the first occurrence of the score 15.
// int first15 = Array.IndexOf(score, 15);
// Console.WriteLine(first15);
// // Find the index of the first occurrence of the score greater than 5
// int over5 = Array.FindIndex(score, x => x > 5);
// Console.WriteLine(over5);
// // Check whether score of 20 exists
// bool exists = Array.Exists(score, x => x == 20); // returns true
// // Clear the last two scores
// Array.Clear(score, 2, 2);
//
// //////////////////// Lists /////////////////////////
//
// // Declare and initialize a list
// List<int> numList = new List<int>() { 10, 20, 30, 40, 50 };
// // Accessing elements
// Console.WriteLine(numList[2]); // 30
// // Get the list capacity
// Console.WriteLine(numList.Capacity); // 8
// // Get the length (count) of elements in the list
// Console.WriteLine(numList.Count); // 5
// // Add values to the list
// numList.Add(60);
// numList.Add(70); 
// // Add a multiple values to the list at once
// numList.AddRange(new List<int>() {80, 90, 100, 120});
// // Check whether the list contains an element
// Console.WriteLine(numList.Contains(30)); // true
// // Insert 110 before the last element
// numList.Insert(numList.Count-1, 110);
// // Insert -20, -10, and 0 at the start of the list
// numList.InsertRange(0, new List<int>(){-20, -10, 0});
// // Remove the first occurrence of the value -20 from the list
// numList.Remove(-20);
// // Remove the value at index 0 from the list
// numList.RemoveAt(0); // removes - 10
// // Remove all elements greater than 50
// numList.RemoveAll(x => x > 50); // [0 ... 50]
// // Sort the list
// numList.Sort();
// // Convert the list into an array of the same type
// int[] copyList = numList.ToArray();
// // Copy the list values into an array of double size, starting from index 5
// int[] copyList2 = new int[numList.Count * 2];
// numList.CopyTo(copyList2, 5);
// // Check whether at least an odd value exists
// exists = numList.Exists(x => x % 2 != 0);
// // Find the first even score 
// firstEven = numList.Find(x => x % 2 == 0); // 0
// // Find all values greater than 10
// List<int> findAll = numList.FindAll(x => x > 10);
// // Find the index of the first occurrence of the value 10.
// index = numList.IndexOf(10); // 1
// // Find the index of the first occurrence of the value greater than 5
// index2 = numList.FindIndex(x => x > 5); // 1
// // Remove all elements from the list, making it empty
// numList.Clear();

// ////////////////// Dictionaries /////////////////////////
//
//  Declare and Initialize a dictionary
Dictionary<string, float> myDictionary = new Dictionary<string, float>()
{
    { "Alice", 3.5f },
    { "Bob", 4.0f }
};
// Add elements
myDictionary.Add("Jake", 2.65f);
myDictionary.Add("Taylor", 3.5f);
// Accessing a key and Modifying its value
myDictionary["Bob"] = 3.99f;
// Show the total number of students
Console.WriteLine(myDictionary.Count);
// Retrieve all keys
foreach (var key in myDictionary.Keys)
{
    Console.WriteLine(key);
}
// Retrieve all values
foreach (var value in myDictionary.Values)
{
    Console.WriteLine(value);
}
// Retrieve all key-value pairs
foreach (KeyValuePair<string, float> kvp in myDictionary)
{
    Console.WriteLine($"Key: {kvp.Key} | Value: {kvp.Value}");
}
// Check whether a key exists. If so, show its value
if (myDictionary.ContainsKey("Alice"))
{
    Console.WriteLine(myDictionary["Alice"]);
}
// Remove a key
myDictionary.Remove("Bob")
// Remove all keys and values
myDictionary.Clear();

// //////////////////// HashSets /////////////////////////
//
// // Declare and Initialize a HashSet
// HashSet<int> mySet = new HashSet<int>(){1, 2, 3};
// // Add elements
// mySet.Add(4);
// // Remove an element
// mySet.Remove(3);
// // Check if an element exists
// bool contains2 = mySet.Contains(3);
// // Iterate through hashset
// foreach (var item in mySet)
// {
//     Console.WriteLine(item); // {1, 2, 4}
// }
// // Copy all elements into an array
// int[] newArray = new int[mySet.Count];
// mySet.CopyTo(newArray);
// // Remove all elements in the HashSet
// mySet.Clear();
// // Combine two sets 
// HashSet<int> setA = new HashSet<int>() { 1, 2, 3 };
// HashSet<int> setB = new HashSet<int>() { 3, 4, 5 };
// setA.UnionWith(setB);
// Console.WriteLine(string.Join(",", setA));
// // Intersect two sets
// setA = new HashSet<int>() { 1, 2, 3 };
// setA.IntersectWith(setB);
// Console.WriteLine(String.Join(",",setA)); // {3}
// // Difference between two sets
// setA = new HashSet<int>() { 1, 2, 3 };
// setA.ExceptWith(setB); 
// Console.WriteLine(String.Join(",",setA));// {1, 2}
// // Symmetric Difference between two sets (elements that are only in one)
// setA = new HashSet<int>() { 1, 2, 3 };
// setA.SymmetricExceptWith(setB); 
// Console.WriteLine(String.Join(",",setA));// {1, 2, 4, 5}

//////////////////// LinkedList /////////////////////////

// Declare and Initialize a LinkedList
LinkedList<int> myLinkedList = new LinkedList<int>([1, 3, 4, 5]);
// Count the number of items in the list
Console.WriteLine(myLinkedList.Count);
// Add 0 at the beginning of the list
myLinkedList.AddFirst(0); // {0,1,3,4,5}
// Add 8 and 10 at the end of the list
myLinkedList.AddLast(8); // {0,1,3,4,5,8}
myLinkedList.AddLast(10); // {0,1,3,4,5,8,10}
// Find the first node equal to 3
LinkedListNode<int> node = myLinkedList.Find(3);
Console.WriteLine(node.Value);
// Put a 2 in the list right before the 3
myLinkedList.AddBefore(node, new LinkedListNode<int>(2)); // {0,1,2,3,4,5,8,10}
Console.WriteLine(string.Join(",", myLinkedList));

// Add another 2 to the list right after the 1
LinkedListNode<int> newNode = new LinkedListNode<int>(2);
LinkedListNode<int> nodeOne = myLinkedList.Find(1);
myLinkedList.AddAfter(nodeOne, 2); //or replace 2 with newNode
Console.WriteLine(string.Join(",", myLinkedList)); // {0,1,2,2,3,4,5,8,10}
// Check whether 5 is in the list
Console.WriteLine(myLinkedList.Contains(5)); // True
// Remove the first and last values in the list
myLinkedList.RemoveFirst();
myLinkedList.RemoveLast(); // {1,2,2,3,4,5,8}
// Return the first(Head) and last(Tail) node of the list
LinkedListNode<int> head = myLinkedList.First; // 1
LinkedListNode<int> tail = myLinkedList.Last;  // 8
// Return the value of the node right after the head node
int headVal = head.Next.Value; //2
// Remove the first occurrence of 2
myLinkedList.Remove(myLinkedList.Find(2)); // {1,2,3,4,5,8}
// Copy the entire list to an array
int[] newArray2 = new int[myLinkedList.Count];
myLinkedList.CopyTo(newArray2, 0);
// Remove all values in the list
myLinkedList.Clear();


//////////////////// Stack /////////////////////////

// Declare and Initialize a stack

// Get the number of elements in the stack

// check if 5 exists in the stack

// Return the top element in the stack

// Remove and return the top element in the stack

// Add 5 to the stack

// Convert the current stack into an array 

// Copy elements of current stack into a new array

// Remove all elements from the stack

//////////////////// Queue /////////////////////////

// Declare and initialize a queue

// Get the number of elements in the queue

// check if 5 exists in the queue

// Return the element at the front of the queue

// Remove and return the element at the front of the queue

// Add 5 to the queue

// Convert the current queue into an array 

// Copy elements of current queue into a new array

// Remove all elements from the queue



//////////////////// Functions /////////////////////////

// Write a function that takes two integers and return their sum.
// Then, call the function


// Write a void function that prints messages on console


// Write a function that greet users with an optional parameter
