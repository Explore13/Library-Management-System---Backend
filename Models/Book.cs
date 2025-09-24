public class Book
{
    public string BookID { get; }
    public string Title { get; }
    public string Author { get; }
    public string Publisher { get; }
    public int TotalCopies { get; private set; }
    public int AvailableCopies { get; private set; }
    public float Price { get; private set; }

    public Book()
    {
        BookID = Guid.NewGuid().ToString();
        Title = "Unknown";
        Author = "Unknown";
        Publisher = "Unknown";
        Price = 0;
        TotalCopies = 0;
        AvailableCopies = 0;
    }

    public Book(string title, string author, string publisher, float price, int totalCopies)
    {
        BookID = Guid.NewGuid().ToString();

        if (string.IsNullOrWhiteSpace(title))
            throw new ArgumentException("Title cannot be empty.");
        if (string.IsNullOrWhiteSpace(author))
            throw new ArgumentException("Author cannot be empty.");
        if (string.IsNullOrWhiteSpace(publisher))
            throw new ArgumentException("Publisher cannot be empty.");
        if (totalCopies < 0)
            throw new ArgumentException("Total copies cannot be negative.");
        if (price < 0)
            throw new ArgumentException("Price cannot be negative.");

        Title = title;
        Author = author;
        Publisher = publisher;
        Price = price;
        TotalCopies = totalCopies;
        AvailableCopies = totalCopies;
    }

    public bool BorrowBook()
    {
        if (AvailableCopies > 0)
        {
            AvailableCopies--;
            return true;
        }
        return false;
    }

    public void ReturnBook()
    {
        if (AvailableCopies < TotalCopies)
        {
            AvailableCopies++;
        }
    }

    public void SetPrice(float price)
    {
        if (price < 0)
            throw new ArgumentException("Price cannot be negative.");
        Price = price;
    }

    public override string ToString()
    {
        return $"{Title} by {Author}, Price: {Price}, Available: {AvailableCopies}/{TotalCopies}";
    }
}
