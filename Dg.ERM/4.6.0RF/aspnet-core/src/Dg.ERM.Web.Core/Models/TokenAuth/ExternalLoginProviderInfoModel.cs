﻿using Abp.AutoMapper;
using Dg.ERM.Authentication.External;

namespace Dg.ERM.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
