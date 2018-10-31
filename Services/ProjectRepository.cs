using NLightHouse.Models;
using System.Threading.Tasks;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace NLightHouse.Services
{
  public class FakeProjectRepository : IProjectRepository
  {
    public Task<Project[]> GetProjectsByFunderAsync(string UserId)
    {
      var proj1 = new Project
      {
        Title = "Test Project 1",
        Purpose = new ProjectDetail { },
        Deadline = DateTime.Now,
      };
      var proj2 = new Project
      {
        Title = "Test Project 2",
        Purpose = new ProjectDetail { },
        Deadline = DateTime.Now,
      };

      return Task.FromResult(new[] { proj1, proj2 });
    }

    public Task<Project[]> GetAllProjectsAsync()
    {
      return Task.FromResult(new[]{ new Project
      {
        Title = "Test Project 3",
        Purpose = new ProjectDetail(),
        Deadline = DateTime.Now
      }});
    }

    public Task<bool> AddProjectAsync(Project newProject)
    {
      return Task.FromResult(true);
    }

    public Task<bool> CancelProjectAsync(Guid id)
    {
      return Task.FromResult(true);
    }
  }

  public class ProjectRepository : IProjectRepository
  {
    private NLighthouseDbContext _dbContext;
    public ProjectRepository(NLighthouseDbContext dbContext)
    {
      _dbContext = dbContext;
    }

    public async Task<Project[]> GetAllProjectsAsync()
    {
      return await _dbContext.Projects.Where(p => true).ToArrayAsync();
    }
    public async Task<Project[]> GetProjectsByFunderAsync(string UserId)
    {
      return await _dbContext.Projects
        .Include(pro => pro.Funders)
        .Where(p => p.Funders.Any(f => f.PersonId == UserId))
        .ToArrayAsync();
    }
    public async Task<bool> AddProjectAsync(Project newProject)
    {
      newProject.ProjectId = Guid.NewGuid().ToString();
      newProject.Purpose = new ProjectDetail() { description = "Dummy description" };
      _dbContext.Projects.Add(newProject);
      var saveResult = await _dbContext.SaveChangesAsync();
      return saveResult > 1;
    }

    public async Task<bool> CancelProjectAsync(Guid id)
    {
      var project = await _dbContext.Projects
        .Where(x => x.ProjectId == id.ToString())
        .SingleOrDefaultAsync();

      if (project == null) return false;
      project.Canceled = true;

      var saveResult = await _dbContext.SaveChangesAsync();

      return saveResult == 1;
    }
  }

}