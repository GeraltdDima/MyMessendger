using System;
using System.Text;
using System.Security.Cryptography;

public class SHA512Network : IHashNetwork
{
    private readonly SHA512 sha512;
    private readonly IKeyManager keyManager;

    public SHA512Network()
    {
        sha512 = SHA512.Create();
        keyManager = new KeyManager();
    }
    
    public string Hash(string value)
    {
        byte[] bytes = sha512.ComputeHash(keyManager.GetBytes(value));
        return BitConverter.ToString(bytes).Replace("-", "");
    }
}