using DesignPatternsExamples._03_Shared.Interfaces;
using DesignPatternsExamples._03_Shared.Payments;

namespace DesignPatternsExamples._01_CommonDesignTechniques._00_SimpleFactory.Factories
{
    public class PaymentSimpleFactory
    {
        public IPayment Create(string paymentType)
        {
            if (paymentType == "cash")
            {
                return new CashPayment();
            }

            if (paymentType == "card")
            {
                return new CardPayment();
            }

            throw new ArgumentException("Payment method not found...");
        }
    }
}
