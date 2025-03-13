// //////////////////// Dictionary ////////////////////
//
// Console.WriteLine("============== Dictionary - Problem 1 ==============\n");
//
//
// int option = 0, number;
// string input, name;
// string[] inputArray;
// Dictionary<string, int> phoneBook = new Dictionary<string, int>();
//
// while (option != 3)
// {
//     Console.WriteLine("Choose an option:\n" +
//                       "1. Add\n" +
//                       "2. Search\n" +
//                       "3. Exist");
//
//     option = int.Parse(Console.ReadLine());
//
//     switch (option)
//     {
//         case 1:
//             Console.WriteLine("Enter name and phone number:");
//             input = Console.ReadLine();
//             inputArray = input.Split(' ');
//
//             name = inputArray[0];
//             number = int.Parse(inputArray[1]);
//
//             if (!phoneBook.ContainsKey(name))
//             {
//                 phoneBook.Add(name, number);
//                 Console.WriteLine($"{name} {number} is added to the phonebook.\n");
//             }
//             else
//             {
//                 Console.WriteLine($"Invalid input! {name} is already in the phonebook.\n");
//             }
//             
//             break;
//         
//         case 2:
//             Console.WriteLine("\nEnter name and phone number:");
//             name = Console.ReadLine();
//
//             if (phoneBook.ContainsKey(name))
//             {
//                 Console.WriteLine($"{name}'s phone number is {phoneBook[name]}\n");
//             }
//             else
//             {
//                 Console.WriteLine($"{name} is not in the phonebook.\n");
//             }
//
//             break;
//         
//         case 3:
//             Console.WriteLine("\nGoodbye!\n");
//             break;
//             
//     }
//     
// }
//
//
//
//
//// ============== Dictionary - Problem 2 ==============
//
// Console.WriteLine("============== Dictionary - Problem 2 ==============\n");
//
// Console.WriteLine("Enter a string of words:");
// string input2 = Console.ReadLine();
// string[] inputArray2 = input2.Split(' ');
//
// Dictionary<string, int> wordCounter = new Dictionary<string, int>();
//
// foreach (string word in inputArray2)
// {
//     if (!wordCounter.ContainsKey(word))
//     {
//         wordCounter.Add(word, 1);
//     }
//     else
//     {
//         wordCounter[word]++;
//     }
// }
//
// foreach (KeyValuePair<string, int> kvp in wordCounter)
// {
//     Console.WriteLine($"{kvp.Key} : {kvp.Value}");
// }
//
//
//
//

//// ============== Dictionary - Problem 3 ==============
//  
// Console.WriteLine("============== Dictionary - Problem 3 ==============\n");
//
// string command = "";
// Dictionary<string, int> inventory = new Dictionary<string, int>();
//
// while (command != "exit")
// {
//     Console.WriteLine("Choose a command:\n" +
//                       "ADD\n" +
//                       "REMOVE\n" +
//                       "SHOW\n" +
//                       "EXIT\n");
//     
//     command = Console.ReadLine().ToLower();
//     string input3, product;
//     string[] inputArray3;
//     int quantity;
//
//     switch (command)
//     {
//         case "add":
//             Console.WriteLine("ADD product_name and the quantity separated by space:");
//             input3 = Console.ReadLine();
//             inputArray3 = input3.Split(' ');
//
//             product = inputArray3[0].ToLower();
//             quantity = int.Parse(inputArray3[1]);
//
//             if (!inventory.ContainsKey(product))
//             {
//                 inventory.Add(product, quantity);
//                 Console.WriteLine($"{quantity} {product}(s) added to inventory.\n");
//             }
//             else
//             {
//                 inventory[product] += quantity;
//                 Console.WriteLine($"{quantity} {product}(s) added to inventory.\n");
//             }
//             break;
//         
//         case "remove":
//             Console.WriteLine("Enter the product name to remove:");
//             input3 = Console.ReadLine().ToLower();
//
//             if (inventory.ContainsKey(input3))
//             {
//                 inventory.Remove(input3);
//                 Console.WriteLine($"{input3} is removed from the inventory.\n");
//             }
//             else
//             {
//                 Console.WriteLine("There's no such item in inventory!\n");
//             }
//             break;
//         
//         case "show":
//             foreach (KeyValuePair<string, int> kvp in inventory)
//             {
//                 Console.WriteLine($"{kvp.Key} : {kvp.Value}");
//             }
//             Console.WriteLine("");
//             break;
//
//         case "exit":
//             Console.WriteLine("Goodbye!\n");
//             break;
//     }
// }
 

 
//////////////////// HashSet ////////////////////
 

// Console.WriteLine("============== HashSet - Problem 1 ==============\n");
//
// Console.WriteLine("Enter N numbers:");
// string input4 = Console.ReadLine();
//
// string[] inputArray4 = input4.Split(' ');
//
// HashSet<int> numSet = new HashSet<int>();
//
// foreach (string num in inputArray4)
// {
//     numSet.Add(int.Parse(num));
// }
//
// int[] numArray = numSet.ToArray();
// Array.Sort(numArray);
//
// Console.WriteLine($"Unique count: {numSet.Count}\n" +
//                   $"Contains 10: {numSet.Contains(10)}\n" +
//                   $"Sorted Unique Numbers: {string.Join(' ', numArray)}\n");



//// ============== HashSet - Problem 2 ==============

// Console.WriteLine("============== HashSet - Problem 2 ==============\n");
//  
// Console.WriteLine("Enter N numbers:");
// string input5 = Console.ReadLine();
//
// Console.WriteLine("Enter M numbers:");
// string input6 = Console.ReadLine();
//
// string[] inputArray5 = input5.Split(' ');
// string[] inputArray6 = input6.Split(' ');
//
// HashSet<int> setA = new HashSet<int>();
// HashSet<int> setB = new HashSet<int>();
//
// foreach (var val in inputArray5)
// {
//     setA.Add(int.Parse(val));
// }
//
// foreach (var val in inputArray6)
// {
//     setB.Add(int.Parse(val));
// }
//
// Console.WriteLine(string.Join(',', setA));
// Console.WriteLine(string.Join(',', setB));
//
// HashSet<int> common = new HashSet<int>(setA);
// common.IntersectWith(setB);
//
// HashSet<int> unique = new HashSet<int>(setA);
// unique.UnionWith(setB);
//
// HashSet<int> except = new HashSet<int>(setA);
// except.ExceptWith(setB);
//
//
// Console.WriteLine($"Common Elements: {string.Join(' ', common.ToArray())}\n" +
//                   $"Unique elements across both sets: {string.Join(' ', unique.ToArray())}\n" +
//                   $"Count of Elements Only in First Set: {except.Count}");


//////////////////// LinkedList ////////////////////

// Console.WriteLine("============== LinkedList - Problem 1 ==============\n");
//
// LinkedList<int> priorities = new LinkedList<int>([1, 2, 3, 5, 7]);
//
// LinkedListNode<int> index = priorities.Find(3);
// priorities.AddAfter(index, 4);
//
// index = priorities.Find(7);
// priorities.AddBefore(index, 6);
//
// priorities.RemoveFirst();
//
// priorities.RemoveLast();
//
// if (priorities.Contains(2))
// {
//     Console.WriteLine("Task 2 Found");
// }
//
// Console.WriteLine($"Count: {priorities.Count}");



//// ============== LinkedList - Problem 2 ==============

// Console.WriteLine("============== LinkedList - Problem 2 ==============\n");
//
// LinkedList<int> list1 = new LinkedList<int>([1, 4, 5, 7]);
// LinkedList<int> list2 = new LinkedList<int>([2, 3, 6, 8]);
//
// LinkedList<int> mergedList = new LinkedList<int>();
//
// LinkedListNode<int> node1 = list1.First;
// LinkedListNode<int> node2 = list2.First;
//
// while (node1 != null && node2 != null)
// {
//     if (node1.Value < node2.Value)
//     {
//         mergedList.AddLast(node1.Value);
//         node1 = node1.Next;
//     }
//     else
//     {
//         mergedList.AddLast(node2.Value);
//         node2 = node2.Next;
//     }
// }
//
// while (node1 != null)
// {
//     mergedList.AddLast(node1.Value);
//     node1 = node1.Next;
// }
//
// while (node2 != null)
// {
//     mergedList.AddLast(node2.Value);
//     node2 = node2.Next;
// }
//
// Console.WriteLine(string.Join(' ', mergedList));


//////////////////// Stack ////////////////////


// Console.WriteLine("============== Stack - Problem 1 ==============\n");
//
// Console.WriteLine("Enter a string:");
// string input7 = Console.ReadLine();
//
// Stack<char> letterStack = new Stack<char>();
//
// foreach (char letter in input7)
// {
//     letterStack.Push(letter);
// }
//
// string result = "";
// while (letterStack.Count > 0)
// {
//     result += letterStack.Pop();
// }
//
// Console.WriteLine($"Reversed string: {result}");




//// ============== Stack - Problem 2 ==============

// Console.WriteLine("============== Stack - Problem 2 ==============\n");
//
// Console.WriteLine("Enter a string:");
// string input8 = Console.ReadLine();
//
// Stack<char> parentheses = new Stack<char>();
//
// foreach (char character in input8)
// {
//     if (character == '(')
//     {
//         parentheses.Push(character);
//     }
//     else
//     {
//         parentheses.Pop();
//     }
// }
//
// if (parentheses.Count == 0)
// {
//     Console.WriteLine("Balanced");
// }
// else
// {
//     Console.WriteLine("Not Balanced");
// }


//////////////////// Functions ////////////////////


// Console.WriteLine("============== Functions - Problem 1 ==============\n");
//
// bool IsEven(int number)
// {
//     return number % 2 == 0;
// }
//
// Console.WriteLine(IsEven(10));
// Console.WriteLine(IsEven(7));


/* Problem 2
 *
 * Write a function PrintLine that prints a string and has an optional parameter to print a separator line.
 *
 * Example 1
 *
 * PrintLine("C# is fun!");
   Output: 
   C# is fun!
   ---------------
   
 * Example 2
 *
 * PrintLine("C# is fun!", '*');
   Output: 
   C# is fun!
   ***********
 
 * 
 */


//// ============== Functions - Problem 2 ==============

// Console.WriteLine("============== Functions - Problem 2 ==============\n");
//
// void PrintLine(string message, char sign = '-')
// {
//     string separatorLine = "";
//     for (int i = 0; i < 14; i++)
//     {
//         separatorLine += sign;
//     }
//     
//     Console.WriteLine(message);
//     Console.WriteLine(separatorLine);
// }
//
//
// PrintLine("C# is fun!");
// PrintLine("C# is fun!", '*');


//// ============== Functions - Problem 3 ==============

// Console.WriteLine("============== Functions - Problem 3 ==============\n");
//
// int FindMax(int[] numbers)
// {
//     int min = int.MinValue;
//
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         if (numbers[i] > min)
//         {
//             min = numbers[i];
//         }
//     }
//
//     return min;
// }
//
//
//
// int[] arr = {3, 8, 1, 9, 5};
// Console.WriteLine(FindMax(arr));



//// ============== Functions - Problem 4 ==============

// Console.WriteLine("============== Functions - Problem 4 ==============\n");
//
// void CensorWord(string message, string word, char sign = '*')
// {
//     string[] sentence = message.Split(' ');
//     int index = Array.FindIndex(sentence, x=> x == word);
//
//     string censor = "";
//     foreach (char character in sentence[index])
//     {
//         censor += sign;
//     }
//
//     sentence[index] = censor;
//     
//     Console.WriteLine(string.Join(' ', sentence));
// }
//
//
//
// CensorWord("I love programming", "love");
// CensorWord("C# is great", "great", '#');