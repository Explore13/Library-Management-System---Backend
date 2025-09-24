public class LibraryService : ILibraryService
{
    private readonly List<Book> books = new();

    public void AddBook(Book book) => books.Add(book);
    public void RemoveBook(string bookId)
    {
        if (string.IsNullOrWhiteSpace(bookId))
            throw new ArgumentException("Invalid Book ID");
        var book = books.FirstOrDefault(b => b.BookID == bookId);
        System.Console.WriteLine(book);
        if (book != null) books.Remove(book);
        else throw new ArgumentException("Book not found");

    }
    public void UpdateBookPrice(string bookId, float price)
    {
        if (string.IsNullOrWhiteSpace(bookId))
            throw new ArgumentException("Invalid Book ID");
        var book = books.FirstOrDefault(b => b.BookID == bookId);
        if (book != null) book.SetPrice(price);
        else throw new ArgumentException("Book not found");
    }
    public Book SearchBook(string title)
    {

        var book = books.FirstOrDefault(b => b.Title.Contains(title, StringComparison.OrdinalIgnoreCase));
        if (book != null) return book;
        else throw new ArgumentException("Book does not exist");
    }
    public void BorrowBook(string bookId)
    {
        var book = books.FirstOrDefault(b => b.BookID == bookId);
        if (book != null)
        {
            bool isBorrowed = book.BorrowBook();
            if (isBorrowed == false) throw new ArgumentException("Book is not available");
        }
        else throw new ArgumentException("Book not found");
    }
    public void ReturnBook(string bookId)
    {
        var book = books.FirstOrDefault(b => b.BookID == bookId);
        if (book != null)
            book.ReturnBook();
        else throw new ArgumentException("Book not found");
    }
    public List<Book> GetAllBooks() => books;
    public List<Book> GetAvailableBooks() => books.Where(b => b.AvailableCopies > 0).ToList();
    public List<Book> GetBorrowedBooks() => books.Where(b => b.AvailableCopies < b.TotalCopies).ToList();

}