using Microsoft.EntityFrameworkCore;
using MingChi.Domain.CRMs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MingChi.NorApp.CRM.Repositories
{
    public interface IApplicationDbContext
    {
        DbSet<Customer> Customers { get; set; }
    }
}
