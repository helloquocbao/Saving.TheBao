using Abp.Application.Services;
using GetDoIt.MultiTenancy.Dto;

namespace GetDoIt.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

