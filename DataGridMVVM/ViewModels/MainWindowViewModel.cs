using DataGridMVVM.Commands;
using DataGridMVVM.Models;
using MVVM.ViewModels;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace DataGridMVVM.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<OperationEntity> Collection { get; } = new();



        #region Свойства
        /// <summary>Первый множитель.</summary>
        public double DimentionA
        {
            get => Get<double>();
            set => Set(value);
        }

        /// <summary>Второй множитель.</summary>
        public double DimentionB
        {
            get => Get<double>();
            set => Set(value);
        }

        /// <summary>Произведение.</summary>
        public double Multiplication
        {
            get => Get<double>();
            private set => Set(value);
        }
        #endregion


        #region Команды
        public RelayCommand AddCommand => GetCommand(AddCommandExecute);

        private void AddCommandExecute()
        {
            Collection.Add(new OperationEntity("Умножение", DimentionA, DimentionB, Multiplication));
        }
        #endregion

        protected override void OnPropertyChanged(string propertyName, object? oldValue, object? newValue)
        {
            base.OnPropertyChanged(propertyName, oldValue, newValue);
            if(propertyName is nameof(DimentionA) or nameof(DimentionB))
            {
                Multiplication= DimentionA * DimentionB;
            }
        }

    }
}
