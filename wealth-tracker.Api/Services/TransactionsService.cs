using Microsoft.EntityFrameworkCore;
using wealth_tracker.Api.DTOs;
using wealth_tracker.Data;
using wealth_tracker.Models;

namespace wealth_tracker.Api.Services
{
    public class TransactionsService : ITransactionService
    {
        private readonly AppDbContext _context;

        public TransactionsService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<TransactionDto>> GetAllAsync(string? category, string? type, DateTime? dateFrom, DateTime? dateTo)
        {
            var query = _context.Transactions.AsQueryable();

            if (!string.IsNullOrEmpty(category))
                query = query.Where(t => t.Category.Contains(category));

            if (!string.IsNullOrEmpty(type) && Enum.TryParse<TransactionType>(type, out var parsedType))
                query = query.Where(t => t.Type == parsedType);

            if (dateFrom.HasValue)
                query = query.Where(t => t.Date >= dateFrom.Value);

            if (dateTo.HasValue)
                query = query.Where(t => t.Date <= dateTo.Value);

            return await query
                .OrderByDescending(t => t.Date)
                .Select(t => ToDto(t))
                .ToListAsync();
        }

        public async Task<TransactionDto?> GetByIdAsync(Guid id)
        {
            var transaction = await _context.Transactions.FindAsync(id);
            return transaction is null ? null : ToDto(transaction);
        }

        public async Task<TransactionDto> CreateAsync(CreateTransactionDto dto)
        {
            if (!Enum.TryParse<TransactionType>(dto.Type, out var type))
                throw new ArgumentException($"Invalid transaction type: {dto.Type}");

            var transaction = new Transaction
            {
                Date = dto.Date,
                Category = dto.Category,
                Amount = dto.Amount,
                Type = type
            };

            _context.Transactions.Add(transaction);
            await _context.SaveChangesAsync();

            return ToDto(transaction);
        }

        public async Task<bool> UpdateAsync(Guid id, UpdateTransactionDto dto)
        {
            var transaction = await _context.Transactions.FindAsync(id);
            if (transaction is null)
                return false;

            if (!Enum.TryParse<TransactionType>(dto.Type, out var type))
                throw new ArgumentException($"Invalid transaction type: {dto.Type}");

            transaction.Date = dto.Date;
            transaction.Category = dto.Category;
            transaction.Amount = dto.Amount;
            transaction.Type = type;

            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var transaction = await _context.Transactions.FindAsync(id);
            if (transaction is null)
                return false;

            _context.Transactions.Remove(transaction);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<object> GetSummaryAsync()
        {
            var transactions = await _context.Transactions.ToListAsync();

            var totalIncome = transactions
                .Where(t => t.Type == TransactionType.Income)
                .Sum(t => t.Amount);

            var totalExpenses = transactions
                .Where(t => t.Type == TransactionType.Expense)
                .Sum(t => t.Amount);

            return new
            {
                Balance = totalIncome - totalExpenses,
                TotalIncome = totalIncome,
                TotalExpenses = totalExpenses,
                Count = transactions.Count
            };
        }

        private static TransactionDto ToDto(Transaction t) => new TransactionDto
        {
            Id = t.Id,
            Date = t.Date,
            Category = t.Category,
            Amount = t.Amount,
            Type = t.Type.ToString(),
            TypeDisplay = t.Type == TransactionType.Income ? "Дохід" : "Витрата"
        };
    }
}
