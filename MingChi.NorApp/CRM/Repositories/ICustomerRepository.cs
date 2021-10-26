using Microsoft.EntityFrameworkCore;
using MingChi.Domain.CRMs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MingChi.NorApp.CRM.Repositories
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetCustomers();
        void Add(Customer customer);
        void Edit(Customer customer);
    }
}
