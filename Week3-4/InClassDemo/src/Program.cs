using src.LibraryManagement;

// // ********* Step 1 *********
// Book myBook = new Book();
//
// Console.WriteLine($"Book: {myBook.Title} by {myBook.Author}");
//
// myBook.Title = "Atomic Habits";
// myBook.Author = "James Clear";
//
// Console.WriteLine($"Book: {myBook.Title} by {myBook.Author}");
//
//
// myBook.Title = "New Title";
//
//
// public string Title {
//     get;
//     set;
// }
// public string Author {
//     get {return _author;}
// }
//
// public Book (string Title, string Author);
// {
//     this.Title = title;
//     this.Author = author;
// }
    //
    //
    // Book myBook = new Book (author: "Atomic Habits", title: "James Clear");
    // Console.WriteLine($"Book: {myBook.Title} by {myBook.Author}");
    //
    // // ***Step 4 ***
    // Book myBook = new Book (author: "Atomic Habits", title: "James Clear");
    // myBook.DisplayInfo();
    //
    //**Step 5***

    public string Title
    {
        get{return _title;}
    
    set {_title = value;}
    }
    
    public string 