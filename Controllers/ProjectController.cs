using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using NLightHouse.Models;
using NLightHouse.Services;
using Microsoft.AspNetCore.Authorization;

namespace NLightHouse.Controllers
{
  [Authorize]
  public class ProjectController : Controller
  {
    private readonly IProjectRepository _projectRepo;
    private readonly UserManager<ApplicationUser> _userManager;
    public ProjectController(IProjectRepository projectRepo, UserManager<ApplicationUser> userManager)
    {
      _projectRepo = projectRepo;
      _userManager = userManager;
    }
    [HttpGet]
    public async Task<IActionResult> Index()
    {
      var currentUser = await _userManager.GetUserAsync(User);
      if (currentUser == null) return Challenge();

      var projects = await _projectRepo.GetUserRelatedProjectsAsync(currentUser);
      if (!projects.Any())
      {
        return View(new ProjectViewModel() { isEmpty = true });
      }
      var model = new ProjectViewModel()
      {
        Projects = projects,
        isEmpty = false
      };
      return View(model);
    }

    [ValidateAntiForgeryToken]
    [HttpPost]
    public async Task<IActionResult> SubmitProject(Project p)
    {
      if (!ModelState.IsValid)
      {
        return RedirectToAction("Index");
      }
      var successful = await _projectRepo.AddProjectAsync(p);

      if (!successful)
      {
        return BadRequest("Could not add Project");
      }
      return RedirectToAction("Index");
    }

    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteProject(Guid id)
    {
      if (id == Guid.Empty)
      {
        return RedirectToAction("Index");
      }

      var successful = await _projectRepo.CancelProjectAsync(id);
      if (!successful)
      {
        return BadRequest("Could not cancel Project");
      }

      return RedirectToAction("Index");
    }
  }
}