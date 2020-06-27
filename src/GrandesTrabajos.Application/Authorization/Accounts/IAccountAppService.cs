﻿using System.Threading.Tasks;
using Abp.Application.Services;
using GrandesTrabajos.Authorization.Accounts.Dto;

namespace GrandesTrabajos.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
