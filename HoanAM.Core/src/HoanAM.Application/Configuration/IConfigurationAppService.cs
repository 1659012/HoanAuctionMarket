using System.Threading.Tasks;
using HoanAM.Configuration.Dto;

namespace HoanAM.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
