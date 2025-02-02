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
float output;
Console.WriteLine("Please enter a number:");
float inOne = float.Parse(Console.ReadLine());
Console.WriteLine("Please enter a second number:");
float inTwo = float.Parse(Console.ReadLine());
Console.WriteLine("Please enter an operation (+, -, *, /, %):");
string operation = Console.ReadLine();
if (operation == "+")
{
 output = inOne + inTwo;
 Console.WriteLine(inOne + " " + operation + " " + inTwo + " " + "=" + " " + output);
}
else if (operation == "-")
{
 output = inOne - inTwo;
 Console.WriteLine(inOne + " " + operation + " " + inTwo + " " + "=" + " " + output);
}
else if (operation == "*")
{
 output = inOne * inTwo;
 Console.WriteLine(inOne + " " + operation + " " + inTwo + " " + "=" + " " + output);
}
else if (operation == "/")
{
 output = inOne / inTwo;
 Console.WriteLine(inOne + " " + operation + " " + inTwo + " " + "=" + " " + output);
}
else if (operation == "%")
{
 output = inOne % inTwo;
 Console.WriteLine(inOne + " " + operation + " " + inTwo + " " + "=" + " " + output);
}
else Console.WriteLine("Operation not recognized");

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
 
Console.WriteLine("Enter a year to see if it is a leap year:");
int year = int.Parse(Console.ReadLine());
bool four = false;
bool hund = false;
bool fourHund = false;
if (year % 100 == 0)
 hund = true;
if (year % 4 == 0)
 four = true;
if (year % 400 == 0)
 fourHund = true;
if (hund == true & fourHund == false)
 Console.WriteLine("Year is not a leap year");
else if (four == true && hund == false)
 Console.WriteLine("Year is a leap year");
else Console.WriteLine("Year is not a leap year");


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

Console.WriteLine("Enter your weight (in lbs):");
float weight = float.Parse(Console.ReadLine());
Console.WriteLine("Enter your height (in inches):");
float height = float.Parse(Console.ReadLine());
float bmi = weight / (height*height)*703;
switch (bmi)
{
 case float n when (n < 18.5):
  Console.WriteLine("BMI: " + bmi + " (Underweight)");
  break;
 case float n when (18.5 <= n && n < 24.9):
  Console.WriteLine("BMI: " + bmi + " (Normal Weight)");
  break;
 case float n when (25 <= n && n < 29.9):
  Console.WriteLine("BMI: " + bmi + " (Overweight)");
  break;
 case float n when 30 <= n:
  Console.WriteLine("BMI: " + bmi + " (Obese)");
  break;
 default:
  Console.WriteLine("You did something wrong");
  break;
}



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

Console.WriteLine("Enter your age (in years):");
int age = int.Parse(Console.ReadLine());
Console.WriteLine("Enter your annual income:");
int income = int.Parse(Console.ReadLine());
Console.WriteLine("Do you have a cosigner (true/false):");
bool cosigner = bool.Parse(Console.ReadLine());
Console.WriteLine("Enter your credit score:");
int credit = int.Parse(Console.ReadLine());
if (credit >= 700)
 Console.WriteLine("You are eligible for a loan");
else if (credit < 600)
 Console.WriteLine("Your are not eligible for a loan");
else if (age < 18)
 Console.WriteLine("You are not eligible for a loan");
else if (18 <= age && age < 25 && cosigner == true && income >= 25000)
 Console.WriteLine("You are eligible for a loan");
else if (age > 25 && income >= 25000)
 Console.WriteLine("You are eligible for a loan");
else Console.WriteLine("You are not eligible for a loan");







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

Console.WriteLine("Enter number of seconds:");
int secondsIn = int.Parse(Console.ReadLine());
int mins = secondsIn / 60;
int secondsRem = secondsIn % 60;
int hours = mins / 60;
int minsRem = mins % 60;
Console.WriteLine(hours + " hour(s) " + minsRem + " minute(s) " + secondsRem + " second(s) ");