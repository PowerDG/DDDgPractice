using Abp.AutoMapper;
using PowerDg.ERM.Authentication.External;

namespace PowerDg.ERM.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
