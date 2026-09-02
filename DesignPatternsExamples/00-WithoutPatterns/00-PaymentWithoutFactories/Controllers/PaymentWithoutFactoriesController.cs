using DesignPatternsExamples._00_WithoutPatterns._00_PaymentWithoutFactories.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace DesignPatternsExamples._00_WithoutPatterns._00_PaymentWithoutFactories.Controllers
{
    public class PaymentWithoutFactoriesController : Controller
    {
        // GET: PaymentWithoutFactoriesController
        [Route("/PaymentWithoutFactories")]
        [HttpGet]
        public string PaymentWithoutFactories()
        {
            var OrderService = new OrderService();

            StringBuilder result = new StringBuilder();

            result.AppendLine("Paument methods :");

            result.AppendLine(OrderService.Process("cash"));

            result.AppendLine(OrderService.Process("card"));

            return result.ToString();
        }

    }
}
