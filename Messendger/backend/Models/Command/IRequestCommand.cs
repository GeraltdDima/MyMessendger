public interface IRequestCommand<TRequest, TBase> where TBase : class where TRequest : IRequest
{
    Task Do(TRequest request, IDataBase<TBase> dataBase);
}