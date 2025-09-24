public class UserDTO
{
    public string UserID { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public Role Role { get; set; }

    public static UserDTO ConvertToUserDTO(User user)
    {
        return new UserDTO
        {
            UserID = user.UserID,
            Name = user.Name,
            Email = user.Email,
            Role = user.Role
        };
    }
}