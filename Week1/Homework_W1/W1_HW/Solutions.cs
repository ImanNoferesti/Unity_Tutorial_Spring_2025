// Problem 1:

Console.WriteLine("Enter your first number");
float num1 = float.Parse(Console.ReadLine());

Console.WriteLine("Enter your second number");
float num2 = float.Parse(Console.ReadLine());

Console.WriteLine("Choose an arithmetic operation from the list below:\n" +
                  "+, -, *, /, %");
string @operator = Console.ReadLine();

switch (@operator)
{
    case "+":
        Console.WriteLine($"Result of {num1} + {num2} = {num1 + num2}");
        break;
    case "-":
        Console.WriteLine($"Result of {num1} - {num2} = {num1 - num2}");
        break;
    case "*":
        Console.WriteLine($"Result of {num1} * {num2} = {num1 * num2}");
        break;
    case "/":
        Console.WriteLine($"Result of {num1} / {num2} = {num1 / num2}");
        break;
    case "%":
        Console.WriteLine($"Result of {num1} % {num2} = {num1 % num2}");
        break;
    default:
        Console.WriteLine("Invalid Operation!");
        break;
}


// Problem 2

Console.WriteLine("\n\nEnter a year:");
int year = int.Parse(Console.ReadLine());

if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
{
    Console.WriteLine($"{year} is a leap year.");
}
else
{
    Console.WriteLine($"{year} is not a leap year.");
}


// Problem 3

Console.WriteLine("Enter your weight in pounds:");
float weight = float.Parse(Console.ReadLine());

Console.WriteLine("Enter your height in inches:");
float height = float.Parse(Console.ReadLine());

float bmi = weight / MathF.Pow(height, 2) * 703f;

switch (bmi)
{
    case < 18.5f:
        Console.WriteLine($"BMI: {bmi} (Underweight)");
        break;
    case >= 18.5f and <24.9f:
        Console.WriteLine($"BMI: {bmi} (Normal weight)");
        break;
    case > 25f and < 29.9f:
        Console.WriteLine($"BMI: {bmi} (Overweight)");
        break;
    case >= 30:
        Console.WriteLine($"BMI: {bmi} (Obesity)");
        break;
}


// Problem 4

Console.WriteLine("\n\nEnter age:");
int age = int.Parse(Console.ReadLine());

Console.WriteLine("Enter annual income:");
float annualIncome = float.Parse(Console.ReadLine());

Console.WriteLine("Do you have a co-signer (true / false):");
bool coSigner = bool.Parse(Console.ReadLine());

Console.WriteLine("Enter credit score:");
int creditScore = int.Parse(Console.ReadLine());

if (creditScore >= 700)
{
    Console.WriteLine("Eligible for loan: yes");
}
else if (creditScore >= 600)
{
    if (age >= 18 && annualIncome >= 25_000f)
    {
        Console.WriteLine("Eligible for loan: no");
    }
    else
    {
        Console.WriteLine("Eligible for loan: yes");
    }
}


// Problem 5

Console.WriteLine("\n\nEnter the total number of seconds:");
int seconds = int.Parse(Console.ReadLine());

int hours = seconds / 3600;
int minutes = (seconds % 3600) / 60;
seconds %= 60;

Console.WriteLine($"{hours} hour(s), {minutes} minute(s), {seconds} second(s)");