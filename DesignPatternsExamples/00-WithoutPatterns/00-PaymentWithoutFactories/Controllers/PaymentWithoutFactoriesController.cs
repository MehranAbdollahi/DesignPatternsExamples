using DesignPatternsExamples._00_WithoutPatterns._00_PaymentWithoutFactories.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace DesignPatternsExamples._00_WithoutPatterns._00_PaymentWithoutFactories.Controllers
{
    public class PaymentWithoutFactoriesController : Controller
    {
        /*
         * Problem:
         * - OrderService creates concrete payment objects.
         * - Creation logic is mixed with business logic.
         * - Adding a new payment type requires modifying OrderService.
         * - This creates tight coupling.
         *
         * Solution:
         * Use Simple Factory to separate object creation from business logic.
         */
        [Route("/PaymentWithoutFactories")]
        [HttpGet]
        public string PaymentWithoutFactories()
        {
            var orderService = new OrderService();

            StringBuilder result = new StringBuilder();

            result.AppendLine("Payment methods :");

            result.AppendLine(orderService.Process("cash"));

            result.AppendLine(orderService.Process("card"));

            return result.ToString();
        }

    }
}
