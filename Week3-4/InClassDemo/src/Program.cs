using src.LibraryManagement;

// ************ Step 1 ***************

Book myBook = new Book();
Console.WriteLine($"Book: {myBook.Title} by {myBook.Author}");

myBook.Title = "Atomic Habits";

myBook.Author = "Pedro Gonzales";

Console.WriteLine($"Book: {myBook.Title} by {myBook.Author}");


// Step 2: Improving Data Handling

