using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Abp.Domain.Repositories;
using AutoMapper;


using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;




using Microsoft.AspNetCore.Identity;


using Abp.Authorization.Users;
using Abp.Authorization; 
using Abp.MultiTenancy;
using Abp.Runtime.Security; 
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using Abp.Runtime.Session;
using Abp.Application.Services.Dto;







#region MyRegion


//using RQCore.Authentication.External;
//using RQCore.Authentication.JwtBearer;
//using RQCore.Authorization;
//using RQCore.Models.TokenAuth;

////using Microsoft.AspNetCore.Http;
//using NPOI.SS.UserModel;
//using NPOI.XSSF.UserModel;
//using RQCore.Controllers;
//using RQCore.RQDtos;
//using RQCore.RQEnitity;
//using RQCore.Authorization.Roles;
//using RQCore.Authorization.Users;
//using RQCore.Users;
//using RQCore.Users.Dto;
//using RQCore.MultiTenancy;
//using Abp.Collections.Extensions;
//using RQCore.Roles.Dto;
//using RQCore.Sessions.Dto;

#endregion



namespace RQCore.Web.Host.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    public class CoreDGDictController : RQCoreControllerBase
    {
        #region constructor 构造方法
        private readonly RoleManager _roleManager;
        private readonly UserManager _userManager;
        private readonly IRepository<Role> _roleRepository;
        private readonly IPasswordHasher<User> _passwordHasher;

        private readonly LogInManager _logInManager;
        private readonly ITenantCache _tenantCache;
        private readonly AbpLoginResultTypeHelper _abpLoginResultTypeHelper;
        private readonly TokenAuthConfiguration _configuration;
        private readonly IExternalAuthConfiguration _externalAuthConfiguration;
        private readonly IExternalAuthManager _externalAuthManager;
        private readonly UserRegistrationManager _userRegistrationManager;






        public CoreDGDictController(

                IRepository<User, long> repository,
            UserManager userManager,
            RoleManager roleManager,
            IRepository<Role> roleRepository,
            IPasswordHasher<User> passwordHasher,

        
            LogInManager logInManager,
            ITenantCache tenantCache,
            AbpLoginResultTypeHelper abpLoginResultTypeHelper,
            TokenAuthConfiguration configuration,
            IExternalAuthConfiguration externalAuthConfiguration,
            IExternalAuthManager externalAuthManager,
            UserRegistrationManager userRegistrationManager)
        //: base(repository)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _roleRepository = roleRepository;
            _passwordHasher = passwordHasher;


            _logInManager = logInManager;
            _tenantCache = tenantCache;
            _abpLoginResultTypeHelper = abpLoginResultTypeHelper;
            _configuration = configuration;
            _externalAuthConfiguration = externalAuthConfiguration;
            _externalAuthManager = externalAuthManager;
            _userRegistrationManager = userRegistrationManager;
        }

        #endregion
        
        [HttpPost("api/Authenticate")]
        public async Task<JsonResult> Authenticate([FromBody] AuthenticateModel model)
        {   //AuthenticateResultModel 
            SortedDictionary<string, object> DgDict = new SortedDictionary<string, object>();

            var loginResult = await GetLoginResultAsync(
                model.UserNameOrEmailAddress,
                model.Password,
                GetTenancyNameOrNull()
            );
            #region 角色列表版本

            DgDict.Add("permissionsToRolesVersion", 1001);

            #endregion

            #region 用户信息【暂无】

            //DgDict.Add("permissionsToRolesVersion", 1001);

            //  ////用户信息
            //  //UserAppService userAppService = new UserAppService();
            //  //var user = await userAppService.GetEntityByIdAsync( loginResult.User.Id)
            //  //.FirstOrDefaultAsync(x => x.Id == loginResult.User.Id);

            //  var user = await _userManager.GetUserByIdAsync(loginResult.User.Id);
            //  //DgDict.Add(loginResult.User.EmailAddress);
            //  //ObjectMapper.Map<User>(user);
            //  //      {
            //  //var user = await Repository.GetAllIncluding(x => x.Roles).FirstOrDefaultAsync(x => x.Id == id);



            //  DgDict.Add("CurrentLogin", Mapper.Map<CreateUserDto>(user)
            ////ObjectMapper.Map<UserDto> (loginResult.User)    
            //  ); 

            //IList<object> DgDict = new List<object>();

            //new ListResultDto<RoleListDto>(ObjectMapper.Map<List<RoleListDto>>(allRoles));

            //ICollection<UserRole> roles = loginResult.User.Roles;
            ////ICollection<UserRole> roles = user.Roles;
            //DgDict.Add(roles);

            //var allPermissions = PermissionManager.GetAllPermissions();

            //DgDict.Add(allPermissions);
            //var allRoles = await _roleRepository.GetAllListAsync();

            //DgDict.Add(allRoles);
            //.Roles
            //.WhereIf(
            //    !input.Permission.IsNullOrWhiteSpace(),
            //    r => r.Permissions.Any(rp => rp.Name == input.Permission && rp.IsGranted)
            //)
            //.ToListAsync();

            //return new ListResultDto<RoleListDto>(ObjectMapper.Map<List<RoleListDto>>(roles));



            #endregion

            #region 权限列表
            var allPermissions = PermissionManager.GetAllPermissions();
            DgDict.Add("allPermissions", new ListResultDto<PermissionDto>(
                ObjectMapper.Map<List<PermissionDto>>(allPermissions)
            ));

            #endregion

            #region 角色列表
            var allRoles = await _roleRepository.GetAllListAsync();
            DgDict.Add("allRoles", new ListResultDto<RoleListDto>(ObjectMapper.Map<List<RoleListDto>>(allRoles)));

            //new ListResultDto<RoleListDto>(ObjectMapper.Map<List<RoleListDto>>(allRoles));

            #endregion

            #region  是否有审核权 canAssignInspectionToOther
            bool canAssignInspectionToOther = PermissionChecker.IsGranted(PermissionNames.Pages_Inspection);
            //如果任务已经分配且未分配给自己，且不具有分配任务权限，则抛出异常
            //if (input.AssignedPersonId.Value != AbpSession.GetUserId() && !canAssignInspectionToOther)
            //{
            //    throw new AbpAuthorizationException("没有分配任务给他人的权限！");
            //}

            //var UserId = AbpSession.GetUserId();
            //DgDict.Add("UserId", UserId);

            if (!canAssignInspectionToOther)
            {
                DgDict.Add("canAssignInspectionToOther", "没有Pages_Inspection");
                DgDict.Add("canAssignInspectionToOtherValue", false);
            }
            else
            {
                DgDict.Add("canAssignInspectionToOther", "拥有Pages_Inspection");
                DgDict.Add("canAssignInspectionToOtherValue", true);
            }

            //return Json(DgDict);

            #endregion

            #region 可分配角色列表
            bool canAssignRolesFromAdmin = PermissionChecker.IsGranted(PermissionNames.Pages_Inspection);
            bool canAssignRolesFromRQAdmin = PermissionChecker.IsGranted(PermissionNames.Pages_Inspection);
            bool canAssignRolesFromRQAssitant = PermissionChecker.IsGranted(PermissionNames.Pages_Inspection);
            List<Role> RolescanAssigned = allRoles;

            string[] outAdmin = { "" };
            //List<Role> RolesSource = allRoles;
            //如果任务已经分配且未分配给自己，且不具有分配任务权限，则抛出异常
            if (canAssignRolesFromAdmin) //var RolesUnderYouers = allRoles;
            {
                foreach (Role item in RolescanAssigned)
                {
                    if (outAdmin.Contains(item.Name))
                    {
                        RolescanAssigned.Remove(item);
                    }  //item.SetNormalizedName in
                }
                DgDict.Add("RolescanAssigned", new ListResultDto<RoleListDto>(ObjectMapper.Map<List<RoleListDto>>(RolescanAssigned)));
                //throw new AbpAuthorizationException("没有分配任务给他人的权限！");
            }
            else if (canAssignRolesFromRQAdmin)
            {
                DgDict.Add("RolescanAssigned", new ListResultDto<RoleListDto>(ObjectMapper.Map<List<RoleListDto>>(RolescanAssigned)));

            }
            else if (canAssignRolesFromRQAssitant)
            {
                DgDict.Add("RolescanAssigned", new ListResultDto<RoleListDto>(ObjectMapper.Map<List<RoleListDto>>(RolescanAssigned)));

            }
            else
            {
                DgDict.Add("RolescanAssigned", new ListResultDto<RoleListDto>(ObjectMapper.Map<List<RoleListDto>>(RolescanAssigned)));

            }
            //    = await _roleRepository.GetAllListAsync();
            //DgDict.Add("allRoles", new ListResultDto<RoleListDto>(ObjectMapper.Map<List<RoleListDto>>(allRoles)));
            #endregion

             
            #region 登录返回UserId-accessToken--EncryptedAccessToken-ExpireInSeconds
         
            //DgDict.Add("permissionsToRolesVersion", 1001);


            var accessToken = CreateAccessToken(CreateJwtClaims(loginResult.Identity));
            DgDict.Add("AuthenticateResultModel",
                   new AuthenticateResultModel
                   {
                       AccessToken = accessToken,
                       EncryptedAccessToken = GetEncrpyedAccessToken(accessToken),
                       ExpireInSeconds = (int)_configuration.Expiration.TotalSeconds,
                       UserId = loginResult.User.Id
                   }
                );


            #endregion


            return Json(DgDict);
        }


        #region 其他功能测试接口

        [HttpPost("api/CreateUser")]
        public async Task<JsonResult> Create(CreateUserDto input)
        {
            //CheckCreatePermission();

            var user = ObjectMapper.Map<User>(input);

            user.TenantId = AbpSession.TenantId;
            user.IsEmailConfirmed = true;

            await _userManager.InitializeOptionsAsync(AbpSession.TenantId);

            CheckErrors(await _userManager.CreateAsync(user, input.Password));

            if (input.RoleNames != null)
            {
                CheckErrors(await _userManager.SetRoles(user, input.RoleNames));
            }

            CurrentUnitOfWork.SaveChanges();

            return Json(Mapper.Map<UserDto>(user));
        }

         
        [HttpPost("api/AuthenticateTest")]
        public async Task<JsonResult> All()
        {//AuthenticateResultModel
            SortedDictionary<string, object> DgDict = new SortedDictionary<string, object>();
            //IList<object> DgDict = new List<object>();

            #region 权限列表
            var allPermissions = PermissionManager.GetAllPermissions();
            DgDict.Add("allPermissions", new ListResultDto<PermissionDto>(
                ObjectMapper.Map<List<PermissionDto>>(allPermissions)
            ));

            #endregion

            #region 角色列表
            var allRoles = await _roleRepository.GetAllListAsync();
            DgDict.Add("allRoles", new ListResultDto<RoleListDto>(ObjectMapper.Map<List<RoleListDto>>(allRoles)));

            //new ListResultDto<RoleListDto>(ObjectMapper.Map<List<RoleListDto>>(allRoles));

            #endregion

            #region 可分配角色列表
            bool canAssignRolesFromAdmin = PermissionChecker.IsGranted(PermissionNames.Pages_Inspection);
            bool canAssignRolesFromRQAdmin = PermissionChecker.IsGranted(PermissionNames.Pages_Inspection);
            bool canAssignRolesFromRQAssitant = PermissionChecker.IsGranted(PermissionNames.Pages_Inspection);
            List<Role> RolescanAssigned = allRoles;

            string[] outAdmin = { "" };
            //List<Role> RolesSource = allRoles;
            //如果任务已经分配且未分配给自己，且不具有分配任务权限，则抛出异常
            if (canAssignRolesFromAdmin) //var RolesUnderYouers = allRoles;
            {
                foreach (Role item in RolescanAssigned)
                {
                    if (outAdmin.Contains(item.Name))
                    {
                        RolescanAssigned.Remove(item);
                    }  //item.SetNormalizedName in
                }
                DgDict.Add("RolescanAssigned", new ListResultDto<RoleListDto>(ObjectMapper.Map<List<RoleListDto>>(RolescanAssigned)));
                //throw new AbpAuthorizationException("没有分配任务给他人的权限！");
            }
            else if (canAssignRolesFromRQAdmin)
            {
                DgDict.Add("RolescanAssigned", new ListResultDto<RoleListDto>(ObjectMapper.Map<List<RoleListDto>>(RolescanAssigned)));

            }
            else if (canAssignRolesFromRQAssitant)
            {
                DgDict.Add("RolescanAssigned", new ListResultDto<RoleListDto>(ObjectMapper.Map<List<RoleListDto>>(RolescanAssigned)));

            }
            else
            {
                DgDict.Add("RolescanAssigned", new ListResultDto<RoleListDto>(ObjectMapper.Map<List<RoleListDto>>(RolescanAssigned)));

            }
            //    = await _roleRepository.GetAllListAsync();
            //DgDict.Add("allRoles", new ListResultDto<RoleListDto>(ObjectMapper.Map<List<RoleListDto>>(allRoles)));
            #endregion

            #region 
            #endregion


            #region 
            #endregion

            #region TrafficLogDict物流状态字典
            TrafficLog[] TrafficLogDict =
            {

                new TrafficLog(0, " 1", "2"),
                new TrafficLog(1, " 1", "2"),
                new TrafficLog(2, " 1", "2"),
                new TrafficLog(3, " 1", "2"),
                new TrafficLog(4, " 1", "2"),
                new TrafficLog(5, " 1", "2"),
                new TrafficLog(6, " 1", "2"),
                new TrafficLog(7, " 1", "2"),
                new TrafficLog(10086, " 1", "2")


            };
            DgDict.Add("TrafficLogDict", TrafficLogDict);

            #endregion

            return Json(DgDict);
        }


        [HttpPost("api/AuthenticateLogin")]
        public async Task<JsonResult> AuthenticateLogin([FromBody] AuthenticateModel model)
        {//AuthenticateResultModel
            //IList<object> DgDict = new List<object>();

            var loginResult = await GetLoginResultAsync(
                model.UserNameOrEmailAddress,
                model.Password,
                GetTenancyNameOrNull()
            );

            SortedDictionary<string, object> DgDict = new SortedDictionary<string, object>();
            bool canAssignInspectionToOther = PermissionChecker.IsGranted(PermissionNames.Pages_Inspection);
            //如果任务已经分配且未分配给自己，且不具有分配任务权限，则抛出异常
            //if (input.AssignedPersonId.Value != AbpSession.GetUserId() && !canAssignInspectionToOther)
            //{
            //    throw new AbpAuthorizationException("没有分配任务给他人的权限！");
            //}

            var UserId = AbpSession.GetUserId();
            DgDict.Add("UserId", UserId);

            if (!canAssignInspectionToOther)
            {
                DgDict.Add("canAssignInspectionToOther", "没有Pages_Inspection");
            }
            else { DgDict.Add("canAssignInspectionToOther", "拥有Pages_Inspection"); }

            return Json(DgDict);
        }


        #endregion


        #region 支持方法


        private static List<Claim> CreateJwtClaims(ClaimsIdentity identity)
        {
            var claims = identity.Claims.ToList();
            var nameIdClaim = claims.First(c => c.Type == ClaimTypes.NameIdentifier);

            // Specifically add the jti (random nonce), iat (issued timestamp), and sub (subject/user) claims.
            claims.AddRange(new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, nameIdClaim.Value),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Iat, DateTimeOffset.Now.ToUnixTimeSeconds().ToString(), ClaimValueTypes.Integer64)
            });

            return claims;
        }

        private string GetEncrpyedAccessToken(string accessToken)
        {
            return SimpleStringCipher.Instance.Encrypt(accessToken, AppConsts.DefaultPassPhrase);
        }


        private async Task<AbpLoginResult<Tenant, User>> GetLoginResultAsync(string usernameOrEmailAddress, string password, string tenancyName)
        {
            var loginResult = await _logInManager.LoginAsync(usernameOrEmailAddress, password, tenancyName);

            switch (loginResult.Result)
            {
                case AbpLoginResultType.Success:
                    return loginResult;
                default:
                    throw _abpLoginResultTypeHelper.CreateExceptionForFailedLoginAttempt(loginResult.Result, usernameOrEmailAddress, tenancyName);
            }
        }
 
        private string CreateAccessToken(IEnumerable<Claim> claims, TimeSpan? expiration = null)
        {
            var now = DateTime.UtcNow;

            var jwtSecurityToken = new JwtSecurityToken(
                issuer: _configuration.Issuer,
                audience: _configuration.Audience,
                claims: claims,
                notBefore: now,
                expires: now.Add(expiration ?? _configuration.Expiration),
                signingCredentials: _configuration.SigningCredentials
            );

            return new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);
        }








        private string GetTenancyNameOrNull()
        {
            if (!AbpSession.TenantId.HasValue)
            {
                return null;
            }

            return _tenantCache.GetOrNull(AbpSession.TenantId.Value)?.TenancyName;
        }


        #endregion
    }
}