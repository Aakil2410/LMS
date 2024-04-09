using System.Threading.Tasks;
using LibraryManagementSystem.Configuration.Dto;

namespace LibraryManagementSystem.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
