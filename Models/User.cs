public enum Role
{
    Student,
    Faculty,
    Guest,
    Librarian,
    Admin
}

public class User
{
    public string UserID { get; }
    public string Name { get; }
    public string Email { get; private set; }
    public string Password { get; private set; }
    public Role Role { get; }


    public User(string name, string email, string password, Role role)
    {
        if (!EmailValidator.IsValidEmail(email))
            throw new ArgumentException("Email is invalid");
        if (!PasswordValidator.IsValidPassword(password))
            throw new ArgumentException("Password is invalid");

        UserID = Guid.NewGuid().ToString();
        Name = name;
        Email = email;
        Password = PasswordValidator.HashedPassword(password);
        Role = role;
    }

    public void ChangeEmail(string email)
    {
        if (!EmailValidator.IsValidEmail(email))
            throw new ArgumentException("Email is invalid");
        Email = email;
    }
    public void ChangePassword(string oldPassword, string newPassword)
    {
        if (!PasswordValidator.IsValidPassword(oldPassword) || !PasswordValidator.IsValidPassword(newPassword))
            throw new ArgumentException("Password is invalid");
        if (PasswordValidator.HashedPassword(oldPassword) != Password)
            throw new ArgumentException("Wrong password entered");
        Password = PasswordValidator.HashedPassword(newPassword);
    }
}
