using NLightHouse.Models;
using System.Threading.Tasks;
using System;

namespace NLightHouse.Services
{
  public interface IProjectRepository
  {
    Task<Project[]> GetUserRelatedProjectsAsync(Guid UserId);
  }
}