using src.LibraryManagement;

// ************ Step 1 ***************

// Book myBook = new Book();
// Console.WriteLine($"Book: {myBook.Title} by {myBook.Author}");
//
// myBook.Title = "Atomic Habits";
//
// myBook.Author = "Pedro Gonzales";
//
// Console.WriteLine($"Book: {myBook.Title} by {myBook.Author}");


// Step 2: Improving Data Handling

// * Step 3: Controlling Access
// *      Raw data fields can sometimes lead to unintended modifications.
// *      It would be wise to restrict direct access and instead provide a structured way to interact with book details.
// *      Adjust the class so that its data is better protected, yet still accessible when needed.

Book myBook = new Book("Atomic Habits", "James Clear");
//
// Console.WriteLine($"Book: {myBook.Title}");

// * Step 4: Adding Functionality
//     *      A book should be able to introduce itself.
// *      Implement a way for a book to neatly display its information without requiring external code to manually format the details.

myBook.DisplayInfo();

