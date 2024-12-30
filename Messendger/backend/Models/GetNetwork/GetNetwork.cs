using System;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

public class GetNetwork : IGetNetwork
{
    private readonly HttpClient client;

    public GetNetwork()
    {
        client = new HttpClient();
    }

    public async Task<T> GetAsync<T>(string url) where T : class
    {
        try
        {
            var response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                T result = JsonSerializer.Deserialize<T>(content);
                
                return result;
            }

            else
            {
                throw new Exception($"GetNetwork returned error: {response.ReasonPhrase}");
            }
        }
        catch (Exception e)
        {
            throw new Exception($"GetNetwork returned error: {e.Message}");
        }
    }
}