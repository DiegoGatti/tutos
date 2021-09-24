using System.Threading.Tasks;
using AngularSPWA.Prueba.Models.TokenAuth;
using AngularSPWA.Prueba.Web.Controllers;
using Shouldly;
using Xunit;

namespace AngularSPWA.Prueba.Web.Tests.Controllers
{
    public class HomeController_Tests: PruebaWebTestBase
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