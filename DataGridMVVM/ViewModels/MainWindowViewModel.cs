using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataGridMVVM.ViewModels.Base;

namespace DataGridMVVM.ViewModels
{
    public class MainWindowViewModel:ViewModel
    {

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

    }
}
