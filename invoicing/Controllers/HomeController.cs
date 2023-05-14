using invoicing.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace invoicing.Controllers
{
    public class HomeController : Controller
    {
        private const decimal QUANTITY_TO_ADD = 20;
        private const decimal PERCENT_DISCOUNT_APPLY = 10;

        public HomeController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Results(InvoicingViewModel invoicing)
        {
            var totalReceivable = (invoicing.HoursValue * invoicing.HoursWorked + invoicing.Antiquity) * QUANTITY_TO_ADD;
            var totalDescount = totalReceivable * (PERCENT_DISCOUNT_APPLY / 100);
            var totalPayable = totalReceivable - totalDescount;

            var resultInvoicing = new InvoicingResultViewModel(
                    invoicing.FullName,
                    invoicing.Antiquity,
                    invoicing.HoursValue,
                    totalReceivable,
                    totalDescount,
                    totalPayable
                );
            Console.WriteLine(resultInvoicing);

            return View(resultInvoicing);
        }
    }
}