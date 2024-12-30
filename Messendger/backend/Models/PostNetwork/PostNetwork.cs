using System;
using System.Net;

public class PostNetwork : IPostNetwork
{
    private readonly HttpClient client;

    public PostNetwork()
    {
        client = new HttpClient();
    }

    public async Task PostAsync(string url, StringContent content)
    {
        HttpResponseMessage response = await client.PostAsync(url, content);

        if (response.IsSuccessStatusCode)
        {
            return;
        }
        
        throw new Exception("Error");
    }
}