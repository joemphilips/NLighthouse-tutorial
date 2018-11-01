using Microsoft.AspNetCore.Identity;

namespace NLightHouse.Models
{
  public class ApplicationUser : IdentityUser
  {
    public string PersonId { get; set; }
    public Person InfoAsPerson { get; set; }
  }
}