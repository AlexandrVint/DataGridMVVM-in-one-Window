using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridMVVM.Models
{
    public class MultiplicationModel
    {
        public double _DimentionA { get; set; }

        public double _DimentionB { get; set; }

        public double _Multiplication { get; set; }

        public void AddMultiplicationModel(double DimentionA, double DimentionB, double Multiplication)
        {
            _DimentionA = DimentionA;
            _DimentionB = DimentionB;
            _Multiplication = Multiplication;
        }



    }
}
