public interface IUserService
{
    void AddUser(User user);
    void RemoveUser(string userId);
    User GetUserById(string userId);
    List<User> GetAllUsers();
    void UpdateUserEmail(string userId, string email);
    void UpdateUserPassword(string userId, string oldPassword, string newPassword);
    bool HasPrivilege(Role role);
}