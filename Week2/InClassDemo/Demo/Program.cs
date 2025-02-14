
//////////////////// Arrays /////////////////////////

// Declaration

// Initialization

// Declaration and Initialization Together

// Alternative Short Syntax

// Accessing and Modifying Elements

// Get the size of an array

// Sort scores

// Copy the first 2 elements of scores to a new array

// Copy scores starting at index 1 in destinationArray

// Find the first even score 

// Find all scores greater than 10

// Find the index of the first occurrence of the score 15.

// Find the index of the first occurrence of the score greater than 5

// Check whether score of 20 exists

// Clear the last two scores



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

using System.Runtime.CompilerServices;

Stack<int> myStack = new Stack<int>([1, 2, 3]);

// Get the number of elements in the stack
Console.WriteLine($"# in myStack: {myStack.Count}");

// check if 5 exists in the stack
myStack.Contains(5); // false

// Return the top element in the stack
int stackValue = myStack.Peek();

// Remove and return the top element in the stack
stackValue = myStack.Pop(); // 3

// Add 5 to the stack
myStack.Push(5); // [1,2,5]

// Convert the current stack into an array 
int[] stackArray = myStack.ToArray(); // [5,2,1]
Console.WriteLine(string.Join(',', myStack));

// Copy elements of current stack into a new array
myStack.CopyTo(stackArray, 0); // [5,2,1]

// Remove all elements from the stack
myStack.Clear();

//////////////////// Queue /////////////////////////

// Declare and initialize a queue
Queue<int> myQueue = new Queue<int>([1, 2, 3]);

// Get the number of elements in the queue
Console.WriteLine($"myQueue Count: {myQueue.Count}");

// check if 5 exists in the queue
myQueue.Contains(5); // false

// Return the element at the front of the queue
int frontVal = myQueue.Peek();

// Remove and return the element at the front of the queue
frontVal = myQueue.Dequeue(); // [2,3]

// Add 5 to the queue
myQueue.Enqueue(5); // [2, 3, 5]

// Convert the current queue into an array 
int[] QueueArray = myQueue.ToArray(); // [2,3,5]

// Copy elements of current queue into a new array
myQueue.CopyTo(QueueArray, 0);
Console.WriteLine(string.Join(",", QueueArray));

// Remove all elements from the queue
myQueue.Clear();


//////////////////// Functions /////////////////////////

// Write a function that takes two integers and return their sum.
// Then, call the function

int MyAddFunction(int num1, int num2)
{
    // int sum = num1 + num1;    
    // return sum;

    return num1 + num2;
}

// Call the function
int sumNums = MyAddFunction(4, 5);
Console.WriteLine(sumNums);

// Write a void function that prints messages on console

// Definition

void Print(string input)
{
    Console.WriteLine(input);
}

// Call

Print("Hello");
Print("How are you?");

// Write a function that greet users with an optional parameter

void Greet(string name = "User")
{
    Console.WriteLine($"Hello {name}");
}

Greet();
Greet("Iman");
    