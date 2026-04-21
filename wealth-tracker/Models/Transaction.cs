using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.ComponentModel.DataAnnotations;

namespace wealth_tracker.Models
{
    public enum TransactionType
    {
        Income, 
        Expense,
        TransferToSavings,
        TransferFromSavings
    }

    // Note: INotifyPropertyChanged is a UI concern and ideally should not be
    // in a domain model. It is kept here for simplicity of WinForms data binding.
    // In a clean architecture, a separate ObservableTransaction class
    // would wrap the domain model for UI purposes.
    public class Transaction : INotifyPropertyChanged
    {
        private DateTime _date;
        private string _category = string.Empty;
        private decimal _amount;
        private TransactionType _type;
        

        public Guid Id { get; init; } = Guid.NewGuid();
        public Guid UserId { get; set; }

        [Required]
        public DateTime Date
        {
            get => _date;
            set 
            { 
                _date = value; 
                OnPropertyChanged(); 
            }
        }

        [Required]
        [StringLength(100, MinimumLength = 1)]
        public string Category
        {
            get => _category;
            set 
            { _category = value; 
                OnPropertyChanged(); 
            }
        }

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Сума має бути більше 0")]
        public decimal Amount
        {
            get => _amount;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Сума має бути більше 0");
                _amount = value;
                OnPropertyChanged();
            }
        }

        [Required]
        public TransactionType Type
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(TypeDisplay));
            }
        }

        public string TypeDisplay => Type == TransactionType.Income ? "Дохід" : "Витрата";

        public string? Note { get; set; }
        public bool IsRecurring { get; set; } = false;
        public int? RecurringDay { get; set; }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string? name = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
