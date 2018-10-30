using System;
using System.Collections.Generic;

namespace NLightHouse.Models
{
  public enum ProjectStatus
  {
    Draft,
    Open,

    Failed,
    Active,
    Abandoned,
    Succeeded,
  }
  public class Project
  {
    public string ProjectId { get; set; }
    public string Title { get; set; }
    public ProjectDetail Purpose { get; set; }
    public DateTime Deadline { get; set; }
    public List<ProjectPerson> Funders { get; set; }
    public List<ProjectPerson> Owners { get; set; }
  }
}