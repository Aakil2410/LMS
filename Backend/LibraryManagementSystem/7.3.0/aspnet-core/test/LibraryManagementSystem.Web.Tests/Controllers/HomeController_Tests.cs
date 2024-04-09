using System.Threading.Tasks;
using LibraryManagementSystem.Models.TokenAuth;
using LibraryManagementSystem.Web.Controllers;
using Shouldly;
using Xunit;

namespace LibraryManagementSystem.Web.Tests.Controllers
{
    public class HomeController_Tests: LibraryManagementSystemWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}