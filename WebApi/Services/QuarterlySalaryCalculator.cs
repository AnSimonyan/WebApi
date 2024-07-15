namespace WebApi.Services
{
    public class QuarterlySalaryCalculator: ISalaryCalculator
    {
        public Double CalculateSalary(Double yearlyAmount)
        {
            return yearlyAmount / 12;
        }
    }
}
