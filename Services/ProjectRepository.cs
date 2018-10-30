using NLightHouse.Models;
using System.Threading.Tasks;
using System;

namespace NLightHouse.Services
{
  public class ProjectRepository : IProjectRepository
  {
    public Task<Project[]> GetUserRelatedProjectsAsync(Guid UserId)
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
  }
}