using Microsoft.EntityFrameworkCore;

public interface IDataBase<T> where T : class
{
    Task<DbSet<T>> GetValues();
}