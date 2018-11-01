using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NLightHouse.Models;

namespace NLightHouse.Controllers
{
  [Authorize(Roles = "Administrator")]
  public class ManageUsersController : Controller
  {
    private readonly UserManager<ApplicationUser> _userManager;

    public ManageUsersController(UserManager<ApplicationUser> userManager)
    {
      _userManager = userManager;
    }
    public async Task<IActionResult> Index()
    {
      var admins = (await _userManager
        .GetUsersInRoleAsync("Administrator"))
        .ToArray();

      var everyone = _userManager.Users.ToArray();

      var model = new ManageUsersViewModel
      {
        Administrators = admins,
        Everyone = everyone
      };
      return View(model);
    }
  }
}