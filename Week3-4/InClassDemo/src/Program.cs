// Classes

// using src.LibraryManagment;
//
// // Book myBook = new Book();
//
// Book myBook = new Book("Atomic Habits", "Barnapuss");
// Console.WriteLine($"Book: {myBook.Title} by {myBook.Author}");
//
// myBook.DisplayInfo();
//
// // Console.WriteLine($"There are {Count} books so far.");

using src.VehicleManagement;

// *************** Step 1 *************** 

Vehicle myVehicle = new Vehicle("Honda", "CRV", 2021);

// myVehicle.DisplayInfo();
myVehicle.StartEngine();
myVehicle.Drive();


// *************** Step 2 *************** 

Car myCar = new Car("Toyota", "RAV-4", 2018);
myCar.DisplayInfo();
myCar.Honk();
Console.WriteLine();
myCar.Honk(4);
Console.WriteLine();

Truck truck1 = new Truck("Tesla", "Cybertruck", 2025, 2, "no fuel (Ecar)");
truck1.DisplayInfo();
Console.WriteLine($"It has a cargo capacity of {truck1.CargoCapacity} tons");

Console.WriteLine("The truck's engine has started.");

Truck truck2 = new Truck("Ford", "F150", 2025, 10, "diesel");
truck2.DisplayInfo();
Console.WriteLine($"It has a cargo capacity of {truck2.CargoCapacity}");

int combinedCapacity;
combinedCapacity = truck1 + truck2;
Console.WriteLine($"The combined capacity of the two trucks is {combinedCapacity} tons");

// *************** Step 3 *************** 

myCar.Drive();
truck1.Drive();
truck1.FuelType();