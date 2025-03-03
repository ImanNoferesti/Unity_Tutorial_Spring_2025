// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter change in price, then change in quant");

int deltaPrice = int.Parse(Console.ReadLine());
int deltaQuant = int.Parse(Console.ReadLine());
double deadweightLoss = (deltaQuant + deltaPrice)/2;
Console.WriteLine(deadweightLoss.ToString());