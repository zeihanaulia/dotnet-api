using System.Threading.Tasks;
using dotnet-api.Configuration.Dto;

namespace dotnet-api.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
