using System;
namespace NLightHouse.Models
{
  public class ProjectDetail
  {
    public ProjectDetail()
    {
      Id = Guid.NewGuid().ToString();
    }
    public string Id { get; set; }
    public string description { get; set; }
  }
}