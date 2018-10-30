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
      var projects = await _projectRepo.GetUserRelatedProjectsAsync(new Guid());
      if (!projects.Any())
      {
        return View();
      }
      var model = new ProjectViewModel()
      {
        Projects = projects
      };
      return View(model);
    }
  }
}