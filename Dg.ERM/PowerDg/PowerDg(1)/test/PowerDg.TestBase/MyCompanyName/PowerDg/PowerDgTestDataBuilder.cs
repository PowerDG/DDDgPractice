using Volo.Abp.DependencyInjection;
using Volo.Abp.Guids;

namespace PowerDg
{
    public class PowerDgTestDataBuilder : ITransientDependency
    {
        private readonly IGuidGenerator _guidGenerator;
        private PowerDgTestData _testData;

        public PowerDgTestDataBuilder(
            IGuidGenerator guidGenerator,
            PowerDgTestData testData)
        {
            _guidGenerator = guidGenerator;
            _testData = testData;
        }

        public void Build()
        {
            
        }
    }
}