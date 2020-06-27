using System.Threading.Tasks;
using Abp.Application.Services;
using GrandesTrabajos.Sessions.Dto;

namespace GrandesTrabajos.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
