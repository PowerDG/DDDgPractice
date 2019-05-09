using System;
using System.Threading.Tasks;
using Abp.TestBase;
using DgCore.MyMission.EntityFrameworkCore;
using DgCore.MyMission.Tests.TestDatas;

namespace DgCore.MyMission.Tests
{
    public class MyMissionTestBase : AbpIntegratedTestBase<MyMissionTestModule>
    {
        public MyMissionTestBase()
        {
            UsingDbContext(context => new TestDataBuilder(context).Build());
        }

        protected virtual void UsingDbContext(Action<MyMissionDbContext> action)
        {
            using (var context = LocalIocManager.Resolve<MyMissionDbContext>())
            {
                action(context);
                context.SaveChanges();
            }
        }

        protected virtual T UsingDbContext<T>(Func<MyMissionDbContext, T> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<MyMissionDbContext>())
            {
                result = func(context);
                context.SaveChanges();
            }

            return result;
        }

        protected virtual async Task UsingDbContextAsync(Func<MyMissionDbContext, Task> action)
        {
            using (var context = LocalIocManager.Resolve<MyMissionDbContext>())
            {
                await action(context);
                await context.SaveChangesAsync(true);
            }
        }

        protected virtual async Task<T> UsingDbContextAsync<T>(Func<MyMissionDbContext, Task<T>> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<MyMissionDbContext>())
            {
                result = await func(context);
                context.SaveChanges();
            }

            return result;
        }
    }
}
