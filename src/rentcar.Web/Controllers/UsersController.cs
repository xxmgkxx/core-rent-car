﻿using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Authorization;
using rentcar.Authorization;
using rentcar.Users;
using Microsoft.AspNetCore.Mvc;

namespace rentcar.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Users)]
    public class UsersController : rentcarControllerBase
    {
        private readonly IUserAppService _userAppService;

        public UsersController(IUserAppService userAppService)
        {
            _userAppService = userAppService;
        }

        public async Task<ActionResult> Index()
        {
            var output = await _userAppService.GetUsers();
            return View(output);
        }
    }
}