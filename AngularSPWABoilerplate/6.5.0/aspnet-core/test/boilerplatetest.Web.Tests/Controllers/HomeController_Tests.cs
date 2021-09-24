using System.Threading.Tasks;
using boilerplatetest.Models.TokenAuth;
using boilerplatetest.Web.Controllers;
using Shouldly;
using Xunit;

namespace boilerplatetest.Web.Tests.Controllers
{
    public class HomeController_Tests: boilerplatetestWebTestBase
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