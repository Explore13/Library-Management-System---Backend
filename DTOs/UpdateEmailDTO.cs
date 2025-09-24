using System.ComponentModel.DataAnnotations;

public class UpdateEmailDTO
{
    [Required(ErrorMessage = "UserID is required")]
    [StringLength(50, ErrorMessage = "UserID cannot exceed 50 characters")]
    public string UserID { get; set; }

    [Required(ErrorMessage = "Email is required")]
    [EmailAddress(ErrorMessage = "Invalid email format")]
    public string Email { get; set; }
}