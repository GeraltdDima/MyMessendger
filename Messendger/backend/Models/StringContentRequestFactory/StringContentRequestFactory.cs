using System;
using System.Text;
using System.Text.Json;

public class StringContentRequestFactory : IStringContentRequestFactory
{
    public StringContent CreateStringContent(IRequest request)
    {
        try
        {
            var json = JsonSerializer.Serialize(request);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

            if (content == null)
            {
                throw new Exception("Content is null");
            }
            
            return content;
        }
        catch
        {
            throw new Exception("Error creating content request");
        }
    }
}