using wealth_tracker.Api.DTOs;

namespace wealth_tracker.Api.Services
{
    public interface ITransactionService
    {
        Task<List<TransactionDto>> GetAllAsync(string? category, string? type, DateTime? dateFrom, DateTime? dateTo);
        Task<TransactionDto?> GetByIdAsync(Guid id);
        Task<TransactionDto> CreateAsync(CreateTransactionDto dto);
        Task<bool> UpdateAsync(Guid id, UpdateTransactionDto dto);
        Task<bool> DeleteAsync(Guid id);
        Task<object> GetSummaryAsync();
    }
}
