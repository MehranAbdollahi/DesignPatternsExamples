using DesignPatternsExamples._01_CommonDesignTechniques._00_SimpleFactory.Factories;
using DesignPatternsExamples._01_CommonDesignTechniques._00_SimpleFactory.Services;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace DesignPatternsExamples._01_CommonDesignTechniques._00_SimpleFactory.Controllers
{
    public class PaymentWithSimpleFactoryController : Controller
    {
        [Route("/PaymentWithSimpleFactory")]
        [HttpGet]
        public string PaymentWithSimpleFactory()
        {
            var _factory = new PaymentSimpleFactory();

            var _orderService = new OrderServiceWithSimpleFactory(_factory);

            StringBuilder result = new StringBuilder();

            result.AppendLine("Payment methods :");

            result.AppendLine(_orderService.Process("cash"));

            result.AppendLine(_orderService.Process("card"));

            return result.ToString();
        }
    }
}
