using System;
using System.Net;

public class RequestSender : IRequestSender
{
    private readonly IStringContentRequestFactory stringContentRequestFactory;

    public RequestSender()
    {
        stringContentRequestFactory = new StringContentRequestFactory();
    }
    
    public async Task PostAsync(string url, IRequest request)
    {
        try
        {
            StringContent content = stringContentRequestFactory.CreateStringContent(request);

            if (content == null)
            {
                throw new Exception("Content is null");
            }
            
            await WebUtil.PostAsync(url, content);
        }
        catch
        {
            throw new Exception("Error while posting request:");
        }
    }
}