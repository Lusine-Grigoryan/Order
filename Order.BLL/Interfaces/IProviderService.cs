using Order.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.BLL.Interfaces
{
    public interface IProviderService
    {
        ProviderUIModel GetProvider(int id);
        Task<IEnumerable<ProviderUIModel>> Get(int? id);
        void Add(ProviderUIModel model);
        void Update(ProviderUIModel model);
        void Remove(int id);
    }
}
