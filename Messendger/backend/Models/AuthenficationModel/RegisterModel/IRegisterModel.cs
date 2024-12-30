public interface IRegisterModel
{
    string GetEmail();
    string GetPassword();
    string GetConfirmPassword();
    string GetUserName();

    string GetKey();
    string GetPersonalKey();
}