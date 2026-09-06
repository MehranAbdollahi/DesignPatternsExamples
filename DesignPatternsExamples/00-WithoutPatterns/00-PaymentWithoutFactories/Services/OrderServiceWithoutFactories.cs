using DesignPatternsExamples._03_Shared.Payments;

namespace DesignPatternsExamples._00_WithoutPatterns._00_PaymentWithoutFactories.Services
{
    public class OrderServiceWithoutFactories
    {
        public string Process(string paymentType)
        {
            if (paymentType == "cash")
            {
                var payment = new CashPayment();

                return payment.Pay();
            }
            else if (paymentType == "card")
            {
                var payment = new CardPayment();

                return payment.Pay();
            }
            else
            {
                return "Payment method not found...";
            }
        }
    }
}
