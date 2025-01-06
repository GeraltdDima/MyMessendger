public abstract class SecurityGetCommandDecorator<TSource, TBase> : IGetCommand<TSource, TBase> where TBase : class
{
    public abstract Task<TSource> Do(IDataBase<TBase> dataBase);
}