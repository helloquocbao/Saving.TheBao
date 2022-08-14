using System.Threading.Tasks;
using GetDoIt.Configuration.Dto;

namespace GetDoIt.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
