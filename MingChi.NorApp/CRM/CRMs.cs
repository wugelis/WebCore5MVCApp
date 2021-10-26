using System.Collections.Generic;
using System.Linq;
using MingChi.NorApp.CRM.ViewModels;
using MingChi.NorApp.CRM;
using MingChi.NorApp.CRM.Repositories;

namespace MingChi.NorApp
{
    /// <summary>
    /// 客戶關係系統 CRM
    /// </summary>
    public class CRMs
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CRMs(ICustomerRepository customerRepository, IUnitOfWork unitOfWork)
        {
            _customerRepository = customerRepository;
            _unitOfWork = unitOfWork;
        }
        /// <summary>
        /// 取回所有的 Customers
        /// </summary>
        /// <returns></returns>
        public IEnumerable<CustomerViewModel> GetCustomers()
        {
            var result = from cus in _customerRepository.GetCustomers()
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

        public int AddCustomer(CustomerViewModel customer)
        {
            _customerRepository.Add(new Domain.CRMs.Models.Customer()
            {
                CustomerId = customer.CustomerId,
                ContactName = customer.ContactName,
                ContactTitle = customer.ContactTitle,
                CompanyName = customer.CompanyName,
                Country = customer.Country,
                Address = customer.Address,
                City = customer.City,
                Region = customer.Region,
                PostalCode = customer.PostalCode,
                Fax = customer.Fax
            });

            return _unitOfWork.Commit();
        }
    }
}
