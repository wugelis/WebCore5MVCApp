using System.Collections.Generic;
using System.Linq;
using MingChi.NorApp.CRM.ViewModels;
using MingChi.NorApp.CRM;
using MingChi.NorApp.CRM.Repositories;

namespace MingChi.NorApp
{
    public class CRMs
    {
        private readonly IApplicationDbContext _applicationDbContext;
        private readonly IJsonConfigurationBuilder jsonConfigurationBuilder;

        public CRMs(IApplicationDbContext applicationDbContext, IJsonConfigurationBuilder jsonConfigurationBuilder)
        {
            this.jsonConfigurationBuilder = jsonConfigurationBuilder;

            _applicationDbContext = applicationDbContext; //new ApplicationDbContext(jsonConfigurationBuilder.GetConnectionString());
        }
        /// <summary>
        /// 取回所有的 Customers
        /// </summary>
        /// <returns></returns>
        public IEnumerable<CustomerViewModel> GetCustomers()
        {
            var result = from cus in _applicationDbContext.Customers
                         select new CustomerViewModel()
                         {
                             CustomerId = cus.CustomerId,
                             ContactName = cus.ContactName,
                             ContactTitle = cus.ContactTitle,
                             CompanyName = cus.CompanyName,
                             Address = cus.Address,
                             City = cus.City,
                             Phone = cus.Phone
                         };
                

            return result;
        }
    }
}
