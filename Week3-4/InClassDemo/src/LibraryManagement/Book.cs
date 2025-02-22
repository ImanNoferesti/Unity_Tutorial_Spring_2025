
namespace LibraryManagement;
// STEP ONE
public class Book
{
    public string Author;
    public string Title;
    public int Pages;

    public Book()
    {
        
    }

    public Book(string Author, string Title, int Pages)
    {
        this.Author = Author;
        this.Title = Title;
        this.Pages = Pages;
    }
}