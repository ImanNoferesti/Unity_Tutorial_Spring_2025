/*
Problem #1:

Write a program that:

Takes two numbers as input from the user.
Allows the user to choose an arithmetic operation from the following: +, -, *, /, %.
Displays the result of the chosen operation.
If the user selects an operator other than the ones listed above, the program should display "Invalid Operation!".

Example 1:

Input 1: 5
Input 2: 4
Input 3: *
Output: Result of 5 * 4 = 20


Example 2:

Input 1: 3.5
Input 2: 9.8
Input 3: ^
Output: Invalid Operation!

 */
 
Console.WriteLine("Please enter the first number:");
float num1 = float.Parse(Console.ReadLine());

Console.WriteLine("Please enter the second number:");
float num2 = float.Parse(Console.ReadLine());

Console.WriteLine("Please select an operation (1 - 5)");
Console.WriteLine("1: addition");
Console.WriteLine("2: subtraction");
Console.WriteLine("3: multiplication");
Console.WriteLine("4: division");
Console.WriteLine("5: modulus");
int selection = int.Parse(Console.ReadLine());

float answer = -1f;
switch (selection)
{
 case 1: // addtion
   answer = num1 + num2;
  break;
 case 2: // subtraction
  answer = num1 - num2;
  break;
 case 3: // multiplication
  answer = num1 * num2;
  break;
 case 4: // division
  answer = num1 / num2;
  break;
 case 5:
  answer = num1 % num2;
  break;
 default:
  Console.WriteLine($"Sorry, {selection} is not an option.");
  break;
}

if (answer != -1)
 Console.WriteLine($"The answer is {answer}.");

Console.WriteLine();

 
 
 /*
Problem #2:

Write a C# program that determines whether a given year is a leap year. A year is a leap year if:

It is divisible by 4,
But not divisible by 100,
Unless it is also divisible by 400.

Example 1:

Input: Enter a year: 2020
Output: 2020 is a leap year.


Example 2:

Input: Enter a year: 1900
Output: 1900 is not a leap year.


Example 3:

Input: Enter a year: 2000
Output: 2000 is a leap year.


Example 4:

Input: Enter a year: 2021
Output: 2021 is not a leap year.

*/

Console.WriteLine("Please enter a year:");
int year = int.Parse(Console.ReadLine());

bool leapYear = false;
if ( (year % 400 == 0) || ( (year % 4 == 0) && (year % 100 != 0) ) )
{
 leapYear = true;
}

string verb = "was";
if (year > 2025)
{
 verb = "will be";
}
else if (year == 2025)
{
 verb = "is";
}
Console.WriteLine($"It is {leapYear} that {year} {verb} a leap year.");

Console.WriteLine();

/*
 Problem #3:
 
Write a program that calculates the Body Mass Index (BMI) based on the user's weight (in pounds) and height (in inches) using this formula: weight / (height ^2) x 703. The program should then categorize the BMI as follows:

BMI < 18.5: Underweight
18.5 <= BMI < 24.9: Normal weight
25 <= BMI < 29.9: Overweight
BMI >= 30: Obesity

*** Solve using switch statement ***

Example 1:

Input: 
Enter your weight in pounds: 160
Enter your height in inches: 70

Output: BMI: 22.95 (Normal weight)


Example 2:

Input: 
Enter your weight in pounds: 230
Enter your height in inches: 72

Output: BMI: 31.19 (Obesity)

*/





/*
Problem #4:

Write a program that determines if a person is eligible for a loan based on the following criteria:

The person must be at least 18 years old.
The person must have a minimum annual income of $25,000.
If the person is under 25 years old, they must have a co-signer.
If the person has a credit score of 700 or above, they are automatically eligible regardless of other criteria.
If the person has a credit score between 600 and 699, they must meet all other criteria to be eligible.
If the person has a credit score below 600, they are not eligible for a loan.


Example 1:

Input:
Enter age: 22
Enter annual income: 30000
Do you have a co-signer (true/false): true
Enter credit score: 650

Output:
Eligible for loan: Yes


Example 2:

Input:
Enter age: 30
Enter annual income: 20000
Do you have a co-signer (true/false): false
Enter credit score: 720

Output:
Eligible for loan: Yes


Example 3:

Input:
Enter age: 19
Enter annual income: 26000
Do you have a co-signer (true/false): false
Enter credit score: 580

Output:
Eligible for loan: No


Example 4:

Input:
Enter age: 25
Enter annual income: 27000
Do you have a co-signer (true/false): false
Enter credit score: 680

Output:
Eligible for loan: Yes


Example 5:

Input:
Enter age: 24
Enter annual income: 24000
Do you have a co-signer (true/false): true
Enter credit score: 650

Output:
Eligible for loan: No

 */

Console.WriteLine("Please enter your age in years: ");
float age = float.Parse(Console.ReadLine());

Console.WriteLine("Please enter your annual income in US dollars: ");
float income = float.Parse(Console.ReadLine());

Console.WriteLine("Please enter your credit score or if you do not know your credit score enter N/A: ");
string creditResponse = Console.ReadLine();

int creditScore;
if (creditResponse == "N/A")
{
 creditScore = -1;
}
else
{
 creditScore = int.Parse(creditResponse);
}

Console.WriteLine("Is there an eligible co-signer for this loan (y/n)?");
char cosigner = char.Parse(Console.ReadLine());

int eligibility = 999;
if (creditScore > 0)
{
 eligibility = 1; // eligible
 if (creditScore < 600)
 {
  eligibility = 0;
 }
 else if (  (creditScore < 700) && (cosigner == 'n') )
 {
  eligibility = 0;
 }
}

switch (eligibility)
{
 case 0:
  Console.WriteLine("We are sorry, you are not eligible for a loan at this time.");
  break;

 case 1:
  Console.WriteLine("Congratulations, you are elgible for a loan.");
  break;

 case 999:
  Console.WriteLine("You may be eligible for a loan, depending on what your credit score is.");
  break;
}

Console.WriteLine();

/*
 Problem #5:

 Write a program that converts a given number of seconds into hours, minutes, and seconds.
 The program should take an integer input representing the total number of seconds and output the equivalent time in hours, minutes, and seconds.

Example 1:
Input: Enter the total number of seconds: 3665
Output: 1 hour(s), 1 minute(s), 5 second(s)

Example 2:
Input: Enter the total number of seconds: 7322
Output: 2 hour(s), 2 minute(s), 2 second(s)

 */

Console.WriteLine("Please enter number of seconds: ");
int numSecs = int.Parse(Console.ReadLine());

int numHours = numSecs / 3600; 
int remainingSecs = numSecs % 3600;
int numMins = remainingSecs / 60;
numSecs = numSecs % 60;

Console.WriteLine($"{numHours} hour(s), {numMins} minute(s), {numSecs} second(s)");
