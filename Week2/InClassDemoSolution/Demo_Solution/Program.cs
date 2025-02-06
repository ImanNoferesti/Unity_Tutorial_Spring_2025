
//////////////////// Arrays /////////////////////////

// Declaration

using System.Diagnostics;

int[] numbers;

// Initialization
numbers = new int [5];
// Declaration and Initialization Together
numbers = new int[] { 1, 2, 3 };
int[] value = new int[] { 1, 2, 3, 4, 5 };
// Alternative Short Syntax
int[] score = { 5, 20, 10, 15 };
// Accessing and Modifying Elements
value[1] = 10; // value = [1, 10, 3, 4, 5]
// Get the size of an array
Console.WriteLine(value.Length);
// Sort scores
Array.Sort(score);
foreach (int val in score)
{
    Console.WriteLine(val);
}
// Copy the first 2 elements of scores to a new array
int[] copyArr = new int[2];
Array.Copy(score, copyArr, 2); // [5,10]
// Copy scores starting at index 1 in destinationArray
int[] copyArr2 = new int[10];
score.CopyTo(copyArr2, 1); // [0, 5, 10, 15, 20, 0 ,0 ...]
// Find the first even score 
int firstEven = Array.Find(score, x => x % 2 == 0); // 10
// Find all scores greater than 10
int[] matches = Array.FindAll(score, x => x > 10); // 15, 20
// Find the index of the first occurrence of the score 15.
int index = Array.IndexOf(score, 15); // 2
// Find the index of the first occurrence of the score greater than 5
int index2 = Array.FindIndex(score, x => x > 5); // 1
// Check whether score of 20 exists
bool exists = Array.Exists(score, x => x == 20); // true
// Clear the last two scores
Array.Clear(score, 2, 2); // score = [5, 10, 0, 0]


//////////////////// Lists /////////////////////////

// Declare and initialize a list
List<int> numList = new List<int>() { 10, 20, 30, 40, 50 };
// Accessing elements
Console.WriteLine(numList[2]); // 30
// Get the list capacity
Console.WriteLine(numList.Capacity); // 8
// Get the length (count) of elements in the list
Console.WriteLine(numList.Count); // 5
// Add values to the list
numList.Add(60);
numList.Add(70); 
// Add a multiple values to the list at once
numList.AddRange(new List<int>() {80, 90, 100, 120});
// Check whether the list contains an element
Console.WriteLine(numList.Contains(30)); // true
// Insert 110 before the last element
numList.Insert(numList.Count-1, 110);
// Insert -20, -10, and 0 at the start of the list
numList.InsertRange(0, new List<int>(){-20, -10, 0});
// Remove the first occurrence of the value -20 from the list
numList.Remove(-20);
// Remove the value at index 0 from the list
numList.RemoveAt(0); // removes - 10
// Remove all elements greater than 50
numList.RemoveAll(x => x > 50); // [0 ... 50]
// Sort the list
numList.Sort();
// Convert the list into an array of the same type
int[] copyList = numList.ToArray();
// Copy the list values into an array of double size, starting from index 5
int[] copyList2 = new int[numList.Count * 2];
numList.CopyTo(copyList2, 5);
// Check whether at least an odd value exists
exists = numList.Exists(x => x % 2 != 0);
// Find the first even score 
firstEven = numList.Find(x => x % 2 == 0); // 0
// Find all values greater than 10
List<int> findAll = numList.FindAll(x => x > 10);
// Find the index of the first occurrence of the value 10.
index = numList.IndexOf(10); // 1
// Find the index of the first occurrence of the value greater than 5
index2 = numList.FindIndex(x => x > 5); // 1
// Remove all elements from the list, making it empty
numList.Clear();

//////////////////// Dictionaries /////////////////////////

// Declare and Initialize a dictionary

// Add elements

// Accessing a key and Modifying its value

// Show the total number of students

// Retrieve all keys

// Retrieve all values

// Retrieve all key-value pairs

// Check whether a key exists. If so, show its value

// Remove a key

// Remove all keys and values


//////////////////// HashSets /////////////////////////

// Declare and Initialize a HashSet

// Add elements

// Remove an element

// Check if an element exists

// Iterate through hashset

// Copy all elements into an array

// Remove all elements in the HashSet

// Combine two sets 

// Intersect two sets

// Difference between two sets

// Symmetric Difference between two sets (elements that are only in one)


//////////////////// Functions /////////////////////////

// Write a function that takes two integers and return their sum.
// Then, call the function


// Write a void function that prints messages on console


// Write a function that greet users with an optional parameter
