using System;
using System.Text;

public class KeyManager : IKeyManager
{
    public string GetValue(byte[] bytes)
    {
        return Encoding.UTF8.GetString(bytes);
    }
    
    public byte[] GetBytes(string value)
    {
        return Encoding.UTF8.GetBytes(value);
    }
}