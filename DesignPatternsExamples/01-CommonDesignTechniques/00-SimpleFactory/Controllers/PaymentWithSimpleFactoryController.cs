using DesignPatternsExamples._01_CommonDesignTechniques._00_SimpleFactory.Factories;
using DesignPatternsExamples._01_CommonDesignTechniques._00_SimpleFactory.Services;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace DesignPatternsExamples._01_CommonDesignTechniques._00_SimpleFactory.Controllers
{
    public class PaymentWithSimpleFactoryController : Controller
    {
        /*
         * Simple Factory:
         *
         * In the previous example (Without Factory), OrderService was
         * responsible for creating concrete payment objects directly.
         *
         * Example:
         *
         *     new CashPayment();
         *     new CardPayment();
         *
         * This caused OrderService to be tightly coupled to concrete
         * payment classes and mixed object creation with business logic.
         *
         * In this example, object creation is moved to PaymentSimpleFactory.
         *
         * The flow is:
         *
         *     Controller
         *          ↓
         *     OrderService
         *          ↓
         *     PaymentSimpleFactory
         *          ↓
         *     IPayment
         *          ↓
         *     CashPayment / CardPayment
         *
         * OrderService is now responsible only for processing the payment.
         * PaymentSimpleFactory is responsible for deciding which payment
         * implementation should be created.
         *
         * Note:
         * This version intentionally creates the Factory and OrderService
         * manually so that the Simple Factory pattern itself is easy to see.
         *
         * In the next step, Dependency Injection (DI) will be used to remove
         * these manual object creations from the Controller.
         */

        [Route("/PaymentWithSimpleFactory")]
        [HttpGet]
        public string PaymentWithSimpleFactory()
        {
            var factory = new PaymentSimpleFactory();

            var orderService = new OrderServiceWithSimpleFactory(factory);

            StringBuilder result = new StringBuilder();

            result.AppendLine("Payment methods :");

            result.AppendLine(orderService.Process("cash"));

            result.AppendLine(orderService.Process("card"));

            return result.ToString();
        }
    }
}
