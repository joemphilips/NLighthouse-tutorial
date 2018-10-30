using NLightHouse.Models;
using System.Threading.Tasks;
using System;

namespace NLightHouse.Services
{
  public interface IProjectRepository
  {
    Task<Project[]> GetProjectsByFunderAsync(string UserId);
    Task<bool> AddProjectAsync(Project newProject);

    Task<Project[]> GetAllProjectsAsync();
  }
}