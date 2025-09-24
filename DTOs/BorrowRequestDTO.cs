using System.ComponentModel.DataAnnotations;

public class BorrowRequestDTO
{
    [Required(ErrorMessage = "BookID is required")]
    [StringLength(50, ErrorMessage = "BookID cannot exceed 50 characters")]
    public string BookID { get; set; }

    [Required(ErrorMessage = "UserID is required")]
    [StringLength(50, ErrorMessage = "UserID cannot exceed 50 characters")]
    public string UserID { get; set; }
}