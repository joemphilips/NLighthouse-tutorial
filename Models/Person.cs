using System;
using System.Collections.Generic;

namespace NLightHouse.Models
{
  public class Person
  {
    public string PersonId { get; set; }
    public string Name { get; set; }
    public List<Person> Following { get; set; }
    public List<Person> Follower { get; set; }
    public List<Person> Blocked { get; set; }

    public List<ProjectPerson> OwnedProject { get; set; }
    public List<ProjectPerson> FundedProject { get; set; }

  }
}