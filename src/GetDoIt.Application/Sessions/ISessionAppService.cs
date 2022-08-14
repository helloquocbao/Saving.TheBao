using System.Threading.Tasks;
using Abp.Application.Services;
using GetDoIt.Sessions.Dto;

namespace GetDoIt.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
