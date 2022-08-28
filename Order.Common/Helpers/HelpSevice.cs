using Order.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Common.Helpers
{
    public class HelpSevice
    {
        private readonly IServiceProvider _serviceProvider;
        public ProviderUIModel provider;
        public List<StateUIModel> states;
        public HelpSevice(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        
    }
}
