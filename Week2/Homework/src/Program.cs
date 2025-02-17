///////////////////// Week 1 Review /////////////////////
//
// /* Problem 1
//  
//  * Write a program to simulate an ATM menu with the following functionalities:
//  * Display the ATM Menu:
//     ** Check Balance
//     ** Deposit Money
//     ** Withdraw Money (ensure balance doesn't go negative)
//     ** Exit
//  *
//  *
//  * 
//  * Example 1
//  * Input:
//    ATM Menu:
//    1. Check Balance
//    2. Deposit Money
//    3. Withdraw Money
//    4. Exit
//    Choose an option: 1
//    
//    Output: Your balance is $0
//    
//  * Example 2
//  * Input:
//    ATM Menu:
//    1. Check Balance
//    2. Deposit Money
//    3. Withdraw Money
//    4. Exit
//    Choose an option: 2
//    Enter the amount to deposit: 100
//    
//  * Output: You have deposited $100. Your new balance is: $100
//  *
//  *
//  * Example 3
//  * Input:
//    ATM Menu:
//    1. Check Balance
//    2. Deposit Money
//    3. Withdraw Money
//    4. Exit
//    Choose an option: 3
//    Enter the amount to withdraw: 50
//    
//  * Output: You have withdrawn $50. Your new balance is: $50
//  *
//  *
//  * Example 4
//  * Input:
//    ATM Menu:
//    1. Check Balance
//    2. Deposit Money
//    3. Withdraw Money
//    4. Exit
//    Choose an option: 3
//    Enter the amount to withdraw: 100
//    
//  * Output: Insufficient funds. Withdrawal denied.
//  *
//  *
//  * Example 5
//  * Input:
//    ATM Menu:
//    1. Check Balance
//    2. Deposit Money
//    3. Withdraw Money
//    4. Exit
//    Choose an option: 4
//    
//  * Output: Thank you for using the ATM. Goodbye!
//    
//  */
//
// Console.WriteLine(
//   "Welcome. " +
//   "ATM Menu: " +
//   "1. Check Balance" +
//   "2. Deposit Money" +
//   "3. Withdraw Money" +
//   "4. Exit"
//   );
// int balance = 0;
// Console.WriteLine("Enter an option: ");
// int command = int.Parse(Console.ReadLine());
// switch (command)
// {
//   case 1:
//     Console.WriteLine("Your balance is " + balance);
//     break;
//   case 2:
//     Console.WriteLine("Enter an amount to deposit: ");
//     int depAmount = int.Parse(Console.ReadLine());
//     balance += depAmount;
//     break;
//   case 3:
//     Console.WriteLine("Enter an amount to withdraw: ");
//     int withAmount = int.Parse(Console.ReadLine());
//     if (withAmount <= balance)
//     {
//       balance -= withAmount;
//       Console.WriteLine("You have withdrew $" + withAmount + " your new balance is $" + balance);
//     }
//     else
//       Console.WriteLine("Insufficient balance");
//     break;
//   case 4:
//     Console.WriteLine("Exiting...");
//     break;
// }
//
//
//
//
//
//
//
// ///////////////////// Arrays /////////////////////
//  
// /* Problem 1
//  * 
//  * Declare and initialize two arrays of integers.
//  * Merge them into a single array.
//  * Sort the merged array in ascending order.
//  * Print the final sorted array.
//  *
//  * Solve this problem using array methods and also solve it without using array methods.
//  */
// int [] arrayOne = {1, 3, 5, 7};
// int [] arrayTwo = {2, 4, 6, 8, 0, 0, 0, 0 };
// arrayOne.CopyTo(arrayTwo, 4);
// Array.Sort(arrayTwo);
// Console.WriteLine(string.Join(",", arrayTwo));
// OR without array methods
// int[] arrayNew = new int[8];
// for (int i = 0; i < arrayOne.Length; i++)
// {
//   arrayNew[i] = arrayOne[i];
// }
// for (int i = 0; i < 4; i++)
// {
//   arrayNew[arrayOne.Length + i] = arrayTwo[i];
// }
// Array.Sort(arrayNew);
// Console.WriteLine(string.Join(", ", arrayNew));
//
//
//
//
//
//
// /* Problem 2
//  * 
//  * Declare and initialize an arrays of integers.
//  * Declare a variable for a target number.
//  * Find the first index where the number appears.
//  * Find the last index where the number appears.
//  * If the number is not in the array, return -1 for both indices.
//  * Print both indices.
//  *
//  * Solve this problem using array methods and also solve it without using array methods.
//  */
// int[] array2 = { 1, 4, 4, 8, 9, 10, 12 };
// int target = 4;
// int firstTarget = Array.FindIndex(array2, x => x == target);
// int[] allTarget = Array.FindAll(array2, x => x == target);
// Console.WriteLine("Index of first target: " + firstTarget);
// Console.WriteLine(string.Join(", ", allTarget));
// Array.Clear(array2, 0, firstTarget+1);
// int target2 = Array.FindIndex(array2, x => x == target);
// Console.WriteLine("Index of second target: " + target2);
//
//
// /* Problem 3
//  * 
//  * Ask user to enter integers separated by commas (,) and store them in an array. 
//  * Remove all even numbers and sort the remaining numbers in ascending order.
//  * Print the modified array.
//  *
//  * Example 1:
//  * Input: Enter integers separated by commas: 5,10,3,8,15,2,11,6
//  * Output: [3,5,11,15]
//  *
//  * Example 2:
//  * Input: Enter integers separated by commas: 4,7,9,12,13,18,21
//  * Output: [7,9,13,21]
//  *
//  *
//  *
//  * Hint 1: Try using Split() method to break a string into substrings. https://learn.microsoft.com/en-us/dotnet/api/system.string.split?view=net-9.0
//  *
//  * 
//  * Hint 2: Try using Joint() method to concatenate the string representation of an array using a specified separator between each element. https://learn.microsoft.com/en-us/dotnet/api/system.string.join?view=net-9.0
//  */
// Console.WriteLine("Enter integers seperated by commas:");
// string userInput = Console.ReadLine();
// int[] inputArray = userInput.Split(',').Select(x => int.Parse(x)).ToArray();
// int[] allOdd = Array.FindAll(inputArray, x => x%2 != 0);
// Array.Sort(allOdd);
// Console.WriteLine(string.Join(", ", allOdd));
//
//
//
//
// /* Problem 4
//  * 
//  * Ask user to enter integers separated by commas (,) and store them in an array.
//  * Determine which number appears the most times.
//  * If there are multiple numbers with the same highest frequency, return the smallest one.
//  * Print the most frequently occurring number.
//  *
//  * Example 1:
//  * Input: Enter integers separated by commas: 1,3,2,1,4,1,2,3,2
//  * Output: Number 1 appears 3 time(s).
//  * Explanation: The number 1 appears 3 times, which is the highest frequency.
//  *
//  * Example 2:
//  * Input: Enter integers separated by commas: 4,5,4,6,5,6,5,6
//  * Output: Number 5 appears 3 time(s).
//  * Explanation: Both 5 and 6 appear 3 times, but 5 is the smallest number among them.
//  *
//  * Example 3:
//  * Input: Enter integers separated by commas: 1,2,3,4,5
//  * Output: Number 1 appears 1 time(s).
//  * Explanation: Number 1 is the smallest number among them and it appears once.
//  *
//  *{1,3,5,3,1,6,3,2,1,2}
//  */
// Console.WriteLine("Enter integers seperated by commas:");
// string userIn = Console.ReadLine();
// int[] inArray = userIn.Split(',').Select(x => int.Parse(x)).ToArray();
// int arrayMode = 0;
// Array.Sort(inArray);
// int xNum1 = 0;
// int yNum1 = 1;  
// (int, int) tupleOne = (xNum1, yNum1);
// int xNum2 = 10;
// int yNum2 = 0;
// (int, int) tupleTwo = (xNum2, yNum2);
// for (int i = 1; i < inArray.Length; i++)
// {
//   if (inArray[i] == inArray[i - 1])
//   {
//     xNum1 = inArray[i];
//     yNum1++;
//   }
//
//   if (yNum1 > yNum2 && xNum1 < xNum2)
//   {
//     xNum2 = xNum1;
//     yNum2 = yNum1;
//     yNum1 = 0;
//   }
//   
// }
// Console.WriteLine("The number " + xNum2 + " occured most with " + yNum2 + " occurrences");



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

using System.Linq.Expressions;

// Console.WriteLine("Enter integers seperated by commas:");
// string userInput = Console.ReadLine();
// int[] userArray = userInput.Split(",").Select(x => int.Parse(x)).ToArray();
// for (int i = 0; i < userArray.Length; i++)
// {
//     if (userArray[i]<0)
//     {
//         int math = userArray[i];
//         userArray[i] = math * (-1);
//     }
// }
// Array.Sort(userArray);
// int over100 = Array.FindIndex(userArray, x => x > 100);
// int arrayLength = userArray.Length;
// int arrayMath = arrayLength - over100;
// int newLength = arrayLength - arrayMath;
// Array.Clear(userArray, over100, arrayMath);
// int[] newArray = new int[newLength];
// Array.Copy(userArray, newArray, newLength);
// Console.WriteLine(String.Join(",", newArray));



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
 *NOT DONE
 */ 
// Console.WriteLine("Please enter integers seperated by commas:");
// string input = Console.ReadLine();
// int[] array6 = input.Split(",").Select(x => int.Parse(x)).ToArray();
// Console.WriteLine("Enter an integer:");
// int shift = int.Parse(Console.ReadLine());
// int length6 = array6.Length;
// int count = 0;
// int first = array6[0];
// do
// {
//     foreach (int i in array6)
//     {
//         if (i == 0)
//         {
//             array6[i] = array6[length6 - 1];
//         }
//         else if (i == array6.Length)
//         {
//           array6[i] = array6[i - 1];
//         }
//         else array6[i] = array6[i - 1];
//     }
// } while (count<shift);


// ///////////////////// Lists /////////////////////
//
// /* Problem 1
//  * Declare an empty list of student scores (floats)
//  * Add multiple scores to the list
//  * Remove all scores below 50 and Print scores.
//  * Find the first student who scored above 90.
//  * Print scores sorted in descending order.     ** Hint: Use Reverse() Method.
//  * 
//  */
// List<float> scoreList = new List<float>();
// scoreList.AddRange([92f,91.7f,93.2f,46.3f,23f]);
// scoreList.RemoveAll(x=> x < 50);
// scoreList.Sort();
// scoreList.Reverse();
// Console.WriteLine(String.Join(",",scoreList));
//
//
// /* Problem 2
//  * Create a program that manages a contact list. Users should be able to:
//  * Add a new contact (name and phone number).
//  * Remove a contact by name.
//  * Search for a contact by name (return all matches).
//  * List all contacts in alphabetical order.
//  *
//  * Example 1:
//    Contact Menu:
//    1. Add a new contact
//    2. Remove a contact
//    3. Search for a contact
//    4. List all contacts
//    5. Exit
//    
//    Input: 
//    Choose an option: 1
//    Enter a name: Alice
//    Enter a phone number: 123-456-7890
//    
//    Output: Contact Added: Alice, 123-456-7890
//    
//    
//  * Example 2:
//    Contact Menu:
//    1. Add a new contact
//    2. Remove a contact
//    3. Search for a contact
//    4. List all contacts
//    5. Exit
//    
//    Input: 
//    Choose an option: 2
//    Enter a name: Alice
//    
//    Output: Contact Removed: Alice, 123-456-7890   
//    
//    
//  * Example 3:
//    Contact Menu:
//    1. Add a new contact
//    2. Remove a contact
//    3. Search for a contact
//    4. List all contacts
//    5. Exit
//    
//    Input: 
//    Choose an option: 3
//    Enter a name: Alice
//    
//    Output: Search Result: Alice, 123-456-7890
//                           Alice, 234-543-4332
//                           Alice, 432-342-2993
//    
//  * Example 4:
//    Contact Menu:
//    1. Add a new contact
//    2. Remove a contact
//    3. Search for a contact
//    4. List all contacts
//    5. Exit
//    
//    Input: 
//    Choose an option: 4
//    
//    Output: Contacts: Alice, 123-456-7890
//                      Bob, 987-654-3210  
//    
//  */
List<string> nameList = new List<string>(["Bella", "Bella"]);
List<string> numberList = new List<string>(["515-979-8888", "676-666-6666"]);
int nameCount = 0;
int numberCount = 0;

int exit = 1;

  do
  {
    Console.WriteLine("\nContact Menu:" +
                      "\n1. Add a new contact" +
                      "\n2. Remove a contact" +
                      "\n3. Search for a contact" +
                      "\n4. List all contacts" +
                      "\n5. Exit");
    int inputCommand = Int32.Parse(Console.ReadLine());
    switch (inputCommand)
    {
      case 1:
        Console.WriteLine("Enter a name:");
        nameList.Add(Console.ReadLine());
        Console.WriteLine("Enter a phone number");
        numberList.Add(Console.ReadLine());
        break;
      case 2:
        Console.WriteLine("Enter a name to remove:");
        string nameRemove = Console.ReadLine();
        if (false == nameList.Contains(nameRemove))
        {
          Console.WriteLine("No contact exists");
          break;
        }
        while (nameList.Contains(nameRemove))
        {
          int numberIndex = nameList.IndexOf(nameRemove);
          nameList.RemoveAt(numberIndex);
          numberList.RemoveAt(numberIndex);
        }
        Console.WriteLine("Contact Removed!");
        break;
      case 3:
        Console.WriteLine("Enter a name to search:");
        string nameSearch = Console.ReadLine();
        List<string> searchList = new List<string>();
        List<string> numberSearch = new List<string>();
        while (nameList.Contains(nameSearch))
        {
          int index = nameList.IndexOf(nameSearch);
          numberSearch.Add(numberList[index]);
          numberList.RemoveAt(index);
          searchList.Add(nameList[index]);
          nameList.RemoveAt(index);
        }
        Console.WriteLine(String.Join(",",nameList));
        for (int j = 0; j < searchList.Count; j++)
        {
          Console.WriteLine(searchList[j] + "," + numberSearch[j]);
        }
        foreach (string h in numberSearch)
        {
          numberList.Add(h);
        }

        foreach (string k in searchList)
        {
          nameList.Add(k);
        }
        break;
      case 4:
        for (int j = 0; j < nameList.Count; j++)
        {
          Console.WriteLine(nameList[j] + "," + numberList[j]);
        }
        break;
      case 5:
        exit = 0;
        break;
    }
  } while (exit != 0); 

