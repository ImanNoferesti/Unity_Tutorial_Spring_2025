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
 
// Console.WriteLine("Please enter the first number:");
// int numberOne = int.Parse(Console.ReadLine());
// Console.WriteLine("Please enter the second number");
// int numberTwo = int.Parse(Console.ReadLine());
// Console.WriteLine("Please choose an arithmetic operation from the following: +, -, *, /, %, this operation will be applied to the numbers provided");
// string operation = Console.ReadLine();
//
// int result = 0;
//
// if (operation == "+")
// {
//  result = numberOne + numberTwo;
//  Console.WriteLine($"The result of {numberOne} plus {numberTwo} is {result}");
// }
// else if (operation == "-")
// {
//  result = numberOne - numberTwo;
//  Console.WriteLine($"The result of {numberOne} minus {numberTwo} is {result}");
// }
// else if (operation == "*")
// {
//  result = numberOne * numberTwo;
//  Console.WriteLine($"The result of {numberOne} multiplied by {numberTwo} is {result}");
// }
// else if (operation == "/")
// {
//  result = numberOne / numberTwo;
//  Console.WriteLine($"The result of {numberOne} divided by {numberTwo} is {result}");
// }
// else if (operation == "%")
// {
//  result = numberOne % numberTwo;
//  Console.WriteLine($"The result of the residual of {numberOne} divided by {numberTwo} is {result}");
// }
// else
// {
//  Console.WriteLine("Invalid Operation!");
// }


 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
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
//
// Console.WriteLine("Please enter any year you want");
// int yearCurrent = int.Parse(Console.ReadLine());
//
// if (yearCurrent % 4 == 0)
// {
//  if (yearCurrent % 100 != 0 || yearCurrent % 400 == 0)
//  {
//   Console.WriteLine($"{yearCurrent} is a leap year.");
//  }
//  else
//  {
//   Console.WriteLine($"{yearCurrent} is not a leap year.");
//  }
// }
// else
// {
//  Console.WriteLine($"{yearCurrent} is not a leap year.");
// }





















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

// Console.WriteLine("Please enter your weight in pounds");
// int weight = int.Parse(Console.ReadLine());
// Console.WriteLine("Please enter your height in inches");
// int height = int.Parse(Console.ReadLine());
//
// double bmi = (weight / Math.Pow(height, 2)) * 703;
//
// switch (bmi)
// { 
//  case < 18.5:
//   Console.WriteLine($"BMI: {bmi}, Underweight");
//   break;
//  case >= 18.5 and < 24.9: // 18.5 <= BMI < 24.9: Normal weight
//   Console.WriteLine($"BMI: {bmi}, Normal weight");
//   break;
//  case >= 25 and < 29.9:  // 25 <= BMI < 29.9: Overweight
//   Console.WriteLine($"BMI: {bmi}, Overweight");
//   break;
//  case > 30: // BMI >= 30: Obesity
//   Console.WriteLine($"BMI: {bmi}, Obesity");
//   break;
// }


















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

// Console.WriteLine("Welcome to Goliath National Bank, please enter your information for a loan assessment");
// Console.WriteLine("Please enter your age:");
// int age = int.Parse(Console.ReadLine());
// Console.WriteLine("Please enter your annual income");
// int annualIncome = int.Parse(Console.ReadLine());
// Console.WriteLine("Do you have a co-signer (yes / no)");
// string cosigner = Console.ReadLine();
// Console.WriteLine("Please enter your credit score");
// int creditscore = int.Parse(Console.ReadLine());
//
// bool cosignerver = (cosigner == "yes"); // Declare outside to make it accessible later
//
// if (creditscore > 700 && age > 18)
// {
//  Console.WriteLine("Eligible for loan: Yes");
// }
// else if ((age > 18 && age < 25) && annualIncome > 25000 && cosignerver == true && (creditscore <= 699 && creditscore >=600))
// {
//  Console.WriteLine("Eligible for loan: Yes");
// }
// else if (age >= 25 && annualIncome > 25000 && (creditscore <= 699 && creditscore >=600))
// {
//  Console.WriteLine("Eligible for loan: Yes");
// }
// else if (creditscore > 600)
// {
//  Console.WriteLine("Eligible for loan: No");
// }
// else
// {
//  Console.WriteLine("Eligible for a loan: No");
// }


// If the person is under 25 years old, they must have a co-signer.
//  If the person has a credit score of 700 or above, they are automatically eligible regardless of other criteria.
//  If the person has a credit score between 600 and 699, they must meet all other criteria to be eligible.
//  If the person has a credit score below 600, they are not eligible for a loan.

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

// Console.WriteLine("Please enter the number of seconds you have in mind");
// int secondsEntered = int.Parse(Console.ReadLine());
//
// int minutes = secondsEntered / 60;
// int residualSeconds = secondsEntered % 60;
// int hours = minutes / 60;
// int residualHours = hours % 60;
//
// Console.WriteLine($"{hours} hour(s), {residualHours} minute(s), {residualSeconds} second(s)");