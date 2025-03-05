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


//  **************************** Vehicle Management System *************************** 

using src.VehicleManagement;

// *************** Step 1 *************** 

Vehicle myVehicle = new Vehicle("Honda", "CRV", 2021);

Car myCar = new Car("Honda", "CRV", 2021);
Truck myTruck01 = new Truck("Ford", "F150", 2020, 40, "diesel");
Truck myTruck02 = new Truck("Tesla", "Cybertruck", 2024, 1, "N/A");

myCar.DisplayInfo();
myCar.StartEngine();
myCar.Drive();

// *************** Step 2 *************** 

myCar.Honk();
Console.WriteLine();
myCar.Honk(4);
Console.WriteLine();

myTruck01.DisplayInfo();
myTruck02.DisplayInfo();

Truck myTruck03 = myTruck01 + myTruck02;

myTruck03.DisplayInfo;
//
// Car myCar = new Car("Toyota", "RAV-4", 2018);
// myCar.DisplayInfo();
// myCar.Honk();
// Console.WriteLine();
// myCar.Honk(4);
// Console.WriteLine();
//
// Truck truck1 = new Truck("Tesla", "Cybertruck", 2025, 2, "no fuel (Ecar)");
// truck1.DisplayInfo();
// Console.WriteLine($"It has a cargo capacity of {truck1.CargoCapacity} tons");
//
// Console.WriteLine("The truck's engine has started.");
//
// Truck truck2 = new Truck("Ford", "F150", 2025, 10, "diesel");
// truck2.DisplayInfo();
// Console.WriteLine($"It has a cargo capacity of {truck2.CargoCapacity}");
//
// int combinedCapacity;
// combinedCapacity = truck1 + truck2;
// Console.WriteLine($"The combined capacity of the two trucks is {combinedCapacity} tons");
//
// // *************** Step 3 *************** 
//
// myCar.Drive();
// truck1.Drive();
// truck1.FuelType();