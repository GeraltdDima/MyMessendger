public abstract class SecurityRequestCommandDecorator<TRequest, TBase> : IRequestCommand<TRequest, TBase>
    where TBase : class where TRequest : IRequest
{
    public abstract Task Do(TRequest request, IDataBase<TBase> dataBase);
}