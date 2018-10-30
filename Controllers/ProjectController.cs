using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using NLightHouse.Models;
using NLightHouse.Services;

namespace NLightHouse.Controllers
{
  public class ProjectController : Controller
  {
    private readonly IProjectRepository _projectRepo;
    public ProjectController(IProjectRepository projectRepo)
    {
      _projectRepo = projectRepo;
    }
    [HttpGet]
    public async Task<IActionResult> Index()
    {
      var projects = await _projectRepo.GetAllProjectsAsync();
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
  }
}