using Abp.Application.Services;
using GrandesTrabajos.MultiTenancy.Dto;

namespace GrandesTrabajos.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

