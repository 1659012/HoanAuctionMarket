using System.Threading.Tasks;
using Abp.Application.Services;
using HoanAM.Authorization.Accounts.Dto;

namespace HoanAM.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
