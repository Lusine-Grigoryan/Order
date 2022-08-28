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
    public class ProviderService : IProviderService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProviderService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Add(ProviderUIModel model)
        {
            var provider = model.MapTo<Provider>();

            _unitOfWork.ProviderRepository.Insert(provider);
            _unitOfWork.Commit();
        }

        public async Task<IEnumerable<ProviderUIModel>> Get(int? id)
        {
            var list =  await _unitOfWork.ProviderRepository.Get(p=>p.Id == id);
            foreach (var item in list)
                 SetProviderItems(item);

            return AutoMapperConfig.Instance.Map<IEnumerable<Provider>, IEnumerable<ProviderUIModel>>(list);

        }

        private void SetProviderItems(Provider provider)
        {
            provider.State = _unitOfWork.StateRepository.GetByID(provider.StateId);
        }

        public ProviderUIModel GetProvider(int id)
        {
            var provider = _unitOfWork.ProviderRepository.GetByID(id);
            SetProviderItems(provider);

            return provider.MapTo<ProviderUIModel>();
        }

        public void Remove(int id)
        {
            var provider = _unitOfWork.ProviderRepository.GetByID(id);

            if (provider == null)
            {
                throw new Exception("Provider is not found.");
            }
            _unitOfWork.ProviderRepository.Delete(provider);
            _unitOfWork.Commit();
        }

        public void Update(ProviderUIModel model)
        {
            var provider = _unitOfWork.ProviderRepository.GetByID(model.Id);

            if (provider == null)
            {
                throw new Exception("Provider is not found.");
            }

            provider = model.MapTo<Provider>();

            _unitOfWork.ProviderRepository.Update(provider);
            _unitOfWork.Commit();
        }
    }
}
