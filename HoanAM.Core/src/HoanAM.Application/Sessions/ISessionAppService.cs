using System.Threading.Tasks;
using Abp.Application.Services;
using HoanAM.Sessions.Dto;

namespace HoanAM.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
