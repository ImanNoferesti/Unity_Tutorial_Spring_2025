namespace src.LibraryManagement;

public class Book
{
    // ********* Step 1 ************
    //public string Title;
    //public string Author;
    
    // ********* Step 2 ************
    // public string Title {get; set;}
    // public string Author { get; }
    //
    //
    // public Book(string title, string author) 
    // {
    //     this.Title = title;
    //     this.Author = author;
    // }
    
    // ********* Step 3 ************
    private string _title;
    private string _author;
    
    // ********* Step 6 ************
    public static int Count = 0;

    // public string Title
    // {
    //     get{return _title;}
    //     set{_title = value;}
    // }

    // public string Author
    // {
    //     get{return _author;}
    // }
    //
    public Book(string title, string author)
    {
        this._title = title;
        this._author = author;
        // ********* Step 6 ************
        Count++;
    }
    
    // ********* Step 5 ************
    public string Title
    {
        get{return _title;}
        set{_title = value;}
    }

    public string Author
    {
        get{return _author;}
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                Console.WriteLine("Oops add some input!");
            }
            else
            {
                _author = value;
            }
        }
    }

    // ********* Step 4 ************
    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {_title} by: {_author}");
    }
    
    // ********* Step 4 ************
}