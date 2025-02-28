using LibraryManagement;
using src.Library;

//*****BOOKS DEMO*****
// STEP ONE
// Book myBook = new Book();
// Console.WriteLine($"Book: {myBook.Title} by {myBook.Author}");

//myBook.Title = "Atomic Habits";
// myBook.Author = "James Clear"; 
//Console.WriteLine($"Book: {myBook.Title} by {myBook.Author}");
// STEP TWO
// Book myBook = new Book("Atomic Habits", "James Clear");
// Console.WriteLine($"Book: {myBook.Title} by {myBook.Author}");

//STEP THREE
//Book myBook = new Book("James Clear", "Atomic Habits");
// Console.WriteLine($"Book: {myBook.Title} by {myBook.Author}");

//STEP FOUR
// Book myBook = new Book("James Clear", "Atomic Habits");
// myBook.IntroduceBook();

//STEP FIVE
// Book myBook = new Book("James Clear", "Atomic Habits");
// myBook.Author = ""; //Null Input, Add Author Name
// myBook.IntroduceBook();
//
//STEP SIX
// Console.WriteLine($"Number of Books in Library: {Book.Count}");

// *****VEHICLE MANAGEMENT SYSTEM DEMO*****
Vehicles myCar = new Car("Chevy", "Equinox", 2018);
myCar.DisplayInfo();
myCar.StartEngine();

Truck truck1 = new Truck("Ford", "F250", 2012, 3000);
Truck truck2 = new Truck("Chevy", "Silverado", 2003, 2000);
Console.WriteLine($"Combined Cargo Capacity of a {truck1.Make} {truck1.Model} and a {truck2.Make} {truck2.Model} is {truck1 + truck2} lbs");
Car.Honk();//Beep * 1
myCar.Drive();
truck1.Drive();
myCar.FuelType();
truck1.FuelType();



























//IN CLASS NOTES
//
// //create an instance of the class
// var myCar = new Car();
// myCar.Year = 2023;
// Console.WriteLine((myCar.Year).ToString()); //2023
// Console.WriteLine(myCar.CarPrice(myCar.Year)); // _price = 35_000
// var redCar = new Car("red", 2018, 15_000);
// List<string> carList = new List<string>();
// carList.AddRange([myCar.Color,myCar.Year.ToString()]);
// carList.AddRange([redCar.Color,redCar.Year.ToString()]);
// Console.WriteLine(String.Join(",", carList));
//
// class Car
// {   // specific value
//     public string Color = "black";
//     //default value : 0
//     public int Year; 
//     //only accessible by code in class
//     private int _price; 
//     // Default Constructor
//     public Car()
//     {
//         
//     }
//     //Create Custom Constructor
//     public Car(string Color, int Year, int _price)
//     {
//         this.Color = Color;
//         this.Year = Year;
//         this._price = _price;
//     }
//     //define method for updating _price
//     public int CarPrice(int Year)
//     {
//         // this.Year is the public int Year, sets equal to Year parameter
//         this.Year = Year; 
//         switch (Year)
//         {
//             case >2020:
//                 _price = 35_000;
//                 return _price;
//                 break;
//             default:
//                 _price = 10_000;
//                 return _price;
//                 break;
//         }
//     }
// }
// END OF IN CLASS NOTES

