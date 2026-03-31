using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using wealth_tracker.Models;

namespace wealth_tracker.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() { }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<SavingsGoal> SavingsGoals { get; set; }
        public DbSet<BudgetLimit> BudgetLimits { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
                options.UseSqlite("Data Source=wealth-tracker.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.HasKey(t => t.Id);
                entity.Property(t => t.Category).IsRequired();
                entity.Property(t => t.Amount).IsRequired();
                entity.Property(t => t.Date).IsRequired();
                entity.Property(t => t.Type).HasConversion<string>();
            });

            modelBuilder.Entity<SavingsGoal>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name).IsRequired();
                entity.Property(e => e.TargetAmount)
                    .IsRequired()
                    .HasConversion<double>(); 
                entity.Property(e => e.SavedAmount)
                    .HasConversion<double>(); 
                entity.Property(e => e.Deadline).IsRequired();
                entity.Ignore(e => e.Progress);
                entity.Ignore(e => e.MonthlyRequired);
                entity.Ignore(e => e.IsCompleted);
            });

            modelBuilder.Entity<BudgetLimit>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Category).IsRequired();
                entity.Property(e => e.LimitAmount)
                    .IsRequired()
                    .HasConversion<double>(); 
                entity.Property(e => e.Month).IsRequired();
                entity.Property(e => e.Year).IsRequired();
                entity.Ignore(e => e.SpentAmount);  
                entity.Ignore(e => e.Remaining);
                entity.Ignore(e => e.IsExceeded);
                entity.Ignore(e => e.DailyAllowance);
            });
        }
    }
}
