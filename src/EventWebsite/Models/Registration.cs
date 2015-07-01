using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EventWebsite.Models
{
    public class Registration : IValidatableObject
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public bool Session1 { get; set; }
        [Required]
        public bool Session2 { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (!Session1 && !Session2)
                yield return new ValidationResult("Please apply for at least one session", new string[] { "sessions" });
        }
    }
}
