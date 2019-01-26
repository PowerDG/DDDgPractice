﻿using System.Threading.Tasks;
using Abp.Application.Services;
using DgMission.Sessions.Dto;

namespace DgMission.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
