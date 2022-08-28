using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Shared.Interfaces
{
    public interface IUnitOfWork
    {
        IProviderRepository ProviderRepository { get; set; }
        IStateRepository StateRepository { get; set; }

        void Commit();
    }
}
