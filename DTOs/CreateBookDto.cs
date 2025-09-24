using System.ComponentModel.DataAnnotations;

public class CreateBookDTO
{
    [Required(ErrorMessage = "Title is required")]
    [StringLength(100, ErrorMessage = "Title cannot exceed 100 characters")]
    public string Title { get; set; }

    [Required(ErrorMessage = "Author is required")]
    [StringLength(50, ErrorMessage = "Author name cannot exceed 50 characters")]
    public string Author { get; set; }

    [Required(ErrorMessage = "Publisher is required")]
    [StringLength(50, ErrorMessage = "Publisher name cannot exceed 50 characters")]
    public string Publisher { get; set; }

    [Required(ErrorMessage = "Total copies must be provided")]
    [Range(1, int.MaxValue, ErrorMessage = "Total copies must be at least 1")]
    public int TotalCopies { get; set; }
    
    [Required(ErrorMessage = "Price must be provided")]
    [Range(0.01, float.MaxValue, ErrorMessage = "Price must be positive")]
    public float Price { get; set; }
}