using System;
using System.Collections.Generic;

namespace NLightHouse.Models
{
  public class Person
  {
    public Guid PersonId { get; set; }
    public string Name { get; set; }
    public List<Person> Following { get; set; }
    public List<Person> Follower { get; set; }
    public List<Person> Blocked { get; set; }

    public List<Project> OwnedProject { get; set; }
    public List<Project> FundedProject { get; set; }

  }
}