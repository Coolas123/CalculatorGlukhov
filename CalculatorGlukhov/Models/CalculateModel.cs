namespace CalculatorGlukhov.Models
{
    public class CalculateModel
    {
        public double First { get; init; }
        public double Second { get; init; }

        public CalculateModel(double first, double second) {
            First = first;
            Second = second;
        }
    }
}
