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

The specified framework version '2.1' could not be parsed The specified framework 'Microsoft.NETCore.App', version '2.1' was not found.

出现下面的错误，只要把EntityFramewrokCore项目设置为启动项目，



Data Source=hk1.yixinjie.com;Initial Catalog=ruiqing;Persist Security Info=True;User ID=rq



再次执行add-migration命令就成功了。
--------------------- 
作者：yurixu 
来源：CSDN 
原文：https://blog.csdn.net/Yurixu/article/details/84578308 
版权声明：本文为博主原创文章，转载请附上博文链接！


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

----



```
FTP地址
主机名：ruiqing.yixinjie.com
用户名：ruiqing.yixinjie.com|ruiqing
密码：rq@123456
使用主动模式连接

瑞庆物流数据库（SQL Server2014）：hk1.yixinjie.com
用户名：rq
密码：rq@2019



临时域名：ruiqing.yixinjie.com
需要部署到hk1上

```

