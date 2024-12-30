public interface IPostNetwork
{
    Task PostAsync(string url, StringContent content);
}