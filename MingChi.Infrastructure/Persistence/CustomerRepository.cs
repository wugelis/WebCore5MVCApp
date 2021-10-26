using Microsoft.EntityFrameworkCore;
using MingChi.Domain.CRMs.Models;
using MingChi.NorApp.CRM.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MingChi.Infrastructure.Persistence
{
    /// <summary>
    /// 
    /// </summary>
    public class CustomerRepository : ICustomerRepository
    {
        private readonly IApplicationDbContext _applicationDbContext;

        public CustomerRepository(IApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public void Add(Customer customer)
        {
            _applicationDbContext.Customers.Add(customer);
        }

        public void Edit(Customer customer)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return _applicationDbContext.Customers.ToList();
        }
    }
}
