using src.LibraryManagement;


// **************** Step 1 ****************
// Book myBook = new Book();
// Console.WriteLine($"Book: {myBook.Title} by {myBook.Author}");
//
// myBook.Title = "Atomic Habits";
// myBook.Author = "James Clear";
// Console.WriteLine($"Book: {myBook.Title} by {myBook.Author}");

// **************** Step 2 ****************
// Book myBook = new Book("Atomic Habits", "James Clear");
// Console.WriteLine($"Book: {myBook.Title} by {myBook.Author}");
//
// myBook.Title = "New Title";
// Console.WriteLine($"Book: {myBook.Title} by {myBook.Author}");


// **************** Step 3 ****************
// Book myBook = new Book(author:"James Clear", title:"Atomic Habits");
//
// Console.WriteLine($"Book: {myBook.Title} by {myBook.Author}");

// **************** Step 4 ****************
// Book myBook = new Book(author:"James Clear", title:"Atomic Habits");
// myBook.DisplayInfo();

// **************** Step 5 ****************
// Book myBook = new Book(author:"James Clear", title:"Atomic Habits");
// myBook.Author = "";
// myBook.DisplayInfo();
// **************** Step 6 ****************
// Console.WriteLine($"Count: {Book.Count}");






// **************** Vehicle Management System ****************
using src.VehicleManagement;

Car myCar = new Car("Toyota", "Camry", 2020);
Truck myTruck = new Truck("RoadRanger", "Voyager", 2019, 20);
Truck mySecondTruck = new Truck("Ford", "Ranger", 2021, 40);

myCar.DisplayInfo();
myCar.StartEngine();
myCar.Drive();
myCar.Honk();
myCar.Honk(3);
myCar.FuelType();

Console.WriteLine();

myTruck.DisplayInfo();
myTruck.StartEngine();
myTruck.Drive();
myTruck.FuelType();

Console.WriteLine();

Truck myThirdTruck = myTruck + mySecondTruck;
Console.WriteLine($"myTruck cargo capacity: {myTruck.CargoCapacity}\n" +
                  $"mySecondTruck cargo capacity: {mySecondTruck.CargoCapacity}\n" +
                  $"myThirdTruck cargo capacity (sum): {myThirdTruck.CargoCapacity}");



