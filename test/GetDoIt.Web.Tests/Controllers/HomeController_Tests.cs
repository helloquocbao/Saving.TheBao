using System.Threading.Tasks;
using GetDoIt.Models.TokenAuth;
using GetDoIt.Web.Controllers;
using Shouldly;
using Xunit;

namespace GetDoIt.Web.Tests.Controllers
{
    public class HomeController_Tests: GetDoItWebTestBase
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