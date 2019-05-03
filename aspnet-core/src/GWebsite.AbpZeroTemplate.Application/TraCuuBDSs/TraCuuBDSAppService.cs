using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using GWebsite.AbpZeroTemplate.Application;
using GWebsite.AbpZeroTemplate.Application.Share.TraCuuBDSs;
using GWebsite.AbpZeroTemplate.Application.Share.TraCuuBDSs.Dto;
using GWebsite.AbpZeroTemplate.Core.Authorization;
using GWebsite.AbpZeroTemplate.Core.Models;
using System.Linq;
using System.Linq.Dynamic.Core;

namespace GWebsite.AbpZeroTemplate.Web.Core.TraCuuBDSs
{
    [AbpAuthorize(GWebsitePermissions.Pages_Administration_MenuClient)]
    public class TraCuuBDSAppService : GWebsiteAppServiceBase, ITraCuuBDSAppService
    {
        private readonly IRepository<TraCuuBDS> customerRepository;

        public TraCuuBDSAppService(IRepository<TraCuuBDS> customerRepository)
        {
            this.customerRepository = customerRepository;
        }

        #region Public Method

        public void CreateOrEditTraCuuBDS(TraCuuBDSInput customerInput)
        {
            if (customerInput.Id == 0)
            {
                Create(customerInput);
            }
            else
            {
                Update(customerInput);
            }
        }

        public void DeleteTraCuuBDS(int id)
        {
            var customerEntity = customerRepository.GetAll().Where(x => !x.IsDelete).SingleOrDefault(x => x.Id == id);
            if (customerEntity != null)
            {
                customerEntity.IsDelete = true;
                customerRepository.Update(customerEntity);
                CurrentUnitOfWork.SaveChanges();
            }
        }

        public TraCuuBDSInput GetTraCuuBDSForEdit(int id)
        {
            var customerEntity = customerRepository.GetAll().Where(x => !x.IsDelete).SingleOrDefault(x => x.Id == id);
            if (customerEntity == null)
            {
                return null;
            }
            return ObjectMapper.Map<TraCuuBDSInput>(customerEntity);
        }

      

        public PagedResultDto<TraCuuBDSDto> GetTraCuuBDS(TraCuuBDSFilter input)
        {
            var query = customerRepository.GetAll().Where(x => !x.IsDelete);

            // filter by value
            if (input.maBDS != null)
            {
                query = query.Where(x => x.maBDS.ToLower().Equals(input.maBDS));
            }

            var totalCount = query.Count();

            // sorting
            if (!string.IsNullOrWhiteSpace(input.Sorting))
            {
                query = query.OrderBy(input.Sorting);
            }

            // paging
            var items = query.PageBy(input).ToList();

            // result
            return new PagedResultDto<TraCuuBDSDto>(
                totalCount,
                items.Select(item => ObjectMapper.Map<TraCuuBDSDto>(item)).ToList());
        }

        #endregion

        #region Private Method

        [AbpAuthorize(GWebsitePermissions.Pages_Administration_MenuClient_Create)]
        private void Create(TraCuuBDSInput customerInput)
        {
            var customerEntity = ObjectMapper.Map<TraCuuBDS>(customerInput);
            SetAuditInsert(customerEntity);
            customerRepository.Insert(customerEntity);
            CurrentUnitOfWork.SaveChanges();
        }

        [AbpAuthorize(GWebsitePermissions.Pages_Administration_MenuClient_Edit)]
        private void Update(TraCuuBDSInput customerInput)
        {
            var customerEntity = customerRepository.GetAll().Where(x => !x.IsDelete).SingleOrDefault(x => x.Id == customerInput.Id);
            if (customerEntity == null)
            {
            }
            ObjectMapper.Map(customerInput, customerEntity);
            SetAuditEdit(customerEntity);
            customerRepository.Update(customerEntity);
            CurrentUnitOfWork.SaveChanges();
        }

        public void CreateOrEdittTraCuuBDS(TraCuuBDSInput TraCuuBDSInput)
        {
            throw new System.NotImplementedException();
        }

        TraCuuBDSForViewDto ITraCuuBDSAppService.GetTraCuuBDSForView(int id)
        {
            throw new System.NotImplementedException();
        }

        #endregion
    }
}
