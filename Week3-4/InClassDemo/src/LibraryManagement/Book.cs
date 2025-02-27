namespace src.LibraryManagement;

public class Book
{
    // Step 1
    //public string Title;
    //public string Author;

    // Step 2

    // public string Title { get; set; }
    //
    // public string Author { get; }

    //
    // public Book(string title, string author)
    // {
    //     this.Title = title;
    //     this.Author = author;
    // }
    

    // Step 3
    private string _title;
    private string _author;
    
    public static int Count = 0;
    // public string Title
    // {
    //     get { return _title; }
    //     set { _title = value; }
    // }
    //
    // public string Author
    // {
    //     get { return _author; }
    // }
    
    // Step 5

    public string Title
    {
        get { return _title; }
        set { _title = value; }
    }

    public string Author
    {
        get { return _author; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                Console.WriteLine($"Opps! Add a name");
            }
            else
            {
                _author = value;
            }
        }
    }
    
    // Constructors

    public Book(string title, string author)
    {
        this._title = title;
        this._author = author;
        Count++;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Book: {_title} by {_author}");
    }
}

    
    