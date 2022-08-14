using System.Threading.Tasks;
using Abp.Application.Services;
using GetDoIt.Authorization.Accounts.Dto;

namespace GetDoIt.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
