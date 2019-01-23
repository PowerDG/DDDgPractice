using DgCore.MyMission.EntityFrameworkCore;

namespace DgCore.MyMission.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly MyMissionDbContext _context;

        public TestDataBuilder(MyMissionDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            //create test data here...
        }
    }
}