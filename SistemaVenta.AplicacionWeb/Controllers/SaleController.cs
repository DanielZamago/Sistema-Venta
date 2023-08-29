using Microsoft.AspNetCore.Mvc;

namespace SistemaVenta.AplicacionWeb.Controllers
{
    public class SaleController : Controller
    {
        public IActionResult NewSale()
        {
            return View();
        }public IActionResult HistorySale()
        {
            return View();
        }
    }
}
