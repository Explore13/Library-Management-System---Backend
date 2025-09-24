using System.ComponentModel.DataAnnotations;

public class UpdatePasswordDTO
{
    [Required(ErrorMessage = "UserID is required")]
    [StringLength(50, ErrorMessage = "UserID cannot exceed 50 characters")]
    public string UserID { get; set; }

    [Required(ErrorMessage = "Old Password is required")]
    [StringLength(100, ErrorMessage = "Old Password cannot exceed 100 characters", MinimumLength = 8)]
    public string OldPassword { get; set; }

    [Required(ErrorMessage = "New Password is required")]
    [StringLength(100, ErrorMessage = "New Password cannot exceed 100 characters", MinimumLength = 8)]
    public string NewPassword { get; set; }
}
