namespace DataGridMVVM.Models
{
    public class OperationEntity
    {
        public string Name { get; }
        public double FirstOperand { get; }

        public double SecondOperand { get; }

        public double Result { get; }

        public OperationEntity(string name, double firstOperand, double secondOperand, double result)
        {
            Name = name;
            FirstOperand = firstOperand;
            SecondOperand = secondOperand;
            Result = result;
        }
    }
}
