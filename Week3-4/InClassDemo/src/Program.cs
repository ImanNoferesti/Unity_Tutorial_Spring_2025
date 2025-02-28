// Classes
//using src.LibraryManagement;
using src.VehicleManagement;

//************ Step 1 ************
/*Book myBook = new Book();
Console.WriteLine($"Book: {myBook.Title} by {myBook.Author}");

myBook.Title = "Atomic Habits";
myBook.Author = "James Bond";

Console.WriteLine($"Book: {myBook.Title} by {myBook.Author}");
*/

//************ Step 2 ************
// Book myBook = new Book("Atomic Habits", "James Clear");
// Console.WriteLine($"Book: {myBook.Title} by: {myBook.Author}");
//
// myBook.Title = "New Title";
// Console.WriteLine($"Book: {myBook.Title} by: {myBook.Author}");

//************ Step 3 ************
// Book myBook = new Book("Atomic Habits", "James Clear");
//
// Console.WriteLine($"Book: {myBook.Title} by: {myBook.Author}");

//************ Step 4 ************
// Book myBook = new Book("Atomic Habits", "James Clear");
// myBook.DisplayInfo();

//************ Step 5 ************
// Book myBook = new Book("Atomic Habits", "James Clear");
// myBook.Author = "";
//
// myBook.DisplayInfo();
//
// //************ Step 6 ************
// Console.WriteLine($"Count: {Book.Count}");


//********* Demo 2 ********************

Vehicle myVehicle = new Vehicle();

myVehicle.Make = "Ford";
myVehicle.Model = "F150";
myVehicle.Year = 2025;

myVehicle.DisplayInfo();
myVehicle.StartEngine();
myVehicle.Drive();