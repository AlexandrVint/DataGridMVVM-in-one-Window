using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using DataGridMVVM.Commands;
using DataGridMVVM.Models;
using DataGridMVVM.Service;
using DataGridMVVM.ViewModels.Base;
using Microsoft.VisualBasic;

namespace DataGridMVVM.ViewModels
{
    public class MainWindowViewModel:ViewModel
    {
        public ObservableCollection<MultiplicationModel> Collection { get; set; }



        #region DimentionA : double - первый множитель
        /// <summary>
        /// первый множитель
        /// </summary>
        private double _DimentionA;

        public double DimentionA
        {
            get => _DimentionA;
            set
            {
                
                Set(ref _DimentionA, value);
                Multiplication = DimentionA * DimentionB;
                

            }
        }
        #endregion

        #region DimentionB : double - второй множитель
        /// <summary>
        /// второй множитель
        /// </summary>
        private double _DimentionB;

        public double DimentionB
        {
            get => _DimentionB;
            set
            {
                
                Set(ref _DimentionB, value);
                Multiplication = DimentionA * DimentionB;


            } 
        }
        #endregion

        #region Multiplication : double - произведение
        /// <summary>
        /// произведение
        /// </summary>
        private double _Multiplication;

        public double Multiplication
        {
            get => _Multiplication;
            set => Set(ref _Multiplication, value);
        }
        #endregion


        #region Команды

        public ICommand AddCommand { get; }

        private void OnAddCommand(object p)
        {
            Collection = new ObservableCollection<MultiplicationModel>();
            MultiplicationModel maMultiplicationModel = p as MultiplicationModel;
            maMultiplicationModel.AddMultiplicationModel(DimentionA, DimentionB, Multiplication);
            Collection.Add(maMultiplicationModel);
           



        }

        private bool CanAddCommand(object p)
        {
            return true;
        }

        #endregion

        #region Конструктор

        public MainWindowViewModel()
        {
            AddCommand = new LambdaCommand(OnAddCommand, CanAddCommand);
        }


            #endregion

    }
}
