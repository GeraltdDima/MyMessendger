using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore;
using System.Threading.Tasks;

[ApiController]
[Route("api/[controller]")]

public class CorrespondenceController : ControllerBase
{
    private readonly CorrespondenceDbContext context;

    private byte[] keyBytes;
    private string key;
    
    private KeyManager keyManager; 

    public CorrespondenceController()
    {
        keyManager = new KeyManager();
        
        keyBytes = new byte[] { 41, 45, 48, 85, 80, 62, 84, 63, 48, 100, 80, 78, 81, 48, 116 };
        key = keyManager.GetValue(keyBytes);
    }
}