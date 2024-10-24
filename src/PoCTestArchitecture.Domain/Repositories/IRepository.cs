namespace PoCTestArchitecture.Domain.Repositories;
public interface IRepository<T> where T : Entities.Domain
{
    Task<T> InsertAsync(T entity);
}
