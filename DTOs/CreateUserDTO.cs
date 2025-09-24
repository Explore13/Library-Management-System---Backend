using System.ComponentModel.DataAnnotations;

public class CreateUserDTO
{
    [Required(ErrorMessage = "UserID is required")]
    [StringLength(50, ErrorMessage = "UserID cannot exceed 50 characters")]
    public string UserID { get; set; }

    [Required(ErrorMessage = "Name is required")]
    [StringLength(100, ErrorMessage = "Name cannot exceed 100 characters")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Email is required")]
    [StringLength(100, ErrorMessage = "Email cannot exceed 100 characters")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Password is required")]
    [StringLength(100, ErrorMessage = "Password cannot exceed 100 characters", MinimumLength = 8)]
    public string Password { get; set; }

    [Required(ErrorMessage = "Role is required")]
    public Role Role { get; set; }
}