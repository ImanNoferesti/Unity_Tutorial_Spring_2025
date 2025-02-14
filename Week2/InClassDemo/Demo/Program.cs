
//////////////////// Arrays /////////////////////////

// Declaration
int[] numbers;

// Initialization
numbers = new int [5]; //a new list of 5 null integers

// Declaration and Initialization Together
numbers = new int[] {1,2,3};
int[] value = new int[] {1,2,3,4,5};

// Alternative Short Syntax
int[] scores = {5,20,10,15};

// Accessing and Modifying Elements
value[1] = 10; //value array = [1,10,3,4,5]

// Get the size of an array
Console.WriteLine(value.Length);

// Sort scores
Array.Sort(scores);
foreach (int val in scores);
{
    Console.WriteLine(val);
}

// Copy the first 2 elements of scores to a new array
int[] copyArr = new int[2]; 
Array.Copy(scores, copyArr, 2); //copyArr = [5,10]

// Copy scores starting at index 1 in destinationArray
int[] copyArr2 = new int[10];
scores.CopyTo(copyArr2, 1); //copyArr2 = [0,5,20,10,15,0,0,0,0,0]

// Find the first even score 
int firstEven = Array.Find(scores, x => x % 2 == 0); //firstEven = 10

// Find all scores greater than 10
int[] matches = Array.FindAll(scores, x => x > 10); //matches = [15,20]

// Find the index of the first occurrence of the score 15.
int index = Array.IndexOf(scores, 15); //index = 2

// Find the index of the first occurrence of the score greater than 5
int index2 = Array.FindIndex(scores, x => x > 5); //index2 = 1

// Check whether score of 20 exists
bool exists = Array.Exists(scores, x => x ==20); //exists = true

// Clear the last two scores
Array.Clear(scores, 2, 2); //scores = [5,10,0,0]


//////////////////// Lists /////////////////////////

// Declare and initialize a list
List<int> numList = new List<int>() {10,20,30,40,50};

// Accessing elements
Console.WriteLine(numList[2]); //30

// Get the list capacity
Console.WriteLine(numList.Capacity); //8

// Get the length (count) of elements in the list
Console.WriteLine(numList.count); //5

// Add values to the list
numList.Add(60);
numList.Add(70);

// Add a multiple values to the list at once
numList.AddRange(new List<int>() {80,90,100, 120});

// Check whether the list contains an element
numList.Contains(30); //true

// Insert 110 before the last element
numList.Insert(numList.Count-1, 110);

// Insert -20, 10, and 0 at the start of the list
numList.InsertRange(0, new List<int>() {-20, -10, 0});

// Remove the first occurrence of the value -20 from the list
numList.Remove(-20);

// Remove the value at index 0 from the list
numList.RemoveAt(0); removes -10

// Remove all elements greater than 50
numList.RemoveAll(x => x > 50); //[0...50]

// Sort the list
numList.Sort();

// Convert the list into an array of the same type
int[] copyList = numList.ToArray();

// Copy the list values into an array of double size, starting from index 5
int[] copyList2 = new int[numList.Count * 2]; //new array of 20 elements
numList.CopyTo(copyList2, 5);

// Check whether at least an odd value exists
exists = numList.Exists(x => x % 2 != 0); //true

// Find the first even score 
firstEven = numList.Find(x => x % 2 == 0); //0

// Find all values greater than 10
numList<int> findAll = numList.FindAll(x => x > 10); 

// Find the index of the first occurrence of the value 15.
index = numList.IndexOf(10); //1

// Find the index of the first occurrence of the value greater than 5
index = numList.FindIndex(x => x > 5); // 1

// Remove all elements from the list, making it empty
numList.Clear();


//////////////////// Dictionaries /////////////////////////

// Declare and Initialize a dictionary
Dictionary<string, float> myDictionary = new Dictinoary<string, float>(){
    {"Alice", 3.5f},
    {"Bob", 4.0f}
};

// Add elements
myDictionary.Add("Jake", 2.65f);
myDictionary.Add("Taylor", 3.5f);

// Accessing a key and Modifying its value
myDictinoary["Bob"] = 3.99f; 

// Show the total number of students
Console.WriteLine(myDictionary.Count); //4

// Retrieve all keys
foreach (var key in myDictionary.Keys){
    Console.WriteLine(key);
}

// Retrieve all values
foreach (floar values in myDictionary.Values){
    Console.WriteLine(values);
}

// Retrieve all key-value pairs
foreach (keyValuePair<string, float> kvp in myDictionary){
    Console.WriteLine($"Key: {kvp.Key} | Value {kvp.Vlaue}");
}

// Check whether a key exists. If so, show its value
if (myDictionary.ContainsKey("Alice")){
    Console.WriteLine(myDictionary["Alice"]);
}

// Remove a key
myDictionary.Remove("Bob"); 

// Remove all keys and values
myDictionary.Clear();


//////////////////// HashSets /////////////////////////

// Declare and Initialize a HashSet
HashSet<int> mySet = new HashSet<int>() {1,2,3};

// Add elements
mySet.Add(3); //does not add 3 again
ySet.Add(4); //new set is {1,2,3,4}

// Remove an element
mySet.Remove(3);

// Check if an element exists
mySet.Contains(3); //false

// Iterate through hashset
foreach (var item in mySet1){
    Console.WriteLine(item);
}

// Copy all elements into an array
int[] newArray = new int[mySet.Count];
mySet.CopyTo(newArray);

// Remove all elements in the HashSet
mySet.Clear();

// Combine two sets 
HashSet<int> setA = new HashSet<int>() {1,2,3};
HashSet<int> setB = new HashSet<int>() {3,4,5};
setA.UnionWith(setB); //setA = {1,2,3,4,5}
Console.WriteLine(string.Join(',', setA));

// Intersect two sets
HashSet<int> setA = new HashSet<int>() {1,2,3};

setA.IntersectWith(setB); 
Console.WriteLine(string.Join(',', setA)); //setA = {3}

// Difference between two sets
HashSet<int> setA = new HashSet<int>() {1,2,3};

setA.ExceptWith(setB);
Console.WriteLine(string.Join(',', setA)); //setA = {1,2}

// Symmetric Difference between two sets (elements that are only in one)
HashSet<int> setA = new HashSet<int>() {1,2,3};

setA.SymmetricEceptWith(setB);
Console.WriteLine(string.Join(',', setA)); //setA = {1,2,4,5}


//////////////////// LinkedList /////////////////////////

// Declare and Initialize a LinkedList
LinkedList<int> myLinkedList = new LinkedList<int>([1,3,4,5]);

// Count the number of items in the 
Console.WriteLine(myLinkedList.Count); //4

// Add 0 at the beginning of the list
myLinkedList.AddFirst(0); //myLinkedList = [0,1,3,4,5]

// Add 8 and 10 at the end of the list
myLinkedList.AddLast(8); //myLinkedList = [0,1,3,4,5,8]
myLinkedList.AddLast(10); //myLinkedList = [0,1,3,4,5,8,10]

// Find the first node equal to 3
LinkedListNode<int> node = myLinkedList.Find(3);
Console.WriteLine(node.Value); //3
Console.WriteLine(node.Next.Value); //4
Console.WriteLine(myLinkedList.Find(4).value); //4

// Put a 2 in the list right before the 3
LinkedListNode<int> node1 = myLinkedList.Find(3);
myLinkedList.AddBefore(node1, 2); //myLinkedList = [0,1,2,3,4,5,8,10]
Console.WriteLine(string.Join(',', myLinkedList)); //0,1,2,3,4,5,8,10

// Add another 2 to the list right after the 1
node1 = myLinkedList.Find(1);
myLinkedList.AddAfter(node1, 2); 

Console.WriteLine(string.Join(',', myLinkedList)); //0,1,2,2,3,4,5,8,10

// Check whether 5 is in the list
myLinkedList.Contains(5); //true

// Remove the first and last values in the list
myLickedList.RemoveFirst(); //myLinkedList = [1,2,2,3,4,5,8,10]
myLickedList.RemoveLast(); //myLinkedList = [1,2,2,3,4,5,8]

// Return the first(Head) and last(Tail) node of the list
LinkedListNode<int> head = myLinkedList.First;
LinkedListNode<int> tail = myLinkedList.Last;

Console.WriteLine(myLinkedList.First.Value); //1
Console.WriteLine(myLinkedList.Last.Value); //8

// Return the value of the node right after the head node
Console.WriteLine(myLinkedList.head.Next.Value); //2

// Remove the first occurrence of 2
myLinkedList.Remove(2); //myLinkedList = [1,2,3,4,5,8]

// Copy the entire list to an array
int[] newArray2 = new int[myLinkedList.Count];
myLinkedList.CopyTo(newArray2, 0);

// Remove all values in the list
myLinkedList.Clear();


//////////////////// Stack /////////////////////////

// Declare and Initialize a stack
stackalloc<int> myStack = new Stack<int>([1,2,3]);

// Get the number of elements in the stack
Console.WriteLine(myStack.Count); //3

// check if 5 exists in the stack
Console.WriteLine(myStack.Contains(5)); //false

// Return the top element in the stack
myValue = myStack.Peek(); // [1,2,3]

// Remove and return the top element in the stack
myValue = myStack.Pop(); // [1,2]

// Add 5 to the stack
myStack.Push(5); // [1,2,5]

// Convert the current stack into an array 
int[] stackArray = myStack.ToArray(); // [5,2,1]
Console.WriteLine(string.Join(',', stackArray));

// Copy elements of current stack into a new array
myStack.CopyTo(stackArray, 0); //copyStack = [5,2,1]

// Remove all elements from the stack
myStack.Clear(); //[]

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
int SumFunction(int num1, int num2){
    return num1 + num2;
}
    
int sumNums = SumFunction(4, 5); //9
Console.WriteLine(sumNums);


// Write a void function that prints messages on console
void PrintMessage(string message){
    Console.WriteLine(message);
}

PrintMessage("Hello");
PrintMessage("How are you?"); //Hello, How are you?

// Write a function that greet users with an optional parameter
void GreetUser(string name, string greeting = "Hello"){
    Console.WriteLine($"{greeting} {name}");
}

GreetUser("Alice"); //Hello Alice