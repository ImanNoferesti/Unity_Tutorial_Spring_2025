using src;

// ******************** Step 2 ******************** 
Person personA = new Person();
Person personB = new Person();

personA.Name = "Jake";
personA.Age = 22;

personB.Name = "Mandy";
personB.Age = 20;

Console.WriteLine($"PersonA: {personA.Name}, {personA.Age}\n" +
                  $"PersonB: {personB.Name}, {personB.Age}");


// ******************** Step 3 ********************
Person personC = new Person();
Console.WriteLine($"PersonC: {personC.Name}, {personC.Age}");

// ******************** Step 4 ********************
personA.Introduce();

// ******************** Step 6 ********************
Person personD = new Person("Alexis", 23);

// ******************** Step 7 ********************
personD.City = "Davenport";
Console.WriteLine(personD.City);

// ******************** Step 9 ********************
Console.WriteLine($"Population: {Person.Population}");

// ******************** Step 10 ********************
Person.ShowPopulation();
