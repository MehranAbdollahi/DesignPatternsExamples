namespace DesignPatternsExamples._00_WithoutPatterns._00_PaymentWithoutFactories.Services
{
    public class CardPayment : IPayment
    {
        public string Pay()
        {
            return("Paying with card 💳");
        }
    }
}
