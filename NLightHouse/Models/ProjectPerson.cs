using System;
using System.ComponentModel.DataAnnotations;

namespace NLightHouse.Models
{
  public class ProjectPerson
  {
    public string Id { get; set; }
    public string PersonId { get; set; }
    public Person Person { get; set; }
    public string ProjectId { get; set; }
    public Project Project { get; set; }

  }
}