using Microsoft.AspNetCore.Identity;
using System.ComponentModel;

namespace StudentAdmission.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime DOB { get; set; }
        [DefaultValue(true)]
        public bool IsActive { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        [DefaultValue("getdate()")]
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
