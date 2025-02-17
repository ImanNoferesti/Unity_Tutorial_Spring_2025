//////////////////// Dictionary ////////////////////

/* Problem 1
 * 
 * Write a program that allows a user to store and look up phone numbers using a dictionary.
 * The user should be able to enter a name and a phone number (separated by spaces) to add to the phonebook.
 * Then, they can enter a name to look up the corresponding number.
 *
 * Example 1
 * 
 * Input:
 * Enter name and phone number: John 123456
 * Output:
 * John 123456 is added to the phonebook.
 *
 * Example 2
 *
 * Input:
 * Enter a name to search: John
 * Output:
 * John's phone number is 123456 
 *
 * Example 3
 *
 * Input: Enter a name to search: Bob
 * Output: Bob is not in the phonebook.
 * 
 */

Dictionary<string, string> contacts = new Dictionary<string, string>()
{
 { "Cathleen", "1234" },
 { "Margaret", "2468" },
 { "Toby", "1357" }
};

// foreach (KeyValuePair<string, string> kvp in contacts)
// {
//  Console.WriteLine($"{kvp.Key}, {kvp.Value}");
// }

Console.WriteLine("Please select an option (1 - 3):");
Console.WriteLine("1: Add a contact");
Console.WriteLine("2: Look up a phone number");
Console.WriteLine("3: Change a phone number");
Console.WriteLine("4: See a list of all contacts");
Console.WriteLine("5: exit");
int selection = int.Parse(Console.ReadLine());

switch (selection)
{
case 1: // add a contact
 Console.WriteLine("Please enter the info for the new contact (name, number)");
 string input = Console.ReadLine();
 string[] inputArray = input.Split(',');
 contacts.Add(inputArray[0], inputArray[1]);
 
 // foreach (KeyValuePair<string, string> kvp in contacts)
 // {
 //  Console.WriteLine($"{kvp.Key}, {kvp.Value}");
 // }
 
 break;

case 2:// look up a phone number
 Console.WriteLine("Please enter the name of the contact: ");
 string lookUpName = Console.ReadLine();
 if (contacts.ContainsKey(lookUpName))
 {
  Console.WriteLine($"{lookUpName}'s phone number is contacts[lookUpName].");
 }
 else
 {
  Console.WriteLine($"Sorry, there is no {lookUpName} in your contact list.");
 }
 
 break;

case 3: // change a phone number
 Console.WriteLine("Whose phone number would you like to change?");
 string changeName = Console.ReadLine();
 if (contacts.ContainsKey(changeName))
{
 Console.WriteLine($"Please enter {changeName}'s new phone number");
 string newNum = Console.ReadLine();
 contacts[changeName] = newNum;
}
 else
{
 Console.WriteLine($"Sorry, there is no {changeName} in your contact list.");
}
 
 // foreach (KeyValuePair<string, string> kvp in contacts)
 // {
 //  Console.WriteLine($"{kvp.Key}, {kvp.Value}");
 // }
 
 break;

case 4:
 foreach (KeyValuePair<string, string> kvp in contacts)
 {
  Console.WriteLine($"{kvp.Key}, {kvp.Value}");
 }
 break;

case 5:
 Console.WriteLine("Ok, good bye.");
 break;

default:
 Console.WriteLine($"Sorry, {selection} is not a valid option.");
 break;

}







/* Problem 2
 * 
 * Write a program that takes a string of words (separated by spaces)
 * and counts how many times each word appears in the input.
 * Finally, print each word and its frequency.
 *
 *
 * Example
 *
 * Input: hello world hello C# world hello
 * Output:
 *      hello : 3
 *      world : 2
 *      C# : 1
 */








 
 /* Problem 3
  *
  * Write a program that manages an inventory system.
  * The program should allow the user to enter a series of commands to manage products in stock.
  * The inventory should be stored in a dictionary where the key is the product name and the value is the stock quantity.
  *
  * Commands:
  * 1. ADD product_name quantity → Add a product to inventory (if it exists, increase quantity).
  * 2. REMOVE product_name → Remove a product from inventory (if it exists).
  * 3. SHOW → Display all products and their quantities.
  * 4. EXIT → Stop the program.
  *
  * Example 1
  *
  * Input:
  * ADD product_name and the quantity separated by space: apple 10
  * Output:
  * 10 apple(s) added to inventory.
  *
  * Example 2
  *
  * Input:
  * SHOW
  * Output:
  * apple: 13
  * banana: 5
  *
  * Example 3
  *
  * Input:
  * Enter the product name to remove: banana
  * Output:
  * banana is removed from the inventory
  *
  * 
  *
  */

 Dictionary<string, int> inventory = new Dictionary<string, int>()
 {
  { "crackers", 10 },
  { "chicken", 5 },
  { "apples", 20 }
 };

Console.WriteLine("What would you like to do (1-4)?");
Console.WriteLine("1: Check inventory for a product");
Console.WriteLine("2: Add to the inventory");
Console.WriteLine("3: Reduce from the inventory");
Console.WriteLine("4: Show all inventory");
Console.WriteLine("5: Exit");
int task = int.Parse(Console.ReadLine());

switch (task)
{
 case 1: // check inventory
  Console.WriteLine("What product would you like to check?");
  string checkProduct = Console.ReadLine();
  if (inventory.ContainsKey(checkProduct))
  {
   Console.WriteLine($"The curent inventory of {checkProduct} is {inventory[checkProduct]}.");
  }
  else
  {
   Console.WriteLine($"There is currenlty no {checkProduct} in stock.");
  }
  break;
 
 case 2: // add to inventory
  Console.WriteLine($"Please enter the product that you would like to change or add:");
  string changeProduct = Console.ReadLine();
  if (inventory.ContainsKey(changeProduct))
  {
   Console.WriteLine($"The current inventory of {changeProduct} is {inventory[changeProduct]}.");
   Console.WriteLine($"How many to you want to add to the record?");
   int addInv = int.Parse(Console.ReadLine());
   inventory[changeProduct] = inventory[changeProduct] + addInv;
   Console.WriteLine($"OK, the new inventory of {changeProduct} is {inventory[changeProduct]}.");
  }
  else
  {
   Console.WriteLine($"There is currently no record of {changeProduct}. Would you like to add it to the inventory list (y/n)?");
   char confirmChange = char.Parse(Console.ReadLine());
   if (confirmChange == 'y')
   {
    Console.WriteLine($"How many should I add to the inventory for {changeProduct}");
    int addQuant = int.Parse(Console.ReadLine());
    inventory.Add(changeProduct, addQuant);
    Console.WriteLine($"OK, the new inventory of {changeProduct} is {inventory[changeProduct]}.");
   }
   else
   {
    Console.WriteLine("Ok, I will not make any changes to the inventory list at this time.");
   }
  }
  break;

 case 3: // reduce or remove from inventory
  Console.WriteLine("Please enter the product that you would like to change:");
  //the compliler said that a local varialbe "changeProduct was already declared...but it was in a case 2
  //which if I'm in case 3, it won't have been called...so I'm not sure why I couldn't use changeProduct.
  //I added and "R" for reduce to make it work.
  string changeProductR = Console.ReadLine();

  if (inventory.ContainsKey(changeProductR))
  {
   Console.WriteLine($"The inventory for {changeProductR} is currently {inventory[changeProductR]}."); 
   Console.WriteLine("Do you want to reduce it (y/n)?");
   char confirmChange = char.Parse(Console.ReadLine());
   if (confirmChange == 'y')
   {
    Console.WriteLine("How many would you like me to reduce it?");
    int reduceQuant = int.Parse(Console.ReadLine());
    inventory[changeProductR] = inventory[changeProductR] - reduceQuant;
    Console.WriteLine($"OK, the new inventory for {changeProductR} is {inventory[changeProductR]}");
   }
   else
   {
    Console.WriteLine("Okay, I will not make any changes to the inventory list at this time.");
   }
  }
  else
  {
   Console.WriteLine($"There is currently no record of {changeProductR}");
  }
  break;

 case 4:
  foreach (KeyValuePair<string,int> kvp in inventory)
 {
  Console.WriteLine($"{kvp.Key}, {kvp.Value}");
 }
  break;
 
 case 5:
  Console.WriteLine("Ok, good bye");
  break;
 
 default:
  Console.WriteLine($"Sorry, {task} is not a valid option.");
  break;
}

 
//////////////////// HashSet ////////////////////
 
/* Problem 1
 *
 * Write a program that reads N integers (separated by space) from the user and stores them in a HashSet<int>.
 * The program should then print:
 * 1. The count of unique numbers entered.
 * 2. Whether the number 10 is in the set or not.
 * 3. The set of unique numbers in sorted order.
 *
 *
 * Example 1
 *
 * Input: Enter N numbers: 6 5 10 -3 10 7 5
 * Output:
 * Unique count: 4
 * Contains 10: Yes
 * Sorted Unique Numbers: -3 5 7 10
 * 
 */






/* Problem 2
 *
 * Write a program that reads two sets of integers from the user.
 * The first input is N (size of set A), followed by N integers.
 * The second input is M (size of set B), followed by M integers.
 * The program should then:
 * 1. Display the elements that are common between the two sets.
 * 2. Display all unique elements across both sets combined
 * 3. Display the count of elements only present in the first set but not in the second.
 *
 * Example 1
 *
 * Input:
 * Enter N numbers: 5 1 3 5 7 9
 * Enter M numbers: 4 3 5 8 10
 *
 * Output:
 * Common Elements: 3 5
 * Unique elements across both sets: 1 3 5 7 8 9 10
 * Count of Elements Only in First Set: 3
 * 
 */
 
 
 


//////////////////// LinkedList ////////////////////

/* Problem 1
 * 
 * You are given a LinkedList<int> that represents a simple to-do list.
 * Each integer represents a task with a priority (lower numbers mean higher priority).
 * Implement a sequence of operations on this list.
 *
 * Operations to Perform in Order: (Print the result collection after each operation)
 * 1. Add tasks with priorities 5, 1, 3, 7, 2 in the list, but ensure that:
 *      1 is always at the front.
 *      7 is always at the end.
 * 2. Insert a new task with priority 4 after the task with priority 3.
 * 3. Insert a new task with priority 6 before the task with priority 7.
 * 4. Remove the highest priority task
 * 5. Remove the lowest priority task
 * 6. Check if the list contains a task with priority 2 and print "Task 2 Found" if it exists.
 * 7. Print the total number of tasks in the list.
 * 
 */








/* Problem 2
 *
 * You are given two sorted LinkedList<int> task lists.
 * You must merge them into a single sorted linked list while preserving the order.
 * The numbers in each list represent task priorities, with smaller numbers being higher priority.
 *
 * Example
 * 
 * LinkedList<int> list1 = new LinkedList<int>();
   list1.AddLast(1);
   list1.AddLast(4);
   list1.AddLast(5);
   list1.AddLast(7);
   
   LinkedList<int> list2 = new LinkedList<int>();
   list2.AddLast(2);
   list2.AddLast(3);
   list2.AddLast(6);
   list2.AddLast(8);
   
   Output:
   1 2 3 4 5 6 7 8
 * 
 */








//////////////////// Stack ////////////////////

/* Problem 1
 *
 * Write a program that reads a string from the user and prints the string in reverse order.
 *
 * Example 1
 *
 * Input: Enter a string: HELLO
 * Output: Reversed string: OLLEH
 * 
 */



/* Problem 2
 *
 * Write a program that checks whether a given string of parentheses is balanced or not.
 * A string is balanced if every opening ( has a corresponding closing ), and they appear in the correct order.
 *
 * Example 1
 *
 * Input: Enter a string: (())()
 * Output: Balanced
 *
 * Example 2
 *
 * Input: Enter a string: ()(()
 * Output: Not Balanced
 * 
 */








//////////////////// Functions ////////////////////

/* Problem 1
 *
 * Write a function IsEven that takes an int number and returns true if the number is even and false otherwise.
 *
 * Example:
 * Console.WriteLine(IsEven(10)); // Output: True
 * Console.WriteLine(IsEven(7));  // Output: False
 * 
 */








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







/* Problem 3
 *
 * Write a function FindMax that takes an int[] numbers and returns the largest number.
 *
 * Example 1
 *
 * int[] arr = {3, 8, 1, 9, 5};
 * Console.WriteLine(FindMax(arr));  // Output: 9
 *
 * 
 */





/* Problem 4
 *
 * Write a function CensorWord that takes a string sentence, a string wordToCensor, and an optional parameter.
 * The function prints the sentence with the word replaced by the mask.
 *
 * Example 1
 *
 * CensorWord("I love programming", "love");
 * Output: I **** programming
 *
 * Example 2
 *
 * CensorWord("C# is great", "great", '#');
 * Output: C# is #####
 */
 
 