using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MingChi.NorApp;
using MingChi.NorApp.CRM;
using MingChi.NorApp.CRM.Repositories;
using System.Diagnostics;
using WebCore5MVCApp1.Models;

namespace WebCore5MVCApp1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IApplicationDbContext _applicationDbContext;
        private readonly IJsonConfigurationBuilder _jsonConfigurationBuilder;

        public HomeController(
            ILogger<HomeController> logger, 
            IApplicationDbContext applicationDbContext,
            IJsonConfigurationBuilder jsonConfigurationBuilder)
        {
            _logger = logger;
            _applicationDbContext = applicationDbContext;
            _jsonConfigurationBuilder = jsonConfigurationBuilder;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult CRMList()
        {
            CRMs crm = new CRMs(_applicationDbContext, _jsonConfigurationBuilder);

            return View(crm.GetCustomers());
        }
    }
}
