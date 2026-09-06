using DesignPatternsExamples._03_Shared.Interfaces;

namespace DesignPatternsExamples._03_Shared.Payments
{
    public class CashPayment : IPayment
    {
        public string Pay()
        {
            return "Paying with cash 💸";
        }
    }
}
