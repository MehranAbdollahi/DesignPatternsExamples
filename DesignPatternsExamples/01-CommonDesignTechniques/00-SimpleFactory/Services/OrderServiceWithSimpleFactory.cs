using DesignPatternsExamples._01_CommonDesignTechniques._00_SimpleFactory.Factories;

namespace DesignPatternsExamples._01_CommonDesignTechniques._00_SimpleFactory.Services
{
    public class OrderServiceWithSimpleFactory
    {
        private readonly PaymentSimpleFactory _paymentSimpleFactory;


        public OrderServiceWithSimpleFactory(PaymentSimpleFactory paymentSimpleFactory)
        {
            _paymentSimpleFactory = paymentSimpleFactory;
        }

        public string Process(string paymentType)
        {
            var payment = _paymentSimpleFactory.Create(paymentType);

            return payment.Pay();
        }
    }
}
