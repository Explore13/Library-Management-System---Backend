public class UserService : IUserService
{
    private readonly List<User> users = new();
    public void AddUser(User user)
    {
        var existingUser = users.FirstOrDefault(u => u.Email == user.Email);
        if (existingUser != null) throw new ArgumentException("User already exists");
        else users.Add(user);
    }
    public void RemoveUser(string userId)
    {
        var user = users.FirstOrDefault(user => user.UserID == userId);
        if (user != null) users.Remove(user);
        else throw new ArgumentException("User not found");
    }
    public User GetUserById(string userId)
    {
        var user = users.FirstOrDefault(u => u.UserID == userId);
        if (user != null) return user;
        else throw new ArgumentException("User does not exist");
    }
    public List<User> GetAllUsers() => new List<User>(users);

    public void UpdateUserEmail(string userId, string email)
    {
        var user = users.FirstOrDefault(u => u.UserID == userId);
        if (user != null)
            user.ChangeEmail(email);
        else throw new ArgumentException("User not found");
    }
    public void UpdateUserPassword(string userId, string oldPassword, string newPassword)
    {
        var user = users.FirstOrDefault(u => u.UserID == userId);
        if (user != null)
            user.ChangePassword(oldPassword, newPassword);
        else throw new ArgumentException("User not found");
    }
    public bool HasPrivilege(Role role) => Role.Admin == role || Role.Librarian == role;
}