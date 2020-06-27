using System.Threading.Tasks;
using GrandesTrabajos.Models.TokenAuth;
using GrandesTrabajos.Web.Controllers;
using Shouldly;
using Xunit;

namespace GrandesTrabajos.Web.Tests.Controllers
{
    public class HomeController_Tests: GrandesTrabajosWebTestBase
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