public class Librarian : User
{
    private readonly ILibraryService _libraryService;
    private readonly IUserService _userService;
    public Librarian(string name, string email, string password, ILibraryService libraryService, IUserService userService) : base(name, email, password, Role.Librarian)
    {
        _libraryService = libraryService ?? throw new ArgumentNullException(nameof(libraryService));
        _userService = userService ?? throw new ArgumentNullException(nameof(userService));

    }
    public void RequestAddBook(Book book) => _libraryService.AddBook(book);

    public void RequestRemoveBook(string bookId) => _libraryService.RemoveBook(bookId);

    public void RequestUpdateBookPrice(string bookId, float price) => _libraryService.UpdateBookPrice(bookId, price);

    public void RequestAddStudent(User user) => _userService.AddUser(user);

    public void RemoveUser(string userId) => _userService.RemoveUser(userId);

}