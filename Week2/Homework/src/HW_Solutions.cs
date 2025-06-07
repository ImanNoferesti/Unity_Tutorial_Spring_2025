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

Console.WriteLine("====== W1-Review ======");

int option = 0;
float balance = 0,
    deposit = 0,
    withdraw = 0;


while (option != 4)
{
    Console.WriteLine("ATM Menu:\n" +
                      "1. Check Balance\n" +
                      "2. Deposit Money\n" +
                      "3. Withdraw Money\n" +
                      "4. Exit\n" +
                      "Choose an option:");
    option = int.Parse(Console.ReadLine());

    switch (option)
    {
        case 1:
            Console.WriteLine($"Your balance is ${balance}");
            break;
        case 2:
            Console.WriteLine($"Enter the amount to deposit: ");
            deposit = float.Parse(Console.ReadLine());
            balance += deposit;
            Console.WriteLine($"You have deposited ${deposit}. Your new balance is: ${balance}");
            break;
        case 3:
            Console.WriteLine($"Enter the amount to withdraw: ");
            withdraw = float.Parse(Console.ReadLine());
            if (balance - withdraw < 0)
            {
                Console.WriteLine("Insufficient funds. Withdrawal denied.");
            }
            else
            {
                balance -= withdraw;
                Console.WriteLine($"You have withdrawn ${withdraw}. Your new balance is: ${balance}");
            }

            break;
        case 4:
            Console.WriteLine("Thank you for using the ATM. Goodbye!");
            break;
        
    }
    
}


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

Console.WriteLine("\n====== Arrays - Problem 1 ======");

int[] arr1 = new int[] { 1, 2, 3, 4, 5 };
int[] arr2 = new int[] { 6, 7, 8, 9, 10 };
int[] mergedArray = new int[arr1.Length + arr2.Length];

Array.Copy(arr1, mergedArray, arr1.Length);
arr2.CopyTo(mergedArray, arr1.Length);
Array.Sort(mergedArray);

Console.WriteLine($"Final Sorted Array: [" + string.Join(',', mergedArray) + "]");


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

Console.WriteLine("\n====== Arrays - Problem 2 ======");

arr1 = new int[] { 1, 2, 3, 2, 2, 3, 4, 5, 1, 4 };

int target = 6;
int firstIndex = Array.FindIndex(arr1, x => x == target);
int lastIndex = Array.FindLastIndex(arr1, x => x == target);

Console.WriteLine($"Target value first appears at index {firstIndex}, " +
                  $"and last appears at index {lastIndex}");




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
 
Console.WriteLine("\n====== Arrays - Problem 3 ======\nEnter integers separated by commas:");

string input = Console.ReadLine();
string[] nums = input.Split(',');

nums = Array.FindAll(nums, x => int.Parse(x) % 2 != 0);
int[] numbers = new int[nums.Length];

for (int i = 0; i < nums.Length; i++)
{
 numbers[i] = int.Parse(nums[i]);
}

Array.Sort(numbers);
Console.WriteLine("[" + string.Join(',', numbers) + "]");


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

Console.WriteLine("\n====== Arrays - Problem 4 ======\nEnter integers separated by commas:");

input = Console.ReadLine();
nums = input.Split(',');
numbers = new int[nums.Length];

for(int i=0; i < nums.Length; i++)
{
 numbers[i] = int.Parse(nums[i]);
}

Array.Sort(numbers);
int count=1, smallest = numbers[0], highestFrequency = 1;

for (int i = 1; i < numbers.Length; i++)
{
 if (numbers[i] == numbers[i - 1])
 {
  count++;
  if (count > highestFrequency)
  {
      highestFrequency = count; 
      smallest = numbers[i];
  }
 }
 else
 {
  count = 1;
 }
}

Console.WriteLine($"Number {smallest} appears {highestFrequency} time(s).");



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

Console.WriteLine("\n====== Arrays - Problem 5 ======\nEnter integers separated by commas:");

input = Console.ReadLine();
nums = input.Split(',');
numbers = new int[nums.Length];

for (int i = 0; i < nums.Length; i++)
{
 numbers[i] = (int) MathF.Abs(int.Parse(nums[i]));
}

numbers = Array.FindAll(numbers, x => x < 100);
Array.Sort(numbers);

Console.WriteLine("[" + string.Join(',', numbers) + "]");



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
 
Console.WriteLine("\n====== Arrays - Problem 6 ======\nEnter integers separated by commas:");

input = Console.ReadLine();
nums = input.Split(',');

Console.WriteLine("Enter an integer for N:");
int n = int.Parse(Console.ReadLine());

numbers = new int[nums.Length];

for (int i = 0; i < nums.Length; i++)
{
 int position = (i + n) % nums.Length;
 numbers[position] = int.Parse(nums[i]);
}

Console.WriteLine("[" + string.Join(',',numbers) + "]");
 
 
///////////////////// Lists /////////////////////

/* Problem 1
 * Declare an empty list of student scores (floats)
 * Add multiple scores to the list
 * Remove all scores below 50 and Print scores.
 * Find the first student who scored above 90.
 * Print scores sorted in descending order.     ** Hint: Use Reverse() Method.
 * 
 */
Console.WriteLine("\n====== Lists - Problem 1 ======");

List<float> scores = new List<float>();
scores.AddRange(new List<float>(){32.5f, 67.8f, 45.0f, 89.3f, 72.5f, 99.1f, 55.5f, 77.0f, 83.9f});
scores.RemoveAll(x => x < 50f);

Console.WriteLine("Scores after Removing all scores < 50: [" + 
                  string.Join(',', scores) +
                  "]");

int firstStudent = scores.FindIndex(x => x > 90);
Console.WriteLine($"The first student who scored above 90 is at index: {firstStudent} in the list");

scores.Sort();
scores.Reverse();

Console.WriteLine("[" + string.Join(',', scores) + "]");



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
 
Console.WriteLine("\n====== Lists - Problem 2 ======");

option = 0;
List<string> names = new List<string>();
List<string> phoneNumbers = new List<string>();

do
{
    Console.WriteLine("\nContact Menu:" +
                      "\n1. Add a new contact" +
                      "\n2. Remove a contact" +
                      "\n3. Search for a contact" +
                      "\n4. List all contacts" +
                      "\n5. Exit" +
                      "\n\nEnter an option:");
    
    option = int.Parse(Console.ReadLine());

    switch (option)
    {
        case 1:
            Console.WriteLine("Enter a name:");
            names.Add(Console.ReadLine());
            
            Console.WriteLine("Enter a phone number:");
            phoneNumbers.Add(Console.ReadLine());
            
            Console.WriteLine($"Contact Added: {names[names.Count-1]}, " +
                              $"{phoneNumbers[phoneNumbers.Count-1]}");
            break;
        
        case 2:
            Console.WriteLine("Enter a name:");
            string name = Console.ReadLine();
            int nameIndex = names.IndexOf(name);
            string phoneNum = phoneNumbers[nameIndex];
            
            names.Remove(name);
            phoneNumbers.Remove(phoneNum);
            
            Console.WriteLine($"Contact Removed: {name}, " +
                              $"{phoneNum}");
            break;
        
        case 3:
            Console.WriteLine("Enter a name:");
            name = Console.ReadLine();

            for (int i = 0; i < names.Count; i++)
            {
                if (names[i] == name)
                {
                    Console.WriteLine($"Search Result: {name}, " +
                                      $"{phoneNumbers[i]}");
                }
            }
            break;
        
        case 4:
            Console.WriteLine("Contacts:");
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine($"{names[i]}, {phoneNumbers[i]}");
            }
            
            break;
        
        case 5:
            Console.WriteLine("Goodbye!");
            break;
        
        default:
            Console.WriteLine("Invalid Option, Try again!");
            break;
    }

} while (option != 5);

