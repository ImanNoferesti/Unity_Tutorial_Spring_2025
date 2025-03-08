// // 1. Syntax and Declaring Variables
// /*
//   * Write a program to declare variables for your name, age, and a decimal value for your height in meters or inches.
//   * Print them out in a single sentence.
// */
//
//
// string name = "Fernando";
// int age = 31;
// double height = 1.83; // meters
//
// Console.WriteLine($"The person's name is {name}, they are {age}, and their height is {height}");
//
// // 2. Display Variables and Declare Multiple Variables
// // Declare three integers (x, y, z) on a single line, assign values to them, and display their sum.
//
// int x = 1,
//   y = 2,
//   z = 3;
//
// int sum = x + y + z;
//
// Console.WriteLine(sum);
//
// // 3. Min and Max Values
// // Write a program that displays the minimum and maximum values for int and double data types.
//
// Console.WriteLine($"Int Max: {int.MaxValue}\n" +
//                   $"Int Min: {int.MinValue}\n" +
//                   $"Double Max: {double.MaxValue}\n" +
//                   $"Double Min: {double.MinValue}\n\n");
//
//
// // 4. Strings
// /*
// *  Write a program that asks the user for their first name and last name.
// *  Print the length of their first name.
// *  Concatenate the user's first name and last name and display the full name.
// *  Print the user's initials using the full name
// */
//
// Console.WriteLine("Enter your first name");
// string fname = Console.ReadLine();
//
// Console.WriteLine("Please enter your last name");
// string lname = Console.ReadLine();
//
// Console.WriteLine($"Lenght of the first name is {fname.Length}");
//
// string f_and_l_name = fname + " " + lname;
//
// Console.WriteLine(f_and_l_name);
//
// Console.WriteLine($"Your initials are {fname[0]}.{lname[0]}.");

// 5. Arithmetic and Assignment Operators
/*
* Create a simple calculator that performs addition, subtraction, multiplication, and division between two numbers.
* Use assignment operators.
*/

// float result = 0f;
// Console.WriteLine($"Your result is: {result}");
//
// float num = 20f;
// result += num;
// Console.WriteLine($"Your new result from the addition {result}");
//
// float nums = 5f;
// result -= nums;
// Console.WriteLine($"Your new result from the subtraction is {result}");
//
// result *= nums;
// Console.WriteLine($"Your new result from the multiplication is {result}");
//
// result /= nums;
// Console.WriteLine($"Your new result from the division is {result}");

// 6. If-else statements and Logical Operators
/*
* Ask the user to enter their age and if they have a driving license (true/false).
* Check if the user is old enough to drive (at least 18 years old) and has a license.
* Use logical AND and OR operators to handle different cases.
*/

// Console.WriteLine("Please enter your age:"); 
// int age = int.Parse(Console.ReadLine());
//
// Console.WriteLine("Do you have a driving license? (true / false)");
// bool hasDl= bool.Parse(Console.ReadLine());
//
// if (age >= 18 && hasDl == true)
// {
//     Console.WriteLine("You can drive a car!");
// }
// else if (age >= 18 && hasDl == true)
// {
//     Console.WriteLine("You need to get a driving license");
// }
// else
// {
//     Console.WriteLine("You are not old enough to get a driving license");
// }


// 7. Switch Statement
/*
* Write a program that asks the user to input a number between 1 and 10.
* Use a switch statement to show if the user input is divisible by 5.
* Print a message if the input number is divisible.
* If the input is invalid, display " Invalid number."
*/

// Console.WriteLine("Please enter a number between 1 and 10");
// int number = int.Parse(Console.ReadLine());
//
// if (number < 1 || number > 10)
// {
// Console.WriteLine("Invalid number");
// }
// else
// {
//     switch (number % 5)
//     {
//         case 0:
//             Console.WriteLine($"{number} is divisible by 5!");
//             break;
//         default:
//             Console.WriteLine($"{number} is not divisible by 5!");
//             break;
//     }
// }

  
// 8. While loop
// Write a program to print all even numbers between 1 and 20 using a while loop.

// int counter = 0;
//
// while (counter < 20)
// {
//     counter += 1;
//     Console.WriteLine(counter);
// }

  
// 9. Do-While loop
/*
* Create a program that asks the user for a password in a do-while loop and continues to prompt until they enter "1234"
*
* Sample Input/Output:
*    Enter the password: 0000
*    Wrong password, try again.
*    Enter the password: 1234
*    Access granted!
*/

// string correct = "1234", entered = "";
//
// do
// {
//     Console.WriteLine("Please enter the password");
//     entered = Console.ReadLine();
//
//     if (entered == "1234")
//     {
//         Console.WriteLine("Access granted!");
//     }
//     else
//     {
//         Console.WriteLine("Wrong password, try again.");
//     }
// } while (correct != entered);

   
// 10. For Loop Statement:
/*
 * Write a program to calculate the factorial of a number using a for loop.
 *
 * Sample Input/Output:
 *  Enter a number: 5
 *  Factorial of 5 is 120.
 */

Console.WriteLine("Please enter the number 5");
int number = int.Parse(Console.ReadLine());
int factorial = 1;

 for (int i = number; i > 1; i--)
 {
  factorial *= i;
 }
 
 Console.WriteLine($"Factorial number of {number} is {factorial}");