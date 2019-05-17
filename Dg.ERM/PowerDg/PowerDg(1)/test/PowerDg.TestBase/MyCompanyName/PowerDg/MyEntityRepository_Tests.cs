using System.Threading.Tasks;
using Volo.Abp.Modularity;
using Xunit;

namespace PowerDg
{
    public abstract class MyEntityRepository_Tests<TStartupModule> : PowerDgTestBase<TStartupModule>
        where TStartupModule : IAbpModule
    {
        [Fact]
        public async Task Test1()
        {

        }
    }
}
