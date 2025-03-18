
//////////////////// Arrays /////////////////////////

// Declaration

using System.Reflection;

int[] numbers;

// Initialization

numbers = new int [5]; // This creates a new array with five int elements and all are set to zero.

// Declaration and Initialization Together

numbers = new int[] { 1, 2, 3 }; // this initializes the array with actual values 1, 2, and 3.

int[] value = new int[] { 1, 2, 3, 4, 5 };


// Alternative Short Syntax

int[] score = { 5, 20, 10, 15 }; 

// Accessing and Modifying Elements

value[1] = 10; // the value array looks like [1, 10, 3, 4, 5]

// Get the size of an array

Console.Write(value.Length);

// Sort scores

Array.Sort(score);

foreach (int val in score)  // To print each element of the array
{
    Console.WriteLine(val);
}

// Copy the first 2 elements of scores to a new array

int[] copyArr = new int[2];
Array.Copy(score, copyArr, 2); // New array contains [5, 10]

// Copy scores starting at index 1 in destinationArray

// We need to create a new array
int[] copyArr2 = new int[10];

score.CopyTo(copyArr2, 1); // It copies the old array to the new array starting at the index you chose
                                // the rest of the slots in the new array are automatically set to zero.

// Find the first even score 

int firstEven = Array.Find(score, x => x % 2 == 0); // It is similar to a for loop doing an operation for
                                                             // each item in the array. It returns 10

// Find all scores greater than 10

int[] matches = Array.FindAll(score, x => x > 10); // Results in an array with 15, and 20

// Find the index of the first occurrence of the score 15.

int index = Array.IndexOf(score, 15); // It will provide the index of the number item 15, therefore, index 2 (from
                                      // the original score array)

// Find the index of the first occurrence of the score greater than 5

int index2 = Array.FindIndex(score, x => x > 5); // 1

// Check whether score of 20 exists

bool exists = Array.Exists(score, x => x == 20);

// Clear the last two scores

Array.Clear(score, 2, 2); // score = [ 5, 10, 0, 0], so it is not eliminating the item space

//////////////////// Lists /////////////////////////

// Declare and initialize a list

List<int> numList = new List<int>(){10, 20, 30, 40, 50};

// Accessing elements

Console.WriteLine(numList[2]);

// Get the list capacity

Console.WriteLine(numList.Capacity); // 8

// Get the length (count) of elements in the list

Console.WriteLine(numList.Count); // We would obtain 5 because we have five elements in the list

// Add values to the list

numList.Add(60);
numList.Add(70);

// Add a multiple values to the list at once

numList.AddRange(new List<int>(){80, 90, 100, 120});

// Check whether the list contains an element

Console.WriteLine(numList.Contains(30)); // We know that our list has 30, so it should return TRUE

// Insert 110 before the last element

numList.Insert(numList.Count - 1, 110);

// Insert -20, 10, and 0 at the start of the list

Console.WriteLine($"Before {numList}");
numList.InsertRange(0, new List<int>(){-20, 10, 0});
Console.WriteLine($"After {numList}"); // Why does it return 


// Remove the first occurrence of the value -20 from the list

numList.Remove(-20);

// Remove the value at index 0 from the list

numList.RemoveAt(0); // It should remove -10

// Remove all elements greater than 50

numList.RemoveAll(x => x > 50); // You should obtain a list containing values between 0 and 50

// Sort the list

numList.Sort(); // Ascending order sorting

// Convert the list into an array of the same type

int[] copyList = numList.ToArray();

// Copy the list values into an array of double size, starting from index 5

int[] copyList2 = new int[numList.Count * 2]; // Creating an array double the size of my original list
numList.CopyTo(copyList2, 5); // Copy starting at index 5

// Check whether at least an odd value exists

exists = numList.Exists(x => x % 2 != 0);

// Find the first even score 

firstEven = numList.Find(x => x % 2 == 0); // It should 0
Console.WriteLine(firstEven);

// Find all values greater than 10

List<int> newAboveTen = new List<int>();

newAboveTen = numList.FindAll(x => x > 10);

// Find the index of the first occurrence of the value 10.

index = numList.IndexOf(10);

// Find the index of the first occurrence of the value greater than 5

index2 = numList.FindIndex(x => x > 5);

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


//////////////////// LinkedList /////////////////////////

// Declare and Initialize a LinkedList

// Count the number of items in the list

// Add 0 at the beginning of the list

// Add 8 and 10 at the end of the list

// Find the first node equal to 3

// Put a 2 in the list right before the 3

// Add another 2 to the list right after the 1

// Check whether 5 is in the list

// Remove the first and last values in the list

// Return the first(Head) and last(Tail) node of the list

// Return the value of the node right after the head node

// Remove the first occurrence of 2

// Copy the entire list to an array

// Remove all values in the list


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


// Definition:
// int Sum(int num1, int num2)
// {
//     //int sum = num1 + num2;
//     //return sum;
//     
//     return num1 + num2;
// }
//
// // Call the function
// int sumNums = Sum(4, 5);
// Console.WriteLine(sumNums);


// Then, call the function


// Write a void function that prints messages on console


// Write a function that greet users with an optional parameter
