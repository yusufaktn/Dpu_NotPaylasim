public interface UnitOfWork
{
    Task SaveChangesAsync(CancellationToken cancellationToken = default);
    void SaveChanges();
}
