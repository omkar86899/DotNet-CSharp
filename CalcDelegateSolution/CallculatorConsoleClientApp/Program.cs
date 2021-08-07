using CalculatorDelegateLib;
using CalculatorConsoleClientApp.Service;

namespace CalculatorConsoleClientApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            PrintService printService = new PrintService();
            PdfGeneratorService pdfGeneratorService = new PdfGeneratorService();
            calculator.ResultChanged += printService.PrintResult;
            calculator.ResultChanged += pdfGeneratorService.GeneratePdf;
            calculator.Add(10, 20);
        }
    }
}
