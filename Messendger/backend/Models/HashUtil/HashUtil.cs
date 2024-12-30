public static class HashUtil
{
    private static readonly IHashNetwork hashNetwork;
    private static readonly byte[] keyBytes;
    private static readonly string key;

    private static readonly IKeyManager keyManager;
    
    static HashUtil()
    {
        hashNetwork = new SHA512Network();
        keyManager = new KeyManager();
        
        keyBytes = new byte[] {64,76,103,73,98,39,113,42,107,85,80,38,120,86,99 };
        
        key = keyManager.GetValue(keyBytes);
    }
    
    public static string Hash(string input)
    {
        return hashNetwork.Hash(input + key);
    }
}