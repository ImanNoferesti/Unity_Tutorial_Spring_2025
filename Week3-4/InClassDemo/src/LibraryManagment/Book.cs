namespace src.LibraryManagment;

public class Book
{
// *************** step 1 ************** 

    // public string Title;
    // public string Author;
    
// *************** step 2 ************** 

    // public string Title { get; set; }
    // public string Author { get; }
    //
    // public Book(string title, string author)
    // {
    //     this.Title = title;
    //     this.Author = author;
    // }
    
// *************** step 3 ************** 
//
private string _title;
private string _author;
public static int Count = 0;

public string Title
{
    get { return _title; }
    set { _title = value; }
}

public string Author
{
    get { return _author; }
}

public Book(string title, string author)
{
    this._title = title;
    this._author = author;
    Count++;
}
//
// // *************** step 4 ************** 
//
     public void DisplayInfo()
     {
         Console.WriteLine($"Book: {_title} by {_author}");
     }

// *************** step 5 ************** 

// *************** step 6 **************   
    

}