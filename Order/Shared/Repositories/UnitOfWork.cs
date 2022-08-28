using Order.DAL.Models;
using Order.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.DAL.Repositories
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly OrderContext _context;

        public IProviderRepository ProviderRepository { get; set; }
        public IStateRepository StateRepository { get; set; }
        public UnitOfWork()
        {
            _context = new OrderContext();

            ProviderRepository = new ProviderRepository(_context);
            StateRepository = new StateRepository(_context);
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        private bool _disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }

            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
