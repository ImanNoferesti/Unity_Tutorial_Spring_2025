// 1. Syntax and Declaring Variables
/*
 * Write a program to declare variables for your name, age, and a decimal value for your height in meters or inches.
 * Print them out in a single sentence.
 */
string name = "Kade";
int age = 20;
double height = 1.88; //meters

Console.WriteLine($"My name is {name}, my age is {age}, my height is {height} meters.");

  




// 2. Display Variables and Declare Multiple Variables
// Declare three integers (x, y, z) on a single line, assign values to them, and display their sum.

int x = 2, y = 1, z = 5;
int sum = x + y + z;
Console.WriteLine($"The sum of {x}, {y}, and {z} is {sum}");




// 3. Min and Max Values
// Write a program that displays the minimum and maximum values for int and double data types.
string maxInt = int.MaxValue;
string minInt = int.MinValue;
string maxDouble = double.MaxValue;
string minDouble = double.MinValue;

Console.WriteLine($"Maximum for Integer: {maxInt}, Minimum for Integer: {minInt}, For double: {maxDouble}, {minDouble}");







// 4. Strings
/*
 *  Write a program that asks the user for their first name and last name.
 *  Print the length of their first name.
 *  Concatenate the user's first name and last name and display the full name.
 *  Print the user's initials using the full name
 */
Console.WriteLine("Enter your first name:");
string firstName = Console.ReadLine();
Console.WriteLine("Enter your last name:");
string lastName = Console.ReadLine();
char firstInitial = firstName[0];
char lastInitial = lastName[0];
string Name = (firstName + " " + lastName);
Console.WriteLine(Name);
Console.WriteLine(firstInitial + " " + lastInitial);






// 5. Arithmetic and Assignment Operators
/*
* Create a simple calculator that performs addition, subtraction, multiplication, and division between two numbers.
* Use assignment operators.
*/
Console.WriteLine("Enter a number:");
string firstNumber = Console.ReadLine();
double firstDouble = System.Convert.ToDouble(firstNumber);
Console.WriteLine("Enter another number:");
string secondNumber = Console.ReadLine();
double secondDouble = System.Convert.ToDouble(secondNumber);
double sumNumber = firstDouble + secondDouble;
Console.WriteLine("The sum of the numbers is " + sumNumber);
double subNumber = firstDouble - secondDouble;
Console.WriteLine("The subtraction of the numbers is " + subNumber);
double multiplyNumber = firstDouble * secondDouble;
Console.WriteLine("The multiplication of the numbers is " + multiplyNumber);
double divideNumber = firstDouble / secondDouble;
Console.WriteLine("The division of the numbers is " + divideNumber);

 
 

 
// 6. If-else statements and Logical Operators
/*
* Ask the user to enter their age and if they have a driving license (true/false).
* Check if the user is old enough to drive (at least 18 years old) and has a license.
* Use logical AND and OR operators to handle different cases.
*/
Console.WriteLine("Enter your age:");
string age = Console.ReadLine();
int ageInt = Int32.Parse(age);
Console.WriteLine("Do you have a driver's license? Enter true or false:");
string driversLicense = Console.ReadLine();
bool ageBool = false;
bool licenseBool = false;
if (ageInt >= 18)
{
    ageBool = true;
}
if (driversLicense == "true")
{
    licenseBool = true; 
}    
if (licenseBool == true)
    if (ageBool = true)
        Console.WriteLine("You are able to drive");
    else Console.WriteLine("You are not able to drive");
else Console.WriteLine("You are not able to drive");

 
// 7. Switch Statement
/*
* Write a program that asks the user to input a number between 1 and 10.
* Use a switch statement to show if the user input is divisible by 5.
* Print a message if the input number is divisible.
* If the input is invalid, display " Invalid number."
*/
Console.WriteLine("Enter a number 1-10:");
int number = Convert.ToInt32(Console.ReadLine());
string numm = number.ToString();
switch (number)
{
    case 5:
    case 10:
        Console.WriteLine( $"{numm} is divisible by 5");
        break;
    default:
        Console.WriteLine($"{numm} is not divisible by 5");
        break;
}
  
  
  
  
  
  
// 8. While loop
// Write a program to print all even numbers between 1 and 20 using a while loop.
int count = 0;
while (count < 20)
{
    count++;
    Console.WriteLine(count);
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
int correctPass = 1234;
int password;
do
{
    Console.WriteLine("Enter the password (4 digits):");
    password = Convert.ToInt32(Console.ReadLine());
    if (password != correctPass)
        Console.WriteLine("Incorrect password. Try again.");
}   while (password != correctPass);
Console.WriteLine("Access Granted.");




   
   
   
// 10. For Loop Statement:
/*
 * Write a program to calculate the factorial of a number using a for loop.
 *
 * Sample Input/Output:
 *  Enter a number: 5
 *  Factorial of 5 is 120.
 */
Console.WriteLine("enter an integer number:");
int i = Convert.ToInt32(Console.ReadLine());
int factorial = 1;
for (int j = i; j > 0; j--)
{
    factorial *= j;
}
Console.WriteLine(factorial);
 