using wealth_tracker.Models;

namespace wealth_tracker.Services
{
    public interface IPersistenceService
    {
        Task<List<Transaction>> LoadAsync();
        Task SaveAsync(Transaction transaction);
        Task DeleteAsync(Guid id);
        Task SaveAllAsync(IEnumerable<Transaction> transactions);
        string DbPath { get; }
    }
}
