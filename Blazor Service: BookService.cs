public class BookService
{
    private List<Book> books = new List<Book>
    {
        new Book { Id = 1, Title = "Blazor in Action", Author = "Steve Sanderson" },
        new Book { Id = 2, Title = "Learn C# in Depth", Author = "Jon Skeet" },
        new Book { Id = 3, Title = "ASP.NET Core Guide", Author = "Scott Hanselman" }
    };

    public IEnumerable<Book> GetBooks()
    {
        return books;
    }
}

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
}
