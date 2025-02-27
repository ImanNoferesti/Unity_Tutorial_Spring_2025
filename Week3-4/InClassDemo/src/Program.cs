using src.libraryManagement;


//********step 1***********
Book myBook = new Book();
Console.WriteLine($"Book: {myBook.Title} by {myBook.Author}");

myBook.Title  = "Atomic Habits";
myBook.Author = "james clear";

Console.WriteLine();
Console.WriteLine($"Book: {myBook.Title} by {myBook.Author}");