using Microsoft.AspNet.Identity.EntityFramework;

namespace CSC.Core.Common.Identity
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public string FullName { get { return $"{FirstName}, {LastName}"; } }
    }
}
