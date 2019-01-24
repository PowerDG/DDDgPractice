“Pomelo.EntityFrameworkCore.MySql.Design”



namespace DgMission.EntityFrameworkCore
{
    public static class DgMissionDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<DgMissionDbContext> builder, string connectionString)
        {
            //builder.UseSqlServer(connectionString);
            builder.UseMySql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<DgMissionDbContext> builder, DbConnection connection)
        {
            //builder.UseSqlServer(connection);
            builder.UseMySql(connection);
        }
    }
}





 "ConnectionStrings": {
        "Default": "Server=localhost; Database=DgMissionDb; Trusted_Connection=True;"
    },

<add name="Default" connectionString="server=localhost;port=3306;database=sampledb;uid=root;password=***" providerName="MySql.Data.MySqlClient"/>





 "ConnectionStrings": {
        "Default": "Server=localhost; ;port=3306;database=DgMissionDb;uid=root;password=wsx1001"
    },

Add-Migration "AbpMy"

Add-Migration AbpMy2018

Update-Database

ALTER TABLE `AbpUserLoginAttempts` RENAME INDEX `IX_AbpUserLoginAttempts_TenancyName_UserNameOrEmailAddress_Result` TO `IX_AbpUserLoginAttempts_TenancyName_UserNameOrEmailAddress_Resu~`;



Failed executing DbCommand (2ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
ALTER TABLE `AbpUserLoginAttempts` RENAME INDEX `IX_AbpUserLoginAttempts_TenancyName_UserNameOrEmailAddress_Result` TO `IX_AbpUserLoginAttempts_TenancyName_UserNameOrEmailAddress_Resu~`;