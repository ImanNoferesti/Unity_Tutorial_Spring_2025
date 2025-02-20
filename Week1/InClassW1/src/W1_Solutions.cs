// 1. Syntax and Declaring Variables
/*
  * Write a program to declare variables for your name, age, and a decimal value for your height in meters or inches.
  * Print them out in a single sentence.
*/

Console.WriteLine("To start:\nEnter your name:");
string name = Console.ReadLine();

Console.WriteLine("Great! Now enter your age:");
int age = int.Parse(Console.ReadLine());

Console.WriteLine("Perfect! How tall are you?");
float height = float.Parse(Console.ReadLine());

Console.WriteLine($"Hey {name}! You're {age} years old and {height} meters / inches tall. \n\n");



// 2. Display Variables and Declare Multiple Variables
// Declare three integers (x, y, z) on a single line, assign values to them, and display their sum.

int x = 5, y = 7, z = -2;
int sum = x + y + z;

Console.WriteLine($"Sum of {x} + {y} + {z} = {sum}\n\n");


// 3. Min and Max Values
// Write a program that displays the minimum and maximum values for int and double data types.

Console.WriteLine($"Int Max: {int.MaxValue}\n" +
                  $"Int Min: {int.MinValue}\n" +
                  $"Double Max: {double.MaxValue}\n" +
                  $"Double Min: {double.MinValue}\n\n");


// 4. Strings
/*
*  Write a program that asks the user for their first name and last name.
*  Print the length of their first name.
*  Concatenate the user's first name and last name and display the full name.
*  Print the user's initials using the full name
*/

Console.WriteLine("Welcome! Enter your first name:");
string firstName = Console.ReadLine();

Console.WriteLine("Enter your last name:");
string lastName = Console.ReadLine();

Console.WriteLine($"\nYour first name has {firstName.Length} characters.");

string fullName = firstName + " " + lastName;
Console.WriteLine($"Your full name is: {fullName}");

Console.WriteLine($"Your initials are: {fullName[0]}{fullName[firstName.Length+1]}\n\n");



// 5. Arithmetic and Assignment Operators
/*
* Create a simple calculator that performs addition, subtraction, multiplication, and division between two numbers.
* Use assignment operators.
*/

float result = 0f;
Console.WriteLine($"result is: {result}");

float num = 5;
result += num;
Console.WriteLine($"Added {num}! New result is: {result}");

num = 3;
result -= num;
Console.WriteLine($"Subtracted {num}! New result is: {result}");

num = 8;
result *= num;
Console.WriteLine($"Multiplied by {num}! New result is: {result}");

num = 2;
result /= num;
Console.WriteLine($"Divided by {num}! New result is: {result}\n\n");
 

 
// 6. If-else statements and Logical Operators
/*
* Ask the user to enter their age and if they have a driving license (true/false).
* Check if the user is old enough to drive (at least 18 years old) and has a license.
* Use logical AND and OR operators to handle different cases.
*/
 
Console.WriteLine("Enter your age:");
age = int.Parse(Console.ReadLine());

Console.WriteLine("Do you have a driving license? (true / false)");
bool hasDl= bool.Parse(Console.ReadLine());

if (age >= 18 && hasDl)
{
    Console.WriteLine("You can drive a car!");
}
else if (age >= 18 && !hasDl)
{
    Console.WriteLine("You need to get a driving license!");
}
else
{
    Console.WriteLine("You're not old enough to drive by yourself!");
}
 
 
// 7. Switch Statement
/*
* Write a program that asks the user to input a number between 1 and 10.
* Use a switch statement to show if the user input is divisible by 5.
* Print a message if the input number is divisible.
* If the input is invalid, display " Invalid number."
*/

Console.WriteLine("\n\nChoose a number between 1 to 10:");
num = int.Parse(Console.ReadLine());

if (num < 1 || num > 10)
{
    Console.WriteLine("Invalid number");
}
else
{
    switch (num % 5)
    {
        case 0:
            Console.WriteLine($"{num} is divisible by 5!");
            break;
        default:
            Console.WriteLine($"{num} is NOT divisible by 5!");
            break;
    }
}
  
  
  
  
  
// 8. While loop
// Write a program to print all even numbers between 1 and 20 using a while loop.

num = 1;
Console.WriteLine("\n\nEven numbers between 1-20:");
while (num <= 20)
{
    if (num % 2 == 0)
    {
        Console.WriteLine(num);
    }

    num++;
}
  
  

  
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

string correctPass = "1234", enteredPass = "";
do
{
    Console.WriteLine("\n\nEnter the password:");
    enteredPass = Console.ReadLine();
    if (enteredPass != correctPass)
    {
        Console.WriteLine("Wrong password, try again.");
    }
} while (enteredPass != correctPass);

Console.WriteLine("Access granted!\n\n");
   
   
// 10. For Loop Statement:
/*
 * Write a program to calculate the factorial of a number using a for loop.
 *
 * Sample Input/Output:
 *  Enter a number: 5
 *  Factorial of 5 is 120.
 */
 
Console.WriteLine("Enter a number:");
int number = int.Parse(Console.ReadLine());
int factorial = 1;

for (int i = number; i > 0; i--)
{
    factorial *= i;
}

Console.WriteLine($"Factorial of {number} is {factorial}");