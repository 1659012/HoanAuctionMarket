using Abp.Application.Services;
using HoanAM.MultiTenancy.Dto;

namespace HoanAM.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

