using MingChi.DataAccess.Models;
using MingChi.NorApp.CRM;
using MingChi.NorApp.CRM.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MingChi.Infrastructure.Persistence
{
    /// <summary>
    /// 交易控制
    /// </summary>
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IApplicationDbContext _applicationDbContext;

        public UnitOfWork(IApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        /// <summary>
        /// 確認交易
        /// </summary>
        /// <returns></returns>
        public int Commit()
        {
            return _applicationDbContext.SaveChanges();
        }
    }
}
