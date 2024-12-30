public interface IGetNetwork
{
    Task<T> GetAsync<T>(string url) where T : class;
}