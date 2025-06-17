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

// int optionContact = 999;
// (string, string) contactInfo = ("name", "phoneNumber");
// Dictionary<string, string> contactList = new Dictionary<string, string>();
// string name = "empty";
// string phoneNumber = "";
// string removeName = "";
// string contactResult = "";
// string contactSearch = "XXX"; // To save the input and do search
//
//
// while (optionContact != 5)
// {
//   Console.WriteLine("Contacts menu:" +
//                     "\n1. Add a new contact \n2. Remove a contact" +
//                     "\n3. Search for a contact \n4. List all contacts" +
//                     "\n5. Exit");
//   Console.WriteLine("Enter the number of the option you want:");
//   optionContact = int.Parse(Console.ReadLine());
//   
//   switch (optionContact) // Evaluates the content of the option chosen by the customer
//   {
//     case 1: // Add a new contact
//       Console.WriteLine("Please enter the name");
//       name = Console.ReadLine();
//       Console.WriteLine("Please the phone number with no dashes");
//       phoneNumber = Console.ReadLine();
//       contactList.Add(name, phoneNumber);
//       
//       Console.WriteLine($"{name}, {phoneNumber} has been added to the phonebook");
//       break;
//     case 2: // Remove a contact
//       
//       foreach (KeyValuePair<string, string> contact in contactList)
//       {
//         Console.WriteLine($"Name: {contact.Key} - Number: {contact.Value}");
//       }
//       
//       Console.WriteLine("These are your current contacts" +
//                         "\n please enter the name of the" +
//                         "\n you wish to remove:");
//       removeName = Console.ReadLine();
//       contactList.Remove(removeName);
//       
//       Console.WriteLine($"Contact deleted: {removeName}");
//       
//       break;
//     case 3: // Search for a contact
//       Console.WriteLine("Please enter the name of the" +
//                         "\nyou want to search:");
//       contactSearch = Console.ReadLine();
//
//       if (contactList.ContainsKey(contactSearch))
//       {
//         contactResult = contactList[contactSearch];
//       
//         Console.WriteLine($"Contact Information: {contactSearch}, " +
//                           $"{contactResult}");
//       }
//       else
//       {
//         Console.WriteLine($"{contactSearch} is not in your contacts.");
//       }
//       break;
//     case 4: // List all contacts
//       
//       Console.WriteLine("These are your current contacts:");
//   
//       foreach (KeyValuePair<string, string> contact in contactList)
//       {
//         Console.WriteLine($"Name: {contact.Key} - Number: {contact.Value}");
//       }
//       break;
//     case 5: // Exit
//       
//       Console.WriteLine("You have exited your contact list, good-bye!");
//       break;
//     
//     default:
//       Console.WriteLine("Invalid Option, Try again!");
//       break;
//   }
// }




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

// string stringWord;
// int count;
// Dictionary<string, int> wordCounterList = new Dictionary<string, int>();
//
// stringWord = Console.ReadLine();
//
// string[] inputArray2 = stringWord.Split(' ');
//
// foreach (string word in inputArray2)
// {
//   if (wordCounterList.ContainsKey(word))
//   {
//       count = wordCounterList[word];
//       wordCounterList[word] = count + 1;
//   }
//   else
//   {
//     wordCounterList.Add(word, 1);
//   }
// }
//
// foreach (KeyValuePair<string, int> wordCount in wordCounterList)
// {
//   Console.WriteLine($"{wordCount.Key} : {wordCount.Value}");
// }
//  
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


//  using System.Xml;
//
//  Dictionary<string, int> inventoryList = new Dictionary<string, int>();
// int option = 00;
// string productName;
// int currentProductCount;
//
//  while (option != 4)
//  {
//      Console.Write("Welcome to the inventory management system - Castillo LLC" +
//                    "\nMenu option:" +
//                    "\n1. Add a product (new or existing)" +
//                    "\n2. Remove a product" +
//                    "\n3. Show all products and their quantities" +
//                    "\n4. Exit");
//      Console.WriteLine("\nPlease enter an option below:");
//      option = int.Parse(Console.ReadLine());
//      switch (option)
//      {
//          case 1: // Add a product (new or existing)
//           Console.WriteLine("Please enter the name of the product to add:");
//           productName = Console.ReadLine();
//           if (inventoryList.ContainsKey(productName))
//           {
//            inventoryList[productName]++;
//            currentProductCount = inventoryList[productName];
//            Console.WriteLine($"{productName} exists in the inventory. Count: {currentProductCount}");
//           }
//           else
//           {
//            inventoryList.Add(productName, 1);
//           }
//           break;
//          case 2: // Remove product
//           Console.WriteLine("Please enter the name of the product to remove:");
//           productName = Console.ReadLine();
//           if (inventoryList.ContainsKey(productName))
//           {
//            inventoryList.Remove(productName);
//           }
//           else
//           {
//            Console.WriteLine("This product is not in the inventory");
//           }
//           break;
//          case 3: // Display all product and their quantities
//           foreach (KeyValuePair<string, int> kvp in inventoryList)
//           {
//            Console.WriteLine($"Product name: {kvp.Key} - Count: {kvp.Value}");
//           }
//           break;
//          case 4: // Exit
//           Console.WriteLine("You have exited the inventory management system. Good-bye!");
//           break;
//          default:
//           Console.WriteLine("\n" +
//                             "\n" +
//                             "\nIncorrect option, please try again" +
//                             "\n" +
//                             "\n");
//           break;
//      }
//  }


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
 
 