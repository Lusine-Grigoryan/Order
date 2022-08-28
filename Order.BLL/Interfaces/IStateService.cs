using Order.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.BLL.Interfaces
{
    public interface IStateService
    {
        StateUIModel GetState(int id);
        Task<IEnumerable<StateUIModel>> Get(int? id);
        //void Add(StateUIModel model);
        // void Update(StateUIModel model);
        //void Remove(int id);
    }
}
