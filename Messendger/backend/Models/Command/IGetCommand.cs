public interface IGetCommand<TSource, TBase> where TBase : class
{
    Task<TSource> Do(IDataBase<TBase> dataBase);
}