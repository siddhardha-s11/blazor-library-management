# blazor-library-management
A Blazor project developed with Microsoft Copilot
@page "/books"
@inject BookService BookService

<h3>Library Book List</h3>

<input type="text" @bind="searchTerm" placeholder="Search books..." class="form-control mb-3" />

<ul>
    @foreach (var book in FilteredBooks)
    {
        <li>@book.Title by @book.Author</li>
    }
</ul>

@code {
    private string searchTerm = "";

    private IEnumerable<Book> FilteredBooks => string.IsNullOrWhiteSpace(searchTerm)
        ? BookService.GetBooks()
        : BookService.GetBooks().Where(b => b.Title.Contains(searchTerm, StringComparison.OrdinalIgnoreCase));

}
