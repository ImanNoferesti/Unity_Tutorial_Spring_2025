///////////////////// Week 1 Review /////////////////////

/* Problem 1
 
 * Write a program to simulate an ATM menu with the following functionalities:
 * Display the ATM Menu:
    ** Check Balance
    ** Deposit Money
    ** Withdraw Money (ensure balance doesn't go negative)
    ** Exit
 *
 *
 * 
 * Example 1
 * Input:
   ATM Menu:
   1. Check Balance
   2. Deposit Money
   3. Withdraw Money
   4. Exit
   Choose an option: 1
   
   Output: Your balance is $0
   
 * Example 2
 * Input:
   ATM Menu:
   1. Check Balance
   2. Deposit Money
   3. Withdraw Money
   4. Exit
   Choose an option: 2
   Enter the amount to deposit: 100
   
 * Output: You have deposited $100. Your new balance is: $100
 *
 *
 * Example 3
 * Input:
   ATM Menu:
   1. Check Balance
   2. Deposit Money
   3. Withdraw Money
   4. Exit
   Choose an option: 3
   Enter the amount to withdraw: 50
   
 * Output: You have withdrawn $50. Your new balance is: $50
 *
 *
 * Example 4
 * Input:
   ATM Menu:
   1. Check Balance
   2. Deposit Money
   3. Withdraw Money
   4. Exit
   Choose an option: 3
   Enter the amount to withdraw: 100
   
 * Output: Insufficient funds. Withdrawal denied.
 *
 *
 * Example 5
 * Input:
   ATM Menu:
   1. Check Balance
   2. Deposit Money
   3. Withdraw Money
   4. Exit
   Choose an option: 4
   
 * Output: Thank you for using the ATM. Goodbye!
   
 */

using System.ComponentModel.Design;
using System.Runtime.InteropServices.JavaScript;

// Console.WriteLine("Welcome to Goliath International Bank's ATM system!  \nPlease choose one of the following options:");
//
// int option = 999;
// float balance = 0.00f;
// while (option != 4)
// {
//   Console.WriteLine("1. Check Balance \n2. Deposit Money \n3. Withdraw Money \n4. Exit");
//   Console.WriteLine("Enter the number of the option you want:");
//   option = int.Parse(Console.ReadLine());
//
//   switch (option) // Evaluates the content of the option chosen by the customer
//   {
//     case 1: // Check Balance
//       Console.WriteLine($"Your balance is ${balance}");
//       break;
//     case 2: // Deposit Money
//       Console.WriteLine("Please input how much money you wish to deposit");
//       float moneyDeposit = float.Parse(Console.ReadLine());
//       balance = moneyDeposit;
//       Console.WriteLine($"You have deposited ${balance}. Your new balance is ${balance}");
//       break;
//     case 3: // Withdraw money
//       Console.WriteLine("Please enter the amount you want to withdraw");
//       float moneyWithdrawn = float.Parse(Console.ReadLine());
//       if (moneyWithdrawn < balance)
//       {
//         balance = balance - moneyWithdrawn;
//         Console.WriteLine($"You have withdrawn ${moneyWithdrawn}. Your new balance is: ${balance}");
//       }
//       else
//       {
//         Console.WriteLine("Insufficient funds. Withdrawal denied");
//       }
//       break;
//     case 4: // Exit
//       Console.WriteLine("Thank you for visiting Goliath International Bank ATM. Have a good day!");
//       break;
//   }
// }


///////////////////// Arrays /////////////////////
 
/* Problem 1
 * 
 * Declare and initialize two arrays of integers.
 * Merge them into a single array.
 * Sort the merged array in ascending order.
 * Print the final sorted array.
 *
 * Solve this problem using array methods and also solve it without using array methods.
 */

// // Declare and initialize two arrays of integers.
// int[] arrayOne = new[] {5, 10, 20 };
// int[] arrayTwo = new[] { 30, 20, 15 };
//
// // Merge them into a single array.
// int valueLenghArrayOne = arrayOne.Length;
// int valueLenghArrayTwo = arrayTwo.Length;
// int lenghtNewArray = valueLenghArrayOne + valueLenghArrayTwo;
// int[] arrayThree = new int [lenghtNewArray];
// arrayOne.CopyTo(arrayThree, 0);
// arrayTwo.CopyTo(arrayThree,3);
//
// // Sort the merged array in ascending order.
//
// Array.Sort(arrayThree);
//
// foreach (int val in arrayThree)  // To print each element of the array
// {
//   Console.WriteLine(val);
// }


/* Problem 2
 * 
 * Declare and initialize an arrays of integers.
 * Declare a variable for a target number.
 * Find the first index where the number appears.
 * Find the last index where the number appears.
 * If the number is not in the array, return -1 for both indices.
 * Print both indices.
 *
 * Solve this problem using array methods and also solve it without using array methods.
 */

// // Declare and initialize an arrays of integers.
// int[] arrayFive = new [] {1, 2, 3, 5, 4, 5};
//
// // Declare a variable for a target number.
//
// int target = 10;
//
// // Find the first index where the number appears - using array methods
//
// int findIndexFive = Array.FindIndex(arrayFive, x => x == target);
// Console.WriteLine(findIndexFive);
//
// // Find the first index where the number appears - without using array methods
//
// int countFiveIndex = -1;
// int countTargetFirst = 0;
//
// foreach (int val in arrayFive)  // 
// {
//   countFiveIndex += 1;
//   if (val == target)
//   {
//     countTargetFirst += 1;
//     Console.WriteLine($"The index of the first appearance is {countFiveIndex}");
//     break;
//   }
// }
//
// if (countTargetFirst == 0)
// {
//   Console.WriteLine($"The index of the first appearance is {-1}");
// }
//
// // Find the last index where the number appears using array methods
//
// int findLastIndexFive = Array.FindLastIndex(arrayFive, x => x == target);
// Console.WriteLine(findLastIndexFive);
//
// // Find the last index where the number appears without using array methods
//
// int countFiveIndexLast = -1;
// int countTarget = 0;
//
// foreach (int val in arrayFive)  // 
// {
//   countFiveIndexLast += 1;
//   if (val == target)
//   {
//     countTarget = countFiveIndexLast;
//   }
//   else
//   {
//     countTarget = -1;
//   }
// }
//
// Console.WriteLine($"The index of the first appearance is {countTarget}");

/* Problem 3
 * 
 * Ask user to enter integers separated by commas (,) and store them in an array. 
 * Remove all even numbers and sort the remaining numbers in ascending order.
 * Print the modified array.
 *
 * Example 1:
 * Input: Enter integers separated by commas: 5,10,3,8,15,2,11,6
 * Output: [3,5,11,15]
 *
 * Example 2:
 * Input: Enter integers separated by commas: 4,7,9,12,13,18,21
 * Output: [7,9,13,21]
 *
 *
 *
 * Hint 1: Try using Split() method to break a string into substrings. https://learn.microsoft.com/en-us/dotnet/api/system.string.split?view=net-9.0
 *
 * 
 * Hint 2: Try using Joint() method to concatenate the string representation of an array using a specified separator between each element. https://learn.microsoft.com/en-us/dotnet/api/system.string.join?view=net-9.0
 */

using System.Diagnostics;
using System.Net;

// int[] numbersInput = new int[4]; // to store the numbers
// int countEach = -1; // To count each entered number
// // int numberInt = 0; // To save the current number
//
// Console.WriteLine("Please enter the set of numbers you want to filter, and separate using commas. " +
//                   "\nWe will filter out the even ones.");
// string input = Console.ReadLine();
//
// foreach (var number in input.Split(","))
// {
//   int numberInt = int.Parse(number);
//   if (numberInt % 2 != 0)
//   {
//     countEach += 1;
//     numbersInput[countEach] = numberInt;
//   }
// }
//
// Array.Sort(numbersInput);
//
// foreach (var n in numbersInput)
// {
//   Console.WriteLine(n);
// }


/* Problem 4
 * 
 * Ask user to enter integers separated by commas (,) and store them in an array.
 * Determine which number appears the most times.
 * If there are multiple numbers with the same highest frequency, return the smallest one.
 * Print the most frequently occurring number.
 *
 * Example 1:
 * Input: Enter integers separated by commas: 1,3,2,1,4,1,2,3,2
 * Output: Number 1 appears 3 time(s).
 * Explanation: The number 1 appears 3 times, which is the highest frequency.
 *
 * Example 2:
 * Input: Enter integers separated by commas: 4,5,4,6,5,6,5,6
 * Output: Number 5 appears 3 time(s).
 * Explanation: Both 5 and 6 appear 3 times, but 5 is the smallest number among them.
 *
 * Example 3:
 * Input: Enter integers separated by commas: 1,2,3,4,5
 * Output: Number 1 appears 1 time(s).
 * Explanation: Number 1 is the smallest number among them and it appears once.
 *
 *
 */

// Console.WriteLine("Please enter the numbers separated by commas with no spaces");
// string four = Console.ReadLine();
//
// string[] count = four.Split(","); 
// int matchesFourLenghtHigh = 0; // highest frequency found
// int maxNumber = 0;            // the number with the highest frequency so far
//
// foreach (var numberStr in count)
// {
//   // Convert the current string to an integer
//   int currentNumber = int.Parse(numberStr);
//
//   // Count how many times this currentNumber appears in 'count'
//   int freq = Array.FindAll(count, x => x == numberStr).Length;
//
//   // Check if we found a strictly bigger frequency
//   if (freq > matchesFourLenghtHigh)
//   {
//     matchesFourLenghtHigh = freq;
//     maxNumber = currentNumber;
//   }
//   // If the frequency is the same, but currentNumber is smaller, update
//   else if (freq == matchesFourLenghtHigh && currentNumber < maxNumber)
//   {
//     maxNumber = currentNumber;
//   }
// }
//
// // Print after the loop finishes (only once)
// Console.WriteLine($"Number {maxNumber} appears {matchesFourLenghtHigh} time(s).");


/* Problem 5
 * 
 * Ask user to enter integers separated by commas (,) and store them in an array.
 * Replace all negative numbers with their absolute values.
 * Remove all numbers greater than 100.
 * Sort the final array in ascending order.
 * Print the modified array.
 *
 * Example 1:
 * Input: Enter integers separated by commas: 3,-1,105,-50,70,200,-300,5
 * Output: [1,3,5,50,70]
 * 
 *
 * Example 2:
 * Input: Enter integers separated by commas: -10,20,150,-25,45,110,-90,7
 * Output: [7,10,20,25,45,90]
 * 
 *
 *
 */

// Console.WriteLine("Please enter the numbers separated by commas with no spaces");
// string five = Console.ReadLine();
// int lenghtFive = five.Split(",").Length;
// string[] fiveStringSplit = five.Split(",");
// int[] fiveArrayInt = new int[lenghtFive];
// int indexCurrent = 0; // To store the index of the current number to find the location and replace
// int positiveValue = 0; // To store the positive, if transformed
// int greaterThanLenght = 0; // To store the number of greater than 100
//
// for(int i = 0; i < lenghtFive; i++)
// {
//   fiveArrayInt[i] = int.Parse(fiveStringSplit[i]);
// }
//
// foreach (var number in fiveArrayInt)
// {
//   indexCurrent = Array.FindIndex(fiveArrayInt, x => x == number);
//   if (number < 0)
//   {
//     positiveValue = number * -1;
//     fiveArrayInt[indexCurrent] = positiveValue;
//   }
// }
//
// greaterThanLenght = Array.FindAll(fiveArrayInt, i => i < 100).Length;
// int[] allLessThan = new int[greaterThanLenght];
// allLessThan = Array.FindAll(fiveArrayInt, i => i < 100);
// Array.Sort(allLessThan);
// Console.WriteLine("[" + string.Join(',', allLessThan) + "]");





/* Problem 6
 * 
 * Ask user to enter integers separated by commas (,) and store them in an array.
 * Ask user to enter an integer N.
 * Shift all elements to the right by N positions, wrapping elements that move past the end back to the start.
 * Print the final array.
 *
 * Example 1:
 * Input: Enter integers separated by commas: 1,2,3,4,5
 * Input: Enter an integer for N: 2
 * Output: [4,5,1,2,3]
 * Explanation: The elements are shifted 2 positions to the right. The last 2 elements (4 and 5) wrap around to the start.
 *
 *
 * Example 2:
 * Input: Enter integers separated by commas: 5,10,15,20,25,30
 * Input: Enter an integer for N: 5
 * Output: [10,15,20,25,30,5]
 * Explanation: The elements are shifted 5 positions to the right. The last 5 elements (10, 15, 20, 25, 30) wrap around to the start.
 *
 */
 
Console.WriteLine("Please enter the numbers separated by commas with no spaces");
string six = Console.ReadLine(); // Reads the input and saves it
int lenghtSix = six.Split(",").Length; // Splits the input and determines the length
string[] fiveStringSplit = six.Split(","); // Splits the input and saves it into an Array of string type
int[] sixArrayInt = new int[lenghtSix]; // Creates an array of the size of the input
int[] sixArrayIntNewOrder = new int[lenghtSix]; // Creates an array of the size of the input
int indexNumberMove = 0; // To store the index of the number to be moved
int newIndexNumberMove = 0; // New position of the current number
int indexDifference = 0; // To save the distance between the element index and the end of the array


for(int i = 0; i < lenghtSix; i++) // Converts the string array into a int array
{
  sixArrayInt[i] = int.Parse(fiveStringSplit[i]);
}

Console.WriteLine("Please enter an one digit number");
int digit = int.Parse(Console.ReadLine());

foreach (var number in sixArrayInt)
{
  indexNumberMove = (Array.IndexOf(sixArrayInt, number));
  indexDifference = (lenghtSix - digit) - indexNumberMove;
  

  if (indexNumberMove + digit >= lenghtSix)
  {
    Console.WriteLine($"This is the number that passed the threshold {number}");
    newIndexNumberMove = indexDifference * -1;
    sixArrayIntNewOrder[newIndexNumberMove] = number;
  }
  else
  {
    newIndexNumberMove = indexNumberMove + digit;
    sixArrayIntNewOrder[newIndexNumberMove] = number;
  }
  
}
 
Console.WriteLine("[" + string.Join(',', sixArrayIntNewOrder) + "]");

///////////////////// Lists /////////////////////

/* Problem 1
 * Declare an empty list of student scores (floats)
 * Add multiple scores to the list
 * Remove all scores below 50 and Print scores.
 * Find the first student who scored above 90.
 * Print scores sorted in descending order.     ** Hint: Use Reverse() Method.
 * 
 */







/* Problem 2
 * Create a program that manages a contact list. Users should be able to:
 * Add a new contact (name and phone number).
 * Remove a contact by name.
 * Search for a contact by name (return all matches).
 * List all contacts in alphabetical order.
 *
 * Example 1:
   Contact Menu:
   1. Add a new contact
   2. Remove a contact
   3. Search for a contact
   4. List all contacts
   5. Exit
   
   Input: 
   Choose an option: 1
   Enter a name: Alice
   Enter a phone number: 123-456-7890
   
   Output: Contact Added: Alice, 123-456-7890
   
   
 * Example 2:
   Contact Menu:
   1. Add a new contact
   2. Remove a contact
   3. Search for a contact
   4. List all contacts
   5. Exit
   
   Input: 
   Choose an option: 2
   Enter a name: Alice
   
   Output: Contact Removed: Alice, 123-456-7890   
   
   
 * Example 3:
   Contact Menu:
   1. Add a new contact
   2. Remove a contact
   3. Search for a contact
   4. List all contacts
   5. Exit
   
   Input: 
   Choose an option: 3
   Enter a name: Alice
   
   Output: Search Result: Alice, 123-456-7890
                          Alice, 234-543-4332
                          Alice, 432-342-2993
   
   
   
 * Example 4:
   Contact Menu:
   1. Add a new contact
   2. Remove a contact
   3. Search for a contact
   4. List all contacts
   5. Exit
   
   Input: 
   Choose an option: 4
   
   Output: Contacts: Alice, 123-456-7890
                     Bob, 987-654-3210  
   
 */
 
