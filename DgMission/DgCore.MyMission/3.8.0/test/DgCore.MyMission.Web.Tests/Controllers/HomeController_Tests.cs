using System.Threading.Tasks;
using DgCore.MyMission.Web.Controllers;
using Shouldly;
using Xunit;

namespace DgCore.MyMission.Web.Tests.Controllers
{
    public class HomeController_Tests: MyMissionWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}
