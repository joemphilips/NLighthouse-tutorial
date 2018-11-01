using System;
using System.Collections.Generic;

namespace NLightHouse.Models
{
  public class Person : PersonBase
  {
    public ApplicationUser ApplicationUser { get; set; }

    public string ApplicationUserId { get; set; }
  }
}