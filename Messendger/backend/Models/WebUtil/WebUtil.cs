using System;
using System.Threading.Tasks;

public static class WebUtil
{
    private readonly static IPostNetwork postNetwork;
    private readonly static IGetNetwork getNetwork;

    static WebUtil()
    {
        postNetwork = new PostNetwork();
        getNetwork = new GetNetwork();
    }

    public static async Task PostAsync(string url, StringContent content)
    {
        await postNetwork.PostAsync(url, content);
    }

    public static async Task<T> GetAsync<T>(string url) where T : class
    { 
        return await getNetwork.GetAsync<T>(url);
    }
}