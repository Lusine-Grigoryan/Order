using AutoMapper;
using Order.BLL.Extensions;
using Order.BLL.Interfaces;
using Order.Common.Models;
using Order.Configuration;
using Order.DAL.Models;
using Order.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.BLL.Services
{
    public class StateService : IStateService
    {
        private readonly IUnitOfWork _unitOfWork;

        public StateService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<StateUIModel>> Get(int? id)
        {
            var list = await _unitOfWork.StateRepository.Get(p => p.Id == id);
            return AutoMapperConfig.Instance.Map<IEnumerable<State>, IEnumerable<StateUIModel>>(list);
        }

        public StateUIModel GetState(int id)
        {
            return _unitOfWork.StateRepository
                .GetByID(id)
                .MapTo<StateUIModel>();
        }
    }
}
