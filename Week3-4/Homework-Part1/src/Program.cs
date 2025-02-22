using src;
// steps 1 & 2 (&10, calls static upon person1 creation)
Person person1 = new Person();
Person person2 = new Person();
person1.Name = "John";
person1.Age = 20;
person1.City = "Des Moines";
person2.Name = "Jill";
person2.Age = 21;
Console.WriteLine($"{person1.Name} is {person1.Age.ToString()} years old");
Console.WriteLine($"{person2.Name} is {person2.Age.ToString()} years old");

//step 3
Person defaultPerson = new Person();
Console.WriteLine($"{defaultPerson.Name} is {defaultPerson.Age.ToString()} years old"); 

//steps 4 & 5
person1.Introduce();

//step 6
Person customPerson = new Person("Jack", 23, "Iowa City");
Person default2 = new Person();
Console.WriteLine($"\n{default2.Name} is {default2.Age.ToString()} years old. " +
                  $"\n{customPerson.Name} is {customPerson.Age.ToString()} years old."); 

//step 7
default2.City = "Ottumwa";
//Console.WriteLine(default2._city); should not work b/c _city is private
Console.WriteLine(default2.City);

//Step 8
Console.WriteLine(Person.Population);

//step 9
Person.ShowPopulation();


               