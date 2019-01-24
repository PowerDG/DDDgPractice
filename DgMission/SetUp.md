“Pomelo.EntityFrameworkCore.MySql.Design”

934082346
123456

url:rm-m5eo20y3da0474671mo.mysql.rds.aliyuncs.com
端口：3306
账号：db_develop
密码：11qaz!11QAZ

先删除所有迁移

Add-Migration "AbpMy"

Add-Migration AbpMy201810

Update-Database





namespace DgMission.EntityFrameworkCore
{
​    public static class DgMissionDbContextConfigurer
​    {
​        public static void Configure(DbContextOptionsBuilder<DgMissionDbContext> builder, string connectionString)
​        {
​            //builder.UseSqlServer(connectionString);
​            builder.UseMySql(connectionString);
​        }

        public static void Configure(DbContextOptionsBuilder<DgMissionDbContext> builder, DbConnection connection)
        {
            //builder.UseSqlServer(connection);
            builder.UseMySql(connection);
        }
    }
}

  "ConnectionStrings": {
​    "Default": "Server=192.168.1.105; Database=RQDDDCoreDb;user id=root;pwd=12345;"
  },



 "ConnectionStrings": {
​        "Default": "Server=localhost; Database=DgMissionDb; Trusted_Connection=True;"
​    },

<add name="Default" connectionString="server=localhost;port=3306;database=sampledb;uid=root;password=***" providerName="MySql.Data.MySqlClient"/>





 "ConnectionStrings": {
​        "Default": "Server=localhost; ;port=3306;database=DgMissionDb;uid=root;password=wsx1001"
​    },



ALTER TABLE `AbpUserLoginAttempts` RENAME INDEX `IX_AbpUserLoginAttempts_TenancyName_UserNameOrEmailAddress_Result` TO `IX_AbpUserLoginAttempts_TenancyName_UserNameOrEmailAddress_Resu~`;

IX_AbpUserLoginAttempts_TenancyName_UserNameOrEmailAddress_Resu

Failed executing DbCommand (2ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
ALTER TABLE `AbpUserLoginAttempts` RENAME INDEX `IX_AbpUserLoginAttempts_TenancyName_UserNameOrEmailAddress_Result` TO `IX_AbpUserLoginAttempts_TenancyName_UserNameOrEmailAddress_Resu~`;



---



```csharp
        migrationBuilder.CreateIndex(
            name: "IX_AbpNotificationSubscriptions_TenantId_NotificationName_EntityTypeName_EntityId_UserId",
            table: "AbpNotificationSubscriptions",
            columns: new[] { "TenantId", "NotificationName", "EntityTypeName", "EntityId", "UserId" });
```




```csharp
  migrationBuilder.CreateIndex(
                name: "IX_AbpNotificationSubscriptions_NotificationName_EntityTypeName_EntityId_UserId",
                table: "AbpNotificationSubscriptions",
                columns: new[] { "NotificationName", "EntityTypeName", "EntityId", "UserId" });
```

```csharp
     migrationBuilder.CreateIndex(
                name: "IX_AbpUserLoginAttempts_TenancyName_UserOrEmail_Result",
                table: "AbpUserLoginAttempts",
                columns: new[] { "TenancyName", "UserNameOrEmailAddress", "Result" });

```







```csharp

Failed executing DbCommand (4ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
ALTER TABLE `AbpUserLoginAttempts` RENAME INDEX `IX_AbpUserLoginUserNameOrEmailAddress_Result` TO `IX_AbpUserLoginAttempts_TenancyName_UserNameOrEmailAddress_Result`;


Identifier name 'IX_AbpUserLoginAttempts_TenancyName_UserNameOrEmailAddress_Result' is too long

```

