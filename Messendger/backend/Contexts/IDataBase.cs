using Microsoft.EntityFrameworkCore;
public interface IDataBase<T>
{ 
    Task<DbSet<T>> GetValues<T>();
}