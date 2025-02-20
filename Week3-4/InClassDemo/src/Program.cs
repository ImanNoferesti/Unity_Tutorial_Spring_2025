// Classes
using src.LibraryManagement;


//************ Step 1 ************
Book myBook = new Book();
Console.WriteLine($"Book: {myBook.Title} by {myBook.Author}");

myBook.Title = "Atomic Habits";
myBook.Author = "James Bond";

Console.WriteLine($"Book: {myBook.Title} by {myBook.Author}");
