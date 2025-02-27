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

    public string Title
    {
        get { return _title; }
        set { _title = value; }
    }

    public string Author
    {
        get { return _author; }
    }

    // Constructor

    public Book(string title, string author)
    {
        this._title = title;
        this._author = author;
    }
}

    
    