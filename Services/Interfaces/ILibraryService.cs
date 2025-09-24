public interface ILibraryService
{
    void AddBook(Book book);
    void RemoveBook(string bookId);
    void UpdateBookPrice(string bookId,float price);
    Book SearchBook(string title);
    void BorrowBook(string bookId);
    void ReturnBook(string bookId);
    List<Book> GetAllBooks();
    List<Book> GetAvailableBooks();
    List<Book> GetBorrowedBooks();
}