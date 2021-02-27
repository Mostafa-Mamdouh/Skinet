using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Skinet.Dtos
{
    public class RegisterDto
    {
        [Required]
        [EmailAddress]
        public String Email { get; set; }
        [Required]

        public String DisplayName { get; set; }
        [Required]
        [RegularExpression(@"(?=^.{6,10}$)(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!@#$%^&amp;*()_+}{&quot;:;'?/&gt;.&lt;,])(?!.*\s).*$",ErrorMessage ="Password must have 1 Uppercase, 2Lowercase , 1 number , 1 non numaric and at least 6 charachters  ")]
        public String Password { get; set; }
    }
}
