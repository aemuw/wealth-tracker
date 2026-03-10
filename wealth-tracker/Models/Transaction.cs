using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace wealth_tracker.Models
{
    public enum TransactionType
    {
        Income, 
        Expense
    }
    public class Transaction : INotifyPropertyChanged
    {
        private DateTime _date;
        private string _category = string.Empty;
        private decimal _amount;
        private TransactionType _type;

        public Guid Id { get; init; } = Guid.NewGuid();
        
        public DateTime Date
        {
            get => _date;
            set 
            { 
                _date = value; 
                OnPropertyChanged(); 
            }
        }
        public string Category
        {
            get => _category;
            set 
            { _category = value; 
                OnPropertyChanged(); 
            }
        }

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

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string? name = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
