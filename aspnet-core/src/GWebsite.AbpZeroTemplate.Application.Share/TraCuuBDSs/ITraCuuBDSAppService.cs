using Abp.Application.Services.Dto;
using GWebsite.AbpZeroTemplate.Application.Share.TraCuuBDSs.Dto;

namespace GWebsite.AbpZeroTemplate.Application.Share.TraCuuBDSs
{
    public interface ITraCuuBDSAppService
    {
        void CreateOrEdittTraCuuBDS(TraCuuBDSInput TraCuuBDSInput);
        TraCuuBDSInput GetTraCuuBDSForEdit(int id);
        void DeleteTraCuuBDS(int id);
        PagedResultDto<TraCuuBDSDto> GetTraCuuBDS(TraCuuBDSFilter input);
        TraCuuBDSForViewDto GetTraCuuBDSForView(int id);
    }
}
