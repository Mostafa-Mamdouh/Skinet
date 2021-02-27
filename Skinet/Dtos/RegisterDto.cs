using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Skinet.Dtos
{
    public class RegisterDto
    {
        public String Email { get; set; }
        public String DisplayName { get; set; }
        public String Password { get; set; }
    }
}
