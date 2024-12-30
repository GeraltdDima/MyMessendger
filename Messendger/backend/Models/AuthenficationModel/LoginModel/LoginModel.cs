public class LoginModel : ILoginModel
{
    private readonly string email;
    private readonly string password;

    private readonly string key;
    private readonly string personalKey;

    public LoginModel(string email, string password, string key, string personalKey)
    {
        this.email = email;
        this.password = password;
        this.key = key;
        this.personalKey = personalKey;
    }
    
    public string GetEmail() => email;
    public string GetPassword() => password;
    
    public string GetKey() => key;
    public string GetPersonalKey() => personalKey;
}