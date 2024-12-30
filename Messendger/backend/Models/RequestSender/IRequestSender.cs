public interface IRequestSender
{
    Task PostAsync(string url, IRequest request);
}