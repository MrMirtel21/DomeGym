namespace DomeGym.Domain.SessionAggregate;

public interface ISessionsRepository
{
    Task AddSessionAsync(Session session);
    Task UpdateSessionAsync(Session session);
}