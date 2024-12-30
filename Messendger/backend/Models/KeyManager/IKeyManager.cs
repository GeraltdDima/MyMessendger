public interface IKeyManager
{
    string GetValue(byte[] bytes);
    byte[] GetBytes(string value);
}