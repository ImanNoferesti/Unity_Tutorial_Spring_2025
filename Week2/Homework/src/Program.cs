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
 
