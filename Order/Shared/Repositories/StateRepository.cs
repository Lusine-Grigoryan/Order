using Order.DAL.Models;
using Order.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.DAL.Repositories
{
    public class StateRepository : Repository<State>, IStateRepository
    {
        public StateRepository(OrderContext context) : base(context)
        {
        }
    }
}
