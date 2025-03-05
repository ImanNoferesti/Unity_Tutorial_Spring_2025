using src;

Person person01 = new Person();
Person person02 = new Person();

person01.Name = "Mairead";
person01.Age = 25;

person02.Name = "Kieran";
person02.Age = 21;

Console.WriteLine($"{person01.Name} is {person01.Age} ");
Console.WriteLine($"{person02.Name} is {person02.Age}");

Console.WriteLine();

Person person03 = new Person();
Console.WriteLine($"{person03.Name} is {person03.Age} ");
Console.WriteLine();

person01.Introduce();
person02.Introduce();

Person person04 = new Person("Margaret", 58);
person04.Location = "Grand Rapids, MI";
person04.Introduce();

Console.WriteLine();
// Console.WriteLine($"The total population is {Person.Population}");

Person.ShowPopulation();