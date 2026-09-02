namespace DesignPatternsExamples._00_WithoutPatterns._00_PaymentWithoutFactories.Services
{
    public class CashPayment : IPayment
    {
        public string Pay()
        {
            return("Paying with cash 💸");
        }
    }
}
