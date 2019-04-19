using Abp.Application.Services.Dto;
using GWebsite.AbpZeroTemplate.Application.Share.TraCuuBDSs;
using GWebsite.AbpZeroTemplate.Application.Share.TraCuuBDSs.Dto;
using Microsoft.AspNetCore.Mvc;

namespace GWebsite.AbpZeroTemplate.Application.Controllers
{
    [Route("api/[controller]/[action]")]
    public class TraCuuBDSController : GWebsiteControllerBase
    {
        private readonly ITraCuuBDSAppService customerAppService;

        public TraCuuBDSController(ITraCuuBDSAppService customerAppService)
        {
            this.customerAppService = customerAppService;
        }

        [HttpGet]
        public PagedResultDto<TraCuuBDSDto> GetCustomersByFilter(TraCuuBDSFilter customerFilter)
        {
            return customerAppService.GetTraCuuBDS(customerFilter);
        }

        [HttpGet]
        public TraCuuBDSInput GetCustomerForEdit(int id)
        {
            return customerAppService.GetTraCuuBDSForEdit(id);
        }

        [HttpPost]
        public void CreateOrEditCustomer([FromBody] TraCuuBDSInput input)
        {
            customerAppService.CreateOrEdittTraCuuBDS(input);
        }

        [HttpDelete("{id}")]
        public void DeleteCustomer(int id)
        {
            customerAppService.DeleteTraCuuBDS(id);
        }

        [HttpGet]
        public TraCuuBDSForViewDto GetCustomerForView(int id)
        {
            return customerAppService.GetTraCuuBDSForView(id);
        }
    }
}
