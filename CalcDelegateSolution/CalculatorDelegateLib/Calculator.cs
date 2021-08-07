namespace CalculatorDelegateLib
{
    public delegate void DMathOperationHandler(int result);
    public class Calculator
    {
        public event DMathOperationHandler ResultChanged;
        public int Add(int firstNumber, int secondNumber)
        {
            int result = firstNumber + secondNumber;
            if (ResultChanged != null)
            {
                ResultChanged(result);
            }
            return firstNumber + secondNumber;
        }
    }
}