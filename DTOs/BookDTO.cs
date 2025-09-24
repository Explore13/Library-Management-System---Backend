public class BookDTO
{
    public string BookID { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public string Publisher { get; set; }
    public int TotalCopies { get; set; }
    public int AvailableCopies { get; set; }
    public float Price { get; set; }


    public static BookDTO ConvertToBookDTO(Book book)
    {
        return new BookDTO
        {
            BookID = book.BookID,
            Title = book.Title,
            Author = book.Author,
            Publisher = book.Publisher,
            TotalCopies = book.TotalCopies,
            AvailableCopies = book.AvailableCopies,
            Price = book.Price
        };
    }
}