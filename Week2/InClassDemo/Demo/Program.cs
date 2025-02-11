
//////////////////// Arrays /////////////////////////

// Declaration
int[] numbers;
// Initialization
numbers = new int [5]
// Declaration and Initialization Together
numbers = new int[] { 1, 2, 3, 4, 5 };
int [] value = new int[] {1 ,2 ,3 ,4 ,5 };
// Alternative Short Syntax
int[] score = {5, 20, 2 };
// Accessing and Modifying Elements
value[1] = 10; // value array is now [1, 10, 3, 4, 5]
// Get the size of an array
Console.WriteLine(value.Length);
// Sort scores
Array.Sort(value);
foreach (int val in value)
{
    Console.WriteLine(val);
}
// Copy the first 2 elements of scores to a new array
int[] sco = new int[2];
Array.Copy(score, sco, 2);
Console.WriteLine(sco[0]);
// Copy scores starting at index 1 in destinationArray
int[] copyArray = new int[10];
score.CopyTo(copyArray, 0);
// Find the first even score 
int firstEven = Array.Find(score, x => x % 2 == 0);
// Find all scores greater than 10
int[] allEven = Array.FindAll(score, x => x > 10);
// Find the index of the first occurrence of the score 15.
int first15 = Array.IndexOf(score, 15);
Console.WriteLine(first15);
// Find the index of the first occurrence of the score greater than 5
int over5 = Array.FindIndex(score, x => x > 5);
Console.WriteLine(over5);
// Check whether score of 20 exists
bool exists = Array.Exists(score, x => x == 20); // returns true
// Clear the last two scores
Array.Clear(score, 2, 2);

//////////////////// Lists /////////////////////////

// Declare and initialize a list

// Accessing elements

// Get the list capacity

// Get the length (count) of elements in the list

// Add values to the list

// Add a multiple values to the list at once

// Check whether the list contains an element

// Insert 110 before the last element

// Insert -20, 10, and 0 at the start of the list

// Remove the first occurrence of the value -20 from the list

// Remove the value at index 0 from the list

// Remove all elements greater than 50

// Sort the list

// Convert the list into an array of the same type

// Copy the list values into an array of double size, starting from index 5

// Check whether at least an odd value exists

// Find the first even score 

// Find all values greater than 10

// Find the index of the first occurrence of the value 15.

// Find the index of the first occurrence of the value greater than 5

// Remove all elements from the list, making it empty


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
