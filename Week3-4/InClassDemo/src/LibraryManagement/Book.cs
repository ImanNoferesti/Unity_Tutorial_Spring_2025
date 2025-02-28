
namespace LibraryManagement;
// STEP ONE
public class Book
{
    // STEP TWO - Author is now only { get; }
    // public string Title { get; set; }
    // public string Author { get; }
    private string _title;
    private string _author;
    // STEP THREE - made author and title private added public getters and setters
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
                Console.WriteLine("Null Input, Add Author Name");
            }
            else _author = value;
        }
        
    }
    // STEP FOUR - adds method to introduce book
    public void IntroduceBook()
    {
        Console.WriteLine($"Book: {_title} by {_author}");
    }
    // STEP SIX - adds static counter for library
    public static int Count;
    
    public Book()
    {
        Count++; //STEP SIX
    }

    public Book(string author, string title)
    {
        this._author = author;
        this._title = title;
        Count++; //STEP SIX
    }
    
}