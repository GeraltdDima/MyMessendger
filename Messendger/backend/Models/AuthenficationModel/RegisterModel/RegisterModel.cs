public class RegisterModel : IRegisterModel
{
    private string email;
    private string password;
    private string confirmPassword;
    private string username;

    private string key;
    private string personalKey;

    public RegisterModel(string email, string password, string confirmPassword, string username, string personalKey)
    {
        this.email = email;
        this.password = password;
        this.confirmPassword = confirmPassword;
        this.username = username;
        this.personalKey = personalKey;
    }
    
    public string GetEmail() => email;
    public string GetPassword() => password;
    public string GetConfirmPassword() => confirmPassword;
    public string GetUserName() => username;
    
    public string GetKey() => key;
    public string GetPersonalKey() => personalKey;
}