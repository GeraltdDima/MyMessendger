public interface IGetRequestCommand<TSource, TRequest, TBase> where TBase : class where TRequest : IRequest
{
    Task<TSource> Do(TRequest request, IDataBase<TBase> dataBase);
}