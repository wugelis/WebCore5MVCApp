using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MingChi.NorApp;
using MingChi.NorApp.CRM;
using MingChi.NorApp.CRM.Repositories;
using MingChi.NorApp.CRM.ViewModels;
using System.Diagnostics;
using WebCore5MVCApp1.Models;

namespace WebCore5MVCApp1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICustomerRepository _customerRepository;
        private readonly IUnitOfWork _unitOfWork;

        public HomeController(
            ILogger<HomeController> logger, 
            ICustomerRepository customerRepository,
            IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _customerRepository = customerRepository;
            _unitOfWork = unitOfWork;
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
            CRMs crm = new CRMs(_customerRepository, _unitOfWork);

            return View(crm.GetCustomers());
        }

        public IActionResult AddCustomer()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCustomer(CustomerViewModel customer)
        {
            CRMs crm = new CRMs(_customerRepository, _unitOfWork);

            crm.AddCustomer(customer);

            return RedirectToAction("CRMList");
        }
    }
}
